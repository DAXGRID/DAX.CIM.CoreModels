using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace DAX.CIM.PhysicalNetworkModel.FeederInfo
{
    public class FeederInfoContext
    {
        readonly Dictionary<ConnectivityNode, ConnectionPoint> _connectionPoints = new Dictionary<ConnectivityNode, ConnectionPoint>();
        readonly Dictionary<Substation, List<ConnectionPoint>> _stConnectionPoints = new Dictionary<Substation, List<ConnectionPoint>>();
        readonly Dictionary<ConductingEquipment, List<Feeder>> _conductingEquipmentFeeders = new Dictionary<ConductingEquipment, List<Feeder>>();
        readonly CimContext _cimContext;

        public FeederInfoContext(CimContext cimContext)
        {
            _cimContext = cimContext;
        }

        public List<Feeder> GetFeeders()
        {
            return _conductingEquipmentFeeders
                .SelectMany(f => f.Value)
                .ToList();
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
            // Create feeder connection points in all substation objects
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
                                        var cp = CreateConnectionPoint(ConnectionPointKind.Line, cnTc.ConnectivityNode, st, stEq.GetBay(false,_cimContext));

                                        CreateFeeder(cp, cnTc.ConductingEquipment);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Create trafo connection points in all substation objects
            foreach (var obj in _cimContext.GetAllObjects())
            {
                if (obj is PowerTransformer)
                {
                    var trafo = obj as PowerTransformer;
                    var st = trafo.GetSubstation(false, _cimContext);
                    var trafoConnections = _cimContext.GetConnections(trafo);

                    // Find terminal 2
                    if (trafoConnections.Exists(c => c.Terminal.sequenceNumber == "2"))
                    {
                        var trafoTerminal2Connection = trafoConnections.First(c => c.Terminal.sequenceNumber == "2");

                        if (!_connectionPoints.ContainsKey(trafoTerminal2Connection.ConnectivityNode))
                        {
                            var cp = CreateConnectionPoint(ConnectionPointKind.PowerTranformer, trafoTerminal2Connection.ConnectivityNode, st, null);
                            CreateFeeder(cp, trafo);
                        }
                        else
                        {

                        }
                    }
                }
            }

            // Create connection points on all external network injections
            foreach (var obj in _cimContext.GetAllObjects())
            {
                if (obj is ExternalNetworkInjection)
                {
                    var source = obj as ExternalNetworkInjection;
                    var sourceConnections = _cimContext.GetConnections(source);

                    // Find terminal 1
                    if (sourceConnections.Exists(c => c.Terminal.sequenceNumber == "1"))
                    {
                        var trafoTerminal2Connection = sourceConnections.First(c => c.Terminal.sequenceNumber == "1");

                        if (!_connectionPoints.ContainsKey(trafoTerminal2Connection.ConnectivityNode))
                        {
                            var cp = CreateConnectionPoint(ConnectionPointKind.ExternalNetworkInjection, trafoTerminal2Connection.ConnectivityNode, null, null);
                            CreateFeeder(cp, source);
                        }
                    }
                }
            }
        }

        private ConnectionPoint CreateConnectionPoint(ConnectionPointKind kind, ConnectivityNode cn, Substation st, Bay bay)
        {

            if (st.mRID == "59c15301-79a5-4b2a-9cb3-b58dcdd640d3")
            {
            }

            if (!_connectionPoints.ContainsKey(cn))
            {
                var newCp = new ConnectionPoint() { Kind = kind, ConnectivityNode = cn, Substation = st, Bay = bay };
                _connectionPoints[cn] = newCp;

                // Add to station dict
                if (!_stConnectionPoints.ContainsKey(st))
                    _stConnectionPoints[st] = new List<ConnectionPoint>();

                _stConnectionPoints[st].Add(newCp);

                if (st.ConnectionPoints == null)
                    st.ConnectionPoints = new List<ConnectionPoint>();

                st.ConnectionPoints.Add(newCp);

                return newCp;
            }
            else
                return _connectionPoints[cn];
        }

        private void CreateFeeder(ConnectionPoint connectionPoint, ConductingEquipment conductingEquipment)
        {
            // Don't create feeder if conducting equipment already feederized
            if (connectionPoint.Feeders.Count(c => c.ConductingEquipment == conductingEquipment) > 0)
                return;

            // External Network Injection
            if (connectionPoint != null &&
                conductingEquipment != null &&
                conductingEquipment is ExternalNetworkInjection)
            {
                var feeder = new Feeder()
                {
                    ConnectionPoint = connectionPoint,
                    ConductingEquipment = conductingEquipment,
                    FeederType = FeederType.NetworkInjection,
                    VoltageLevel = FeederVoltageLevel.HighVoltage
                };

                connectionPoint.AddFeeder(feeder);
            }

            // Primary substation
            if (connectionPoint != null &&
                conductingEquipment != null &&
                connectionPoint.Substation != null && 
                connectionPoint.Substation.PSRType == "PrimarySubstation" && 
                conductingEquipment.BaseVoltage < connectionPoint.Substation.GetPrimaryVoltageLevel(_cimContext))
            {
                var feeder = new Feeder()
                {
                    ConnectionPoint = connectionPoint,
                    ConductingEquipment = conductingEquipment,
                    FeederType = FeederType.PrimarySubstation,
                    VoltageLevel = FeederVoltageLevel.MediumVoltage
                };

                connectionPoint.AddFeeder(feeder);
            }

            // Secondary substation
            if (connectionPoint != null &&
               conductingEquipment != null &&
               connectionPoint.Substation != null &&
               connectionPoint.Substation.PSRType == "SecondarySubstation" &&
               conductingEquipment.BaseVoltage < connectionPoint.Substation.GetPrimaryVoltageLevel(_cimContext))
            {
                var feeder = new Feeder()
                {
                    ConnectionPoint = connectionPoint,
                    ConductingEquipment = conductingEquipment,
                    FeederType = FeederType.SecondarySubstation,
                    VoltageLevel = FeederVoltageLevel.LowVoltage
                };

                connectionPoint.AddFeeder(feeder);
            }

            // Cable box
            if (connectionPoint != null &&
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
                        ConductingEquipment = conductingEquipment,
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
                        ce.BaseVoltage < pt.GetSubstation(true, _cimContext).GetPrimaryVoltageLevel(_cimContext),
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
                        }
                    }
                }
            }
        }

        private void TraceAllFeeders()
        {
            foreach (var cp in _connectionPoints.Values)
            {
                ////////////////////////////////////////////////////////////////
                // Line and external network injection feeders 

                if (cp.Kind == ConnectionPointKind.Line || cp.Kind == ConnectionPointKind.ExternalNetworkInjection)
                {
                    
                    foreach (var feeder in cp.Feeders)
                    {
                        if (feeder.ConductingEquipment is ExternalNetworkInjection)
                        {

                        }

                        HashSet<string> nodeTypesToPass = new HashSet<string>();

                        if (feeder.FeederType == FeederType.NetworkInjection)
                        {
                            nodeTypesToPass.Add("PrimarySubstation");
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

                        var traceResult = feeder.ConductingEquipment.Traverse(
                            ce =>
                                (
                                    ce.BaseVoltage == feeder.ConductingEquipment.BaseVoltage
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
                                    (cn.IsInsideSubstation(_cimContext) && nodeTypesToPass.Contains(cn.GetSubstation(true, _cimContext).PSRType))
                                    ||
                                    !cn.IsInsideSubstation(_cimContext)
                                )
                                ,
                            true,
                            _cimContext
                            ).ToList();

                        int energyConsumerCount = 0;

                        foreach (var cimObj in traceResult)
                        {
                            // kabel før trafo 2 i sho
                            if (cimObj.mRID == "eb0bed2f-0779-4a2e-ba56-bc2199666509")
                            {
                                var connections = _cimContext.GetConnections(cimObj);
                                /*
                                foreach (var cn in connections)
                                {
                                    var connections2 = _cimContext.GetConnections(cn.ConnectivityNode);

                                    foreach (var cn2 in connections2)
                                    {
                                        if (cn2.ConductingEquipment is PowerTransformer)
                                        {
                                            var st = cn2.ConductingEquipment.GetSubstation();
                                            var isst = cn2.ConductingEquipment.IsInsideSubstation();
                                        }
                                    }
                                }
                                */
                            }

                            if (cimObj is EnergyConsumer)
                                energyConsumerCount++;

                            if (cimObj is ConductingEquipment)
                            {
                                var ce = cimObj as ConductingEquipment;

                                // acls feeder by byg, that don't get feeder
                                if (ce.mRID == "cbfe60cc-e56c-40ef-a525-10abde3b81e8")
                                {
                                }

                                AssignFeederToConductingEquipment(ce, feeder);

                                // If a busbar add feeder to substation as well
                                if (ce is BusbarSection)
                                {
                                    var st = ce.GetSubstation(false, _cimContext);

                                    if (st != null)
                                    {
                                        if (st.InternalFeeders == null)
                                            st.InternalFeeders = new List<Feeder>();

                                        st.Feeders.Add(feeder);
                                    }
                                }
                            }
                        }

                        if (feeder.ConnectionPoint.PowerTransformer != null)
                        {
                            feeder.ConnectionPoint.PowerTransformer.EnergyConsumerCount += energyConsumerCount;
                        }
                    }
                }

                ////////////////////////////////////////////////////////////////
                // power transformer feeders
                if (cp.Kind == ConnectionPointKind.PowerTranformer)
                {
                    foreach (var feeder in cp.Feeders)
                    {
                        var pt = feeder.ConductingEquipment as PowerTransformer;

                        var traceResult = pt.Traverse(ce =>
                           ce.IsInsideSubstation(_cimContext) &&
                           !ce.IsOpen() &&
                           ce.BaseVoltage < pt.GetSubstation(true, _cimContext).GetPrimaryVoltageLevel(_cimContext),
                           null,
                           true,
                           _cimContext
                        ).ToList();

                        foreach (var cimObj in traceResult)
                        {
                            if (cimObj is ConductingEquipment)
                            {
                                var ce = cimObj as ConductingEquipment;

                                // We don't want to add feeder to power transformers and ac line segments outsit station.
                                if (!(ce is PowerTransformer) && !(ce is ACLineSegment && !ce.IsInsideSubstation(_cimContext)))
                                    AssignFeederToConductingEquipment(ce, feeder);
                            }
                        }
                    }
                } 
            }
        }

        private void AssignFeederToConductingEquipment(ConductingEquipment ce, Feeder feeder)
        {
            if (!_conductingEquipmentFeeders.ContainsKey(ce))
                _conductingEquipmentFeeders[ce] = new List<Feeder>() { feeder };
            else
            {
                var ceFeeders = _conductingEquipmentFeeders[ce];

                if (ceFeeders.Count > 2)
                {

                }

                // Only add feeder if conducting equipment not already addede to a feeder attached to the same connectivity node
                if (ceFeeders.Count(f => f.ConnectionPoint == feeder.ConnectionPoint) == 0)
                {
                    if (!ceFeeders.Contains(feeder))
                        ceFeeders.Add(feeder);
                }
            }

            // Add to internal feeder list
            if (ce.InternalFeeders == null)
                ce.InternalFeeders = new List<Feeder>();

            // Only add feeder if conducting equipment not already added to a feeder attached to the same connectivity node
            if (ce.InternalFeeders.Count(f => f.ConnectionPoint == feeder.ConnectionPoint) == 0)
            {
                if (!ce.InternalFeeders.Contains(feeder))
                    ce.InternalFeeders.Add(feeder);
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
