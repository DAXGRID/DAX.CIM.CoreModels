﻿using DAX.CIM.PhysicalNetworkModel.Traversal;
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

        Dictionary<ConductingEquipment, List<Feeder>> _conductingEquipmentFeeders = new Dictionary<ConductingEquipment, List<Feeder>>();

        public FeederInfoContext(CimContext cimContext)
        {
            _cimContext = cimContext;
        }
        
        public void CreateFeederObjects()
        {
            CreateConnectionPointsAndFeeders();
            SubstationInternalPowerTransformerTrace();
            TraceAllFeeders();
        }

        public List<Feeder> GeConductingEquipmentFeeders(ConductingEquipment ce)
        {
            if (_conductingEquipmentFeeders.ContainsKey(ce))
                return _conductingEquipmentFeeders[ce];
            else
                return new List<Feeder>();
        }

        private void CreateConnectionPointsAndFeeders()
        {
            // Create connection points in all substation objects
            foreach (var obj in _cimContext.GetAllObjects())
            {
                if (obj is Substation)
                {
                    var st = obj as Substation;

                    var stEquipments = st.GetEquipments();

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
                                    if (!cnTc.ConductingEquipment.IsInsideSubstation())
                                    {
                                        var cp = CreateConectionPoint(cnTc.ConnectivityNode, st, stEq.GetBay());

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
                conductingEquipment.BaseVoltage < connectionPoint.Substation.GetPrimaryVoltageLevel())
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
               conductingEquipment.BaseVoltage < connectionPoint.Substation.GetPrimaryVoltageLevel())
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
                // If we hit an energy consumer, it's a customer feeder
                var traceResult = conductingEquipment.Traverse(
                    ci => !ci.IsInsideSubstation(), 
                    cn => !cn.IsInsideSubstation()
                ).ToList();

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
                        ce.IsInsideSubstation() && 
                        !ce.IsOpen() &&
                        ce.BaseVoltage < pt.GetSubstation().GetPrimaryVoltageLevel()
                     ).ToList();

                    foreach (var cimObj in traceResult)
                    {
                        if (cimObj is ConductingEquipment)
                        {
                            var ce = cimObj as ConductingEquipment;
                            if (ce.GetBay() != null)
                            {

                            }

                        }

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
                foreach (var feeder in cp.Feeders)
                {
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
                                (ce.IsInsideSubstation() && nodeTypesToPass.Contains(ce.GetSubstation().PSRType))
                                ||
                                !ce.IsInsideSubstation()
                            ),
                        cn =>
                            (
                                (cn.IsInsideSubstation() && nodeTypesToPass.Contains(cn.GetSubstation().PSRType))
                                ||
                                !cn.IsInsideSubstation()
                            )
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
    }
}