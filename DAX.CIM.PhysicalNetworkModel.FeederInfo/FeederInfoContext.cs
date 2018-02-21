using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.FeederInfo
{
    public class FeederInfoContext
    {
        private CimContext _cimContext;

        Dictionary<ConnectivityNode, ConnectionPoint> _connectionPoints = new Dictionary<ConnectivityNode, ConnectionPoint>();

        Dictionary<Substation, List<ConnectionPoint>> _stConnectionPoints = new Dictionary<Substation, List<ConnectionPoint>>();

        Dictionary<ConductingEquipment, List<Feeder>> _conductingEquipmentFeeders = new Dictionary<ConductingEquipment, List<Feeder>>();

        public FeederInfoContext(CimContext cimContext)
        {
            _cimContext = cimContext;
        }

        public List<Feeder> GetFeeders()
        {
            List<Feeder> result = new List<Feeder>();
            foreach (var ceFeeders in _conductingEquipmentFeeders)
                result.AddRange(ceFeeders.Value);

            return result;
        }

        public Dictionary<ConductingEquipment, List<Feeder>> GetConductionEquipmentFeeders()
        {
            return _conductingEquipmentFeeders;
        }
        
        public void CreateFeederObjects()
        {
            CreateConnectionPointsAndFeeders();
            SubstationInternalPowerTransformerTrace();
            TraceAllFeeders();
            FixTJunctionCustomers();
        }

        public List<Feeder> GeConductingEquipmentFeeders(ConductingEquipment ce)
        {
            if (_conductingEquipmentFeeders.ContainsKey(ce))
                return _conductingEquipmentFeeders[ce];
            else
                return new List<Feeder>();
        }

        public List<ConnectionPoint> GetSubstationConnectionPoints(Substation st)
        {
            return _stConnectionPoints[st];
        }

        private void CreateConnectionPointsAndFeeders()
        {
            // Create connection points in all substation objects
            foreach (var obj in _cimContext.GetAllObjects())
            {
                if (obj is Substation)
                {
                    var st = obj as Substation;

                    List<Equipment> stEquipments = new List<Equipment>();

                    stEquipments = st.GetEquipments(_cimContext);

                    // For each equipment inside substation
                    foreach (var stEq in stEquipments)
                    {
                        // If conducting equipment
                        if (stEq is ConductingEquipment)
                        {
                            var stCi = stEq as ConductingEquipment;

                            // For each conducting equipment terminal connection
                            foreach (var ciTc in _cimContext.GetConnections(stCi))
                            {
                                // For each connectivity node terminal connection
                                foreach (var cnTc in _cimContext.GetConnections(ciTc.ConnectivityNode))
                                {
                                    // If connected to some conducting outside station we have a connection point
                                    if (!cnTc.ConductingEquipment.IsInsideSubstation(_cimContext))
                                    {
                                        var cp = CreateConectionPoint(cnTc.ConnectivityNode, st, stEq.GetBay(false,_cimContext));

                                        CreateFeeder(cp, cnTc.ConductingEquipment);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private ConnectionPoint CreateConectionPoint(ConnectivityNode cn, Substation st, Bay bay)
        {
            if (bay != null && bay.name != null && bay.name.StartsWith("03JULI"))
            {
            }

            if (!_connectionPoints.ContainsKey(cn))
            {
                var newCp = new ConnectionPoint() { ConnectivityNode = cn, Substation = st, Bay = bay };
                _connectionPoints[cn] = newCp;

                // Add to station dict

                if (!_stConnectionPoints.ContainsKey(st))
                    _stConnectionPoints[st] = new List<ConnectionPoint>();

                _stConnectionPoints[st].Add(newCp);


                return newCp;
            }
            else
                return _connectionPoints[cn];
        }

        private void CreateFeeder(ConnectionPoint connectionPoint, ConductingEquipment conductingEquipment)
        {
            // Don't create feeder if conducting equipment already feederized
            if (connectionPoint.Feeders.Count(c => c.ACLineSegment == conductingEquipment) > 0)
                return;

            var acls = conductingEquipment as ACLineSegment;

            // Primary substation
            if (acls != null &&
                connectionPoint != null &&
                conductingEquipment != null &&
                connectionPoint.Substation != null && 
                connectionPoint.Substation.PSRType == "PrimarySubstation" && 
                conductingEquipment.BaseVoltage < connectionPoint.Substation.GetPrimaryVoltageLevel(_cimContext))
            {
                var feeder = new Feeder()
                {
                    ConnectionPoint = connectionPoint,
                    ACLineSegment = acls,
                    FeederType = FeederType.PrimarySubstation,
                    VoltageLevel = FeederVoltageLevel.MediumVoltage
                };

                connectionPoint.AddFeeder(feeder);
            }

            // Secondary substation
            if (acls != null &&
               connectionPoint != null &&
               conductingEquipment != null &&
               connectionPoint.Substation != null &&
               connectionPoint.Substation.PSRType == "SecondarySubstation" &&
               conductingEquipment.BaseVoltage < connectionPoint.Substation.GetPrimaryVoltageLevel(_cimContext))
            {
                var feeder = new Feeder()
                {
                    ConnectionPoint = connectionPoint,
                    ACLineSegment = acls,
                    FeederType = FeederType.SecondarySubstation,
                    VoltageLevel = FeederVoltageLevel.LowVoltage
                };

                connectionPoint.AddFeeder(feeder);
            }

            // Cable box
            if (acls != null &&
                connectionPoint != null &&
                conductingEquipment != null &&
                connectionPoint.Substation != null &&
                connectionPoint.Substation.PSRType == "CableBox")
            {
                // We need to do a trace to figure out if it's a customer feeder
              
                var traceResult = conductingEquipment.Traverse(
                    ci => (!ci.IsInsideSubstation(_cimContext) || (ci.IsInsideSubstation(_cimContext) && ci.GetSubstation(true,_cimContext).PSRType == "T-Junction")), 
                    cn => (!cn.IsInsideSubstation(_cimContext) || (cn.IsInsideSubstation(_cimContext) && cn.GetSubstation(true,_cimContext).PSRType == "T-Junction")),
                    false,
                    _cimContext
                ).ToList();

                // If we hit som energy consumers, it's a cablebox feeding a customer type of feeder
                if (traceResult.Count(io => io is EnergyConsumer) > 0)
                {
                    var feeder = new Feeder()
                    {
                        ConnectionPoint = connectionPoint,
                        ACLineSegment = acls,
                        FeederType = FeederType.CableBox,
                        VoltageLevel = FeederVoltageLevel.LowVoltage
                    };
                    connectionPoint.AddFeeder(feeder);
                }
            }
        }

        private void SubstationInternalPowerTransformerTrace()
        {
            // Trace all power transformers internal in the substation to enrich connectivity points
            foreach (var obj in _cimContext.GetAllObjects())
            {
                if (obj is PowerTransformer)
                {
                    var pt = obj as PowerTransformer;


                

                        var traceResult = pt.Traverse(ce =>
                            ce.IsInsideSubstation(_cimContext) &&
                            !ce.IsOpen() &&
                            ce.BaseVoltage < pt.GetSubstation(true,_cimContext).GetPrimaryVoltageLevel(_cimContext),
                            null,
                            false,
                            _cimContext
                         ).ToList();

                        foreach (var cimObj in traceResult)
                        {
                            if (cimObj is ConnectivityNode && _connectionPoints.ContainsKey((ConnectivityNode)cimObj))
                            {
                                var cp = _connectionPoints[(ConnectivityNode)cimObj];
                                cp.PowerTransformer = pt;

                                if (cp.Substation.name == "BAS")
                                {
                                    var asdasd = _connectionPoints.Where(o => o.Value.PowerTransformer == pt).ToList();
                                }
                            }
                        }

                    }
                    
            }
        }

        private void TraceAllFeeders()
        {
            foreach (var cp in _connectionPoints.Values)
            {
                foreach (var feeder in cp.Feeders)
                {
                    
                    if (feeder.ACLineSegment.mRID == "c494d297-9d5c-46dd-813d-1971b63d6f86")
                    {
                    }

                    if (feeder.ConnectionPoint.Bay != null && feeder.ConnectionPoint.Bay.name != null && feeder.ConnectionPoint.Bay.name.StartsWith("03JULI"))
                    {
                    }

                    HashSet<string> nodeTypesToPass = new HashSet<string>();

                    if (feeder.FeederType == FeederType.NetworkInjection)
                    {
                        nodeTypesToPass.Add("PrimrySubstation");
                        nodeTypesToPass.Add("Tower");
                    }
                    else if (feeder.FeederType == FeederType.PrimarySubstation)
                    {
                        if (feeder.ConnectionPoint.PowerTransformer == null)
                            continue;

                        nodeTypesToPass.Add("SecondarySubstation");
                        nodeTypesToPass.Add("Tower");
                    }
                    else if (feeder.FeederType == FeederType.SecondarySubstation)
                    {
                        if (feeder.ConnectionPoint.PowerTransformer == null)
                            continue;

                        nodeTypesToPass.Add("CableBox");
                        nodeTypesToPass.Add("Tower");
                        nodeTypesToPass.Add("T-Junction");
                    }
                    else if (feeder.FeederType == FeederType.CableBox)
                    {
                        // CableBox we should not pass though nodes.
                        nodeTypesToPass.Add("T-Junction");
                    }

                    // Regarding the trace:
                    // We need a node check on both conducting equipment and connectivity nodes, 
                    // because otherwise we risk running through the node (from one feeder to another)
                    // if feeder cables are connected directly to a cn/busbar inside the node.
                    // We include the power transformer in the trace, no matter if a base voltage is specified.
                    // We need the transformer, and sometimes the base voltage is not set. That's why.

                    var traceResult = feeder.ACLineSegment.Traverse(
                        ce =>
                            (
                                ce.BaseVoltage == feeder.ACLineSegment.BaseVoltage
                                ||
                                ce is PowerTransformer // because power transformers sometimes has no base voltage
                            )
                            &&
                            !ce.IsOpen()
                            &&
                            (
                                (ce.IsInsideSubstation(_cimContext) && nodeTypesToPass.Contains(ce.GetSubstation(true, _cimContext).PSRType))
                                ||
                                !ce.IsInsideSubstation(_cimContext)
                            ),
                        cn =>
                            (
                                (cn.IsInsideSubstation(_cimContext) && nodeTypesToPass.Contains(cn.GetSubstation(true,_cimContext).PSRType))
                                ||
                                !cn.IsInsideSubstation(_cimContext)
                            )
                            ,
                        false,
                        _cimContext
                        ).ToList();

                    foreach (var cimObj in traceResult)
                    {
                        if (cimObj is ConductingEquipment)
                        {
                            var ce = cimObj as ConductingEquipment;

                            if (!_conductingEquipmentFeeders.ContainsKey(ce))
                                _conductingEquipmentFeeders[ce] = new List<Feeder>() { feeder };
                            else
                                _conductingEquipmentFeeders[ce].Add(feeder);
                        }
                    }
                }
            }
        }

        private void FixTJunctionCustomers()
        {
            foreach (var cif in _conductingEquipmentFeeders)
            {
                if (cif.Key is EnergyConsumer)
                {
                    var ec = cif.Key as EnergyConsumer;
                    var feeders = cif.Value;

                    var cableBoxFeeders = feeders.FindAll(f => f.FeederType == FeederType.CableBox);


                    // If count is 1 then the feeder is fine.
                    // If count is > 2 something rottet, and we should not mess it up any further
                    if (cableBoxFeeders.Count == 2)
                    {
                        // Trace customer
                        HashSet<string> nodeTypesToPass = new HashSet<string>();
                        nodeTypesToPass.Add("T-Junction");
                        nodeTypesToPass.Add("Tower");
                        nodeTypesToPass.Add("CableBox");

                        var traceResult = ec.Traverse(
                       ce =>
                           ce.BaseVoltage == ec.BaseVoltage
                           &&
                           !ce.IsOpen()
                           &&
                           (
                               (ce.IsInsideSubstation(_cimContext) && nodeTypesToPass.Contains(ce.GetSubstation(true, _cimContext).PSRType))
                               ||
                               !ce.IsInsideSubstation(_cimContext)
                           ),
                       cn =>
                           (
                               (cn.IsInsideSubstation(_cimContext) && nodeTypesToPass.Contains(cn.GetSubstation(true, _cimContext).PSRType))
                               ||
                               !cn.IsInsideSubstation(_cimContext)
                           )
                           ,
                       true,
                       _cimContext
                       ).ToList();

                        // we want to searh for substation backwards
                        traceResult.Reverse();

                        Substation cableBoxToKeep = null;

                        bool startToLookForCabinet = false;

                        foreach (var traceObj in traceResult)
                        {
                            if (traceObj.IsInsideSubstation(_cimContext) && traceObj.GetSubstation(true, _cimContext).PSRType == "SecondarySubstation")
                                startToLookForCabinet = true;

                            if (startToLookForCabinet && traceObj.IsInsideSubstation(_cimContext) && traceObj.GetSubstation(true, _cimContext).PSRType == "CableBox")
                            {
                                var cableBox = traceObj.GetSubstation(true, _cimContext);

                                if (cableBoxFeeders.Exists(o => o.ConnectionPoint.Substation == cableBox))
                                {
                                    cableBoxToKeep = cableBox;
                                }
                            }
                        }

                        if (cableBoxToKeep != null)
                        {
                            List<Feeder> feedersToRemove = new List<Feeder>();
                            // Remove all cable box feeders but this one
                            foreach (var feeder in feeders)
                            {
                                if (feeder.FeederType == FeederType.CableBox && feeder.ConnectionPoint.Substation != cableBoxToKeep)
                                    feedersToRemove.Add(feeder);
                            }

                            foreach (var feederToRemove in feedersToRemove)
                                feeders.Remove(feederToRemove);
                        }

                    }
                }
            }
        }
    }
}
