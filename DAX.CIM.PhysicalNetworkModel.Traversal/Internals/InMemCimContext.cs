using System;
using System.Collections.Generic;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Internals
{
    
    public class InMemCimContext : CimContext
    {
        // Dictionary used for identified object lookup
        readonly Dictionary<string, IdentifiedObject> _objects = new Dictionary<string, IdentifiedObject>();
        readonly Dictionary<string, List<IdentifiedObject>> _duplicates = new Dictionary<string, List<IdentifiedObject>>();

        // Dictionaries used for fast traversal
        readonly Dictionary<ConductingEquipment, List<TerminalConnection>> _conductingEquipmentConnections = new Dictionary<ConductingEquipment, List<TerminalConnection>>();
        readonly Dictionary<ConnectivityNode, List<TerminalConnection>> _connectivityNodeConnections = new Dictionary<ConnectivityNode, List<TerminalConnection>>();

        // Dictionary used for fast substation voltage levels lookup
        readonly Dictionary<Substation, List<VoltageLevel>> _substationVoltageLevels = new Dictionary<Substation, List<VoltageLevel>>();

        // Dictionary used for fast substation children lookup
        readonly Dictionary<Substation, List<Equipment>> _substationChildren = new Dictionary<Substation, List<Equipment>>();

        // Dictionary used for fast power tranformer end lookup
        readonly Dictionary<PowerTransformer, List<PowerTransformerEnd>> _powerTransformerEnds = new Dictionary<PowerTransformer, List<PowerTransformerEnd>>();

        // Dictionary used for fast tap changer lookup
        readonly Dictionary<PowerTransformerEnd, List<TapChanger>> _ptEndTapChanges = new Dictionary<PowerTransformerEnd, List<TapChanger>>();


        public InMemCimContext(IEnumerable<IdentifiedObject> objects)
        {
            Load(objects);
        }

        public override int Count => _objects.Count;

        void Load(IEnumerable<IdentifiedObject> objects)
        {
            // Initialize dictionary for identified objects lookup
            foreach (var obj in objects)
            {
                var id = obj.mRID;

                if (_objects.ContainsKey(id))
                {
                    List<IdentifiedObject> duplicates;

                    if (!_duplicates.TryGetValue(id, out duplicates))
                    {
                        duplicates = new List<IdentifiedObject> { _objects[id] };
                        _duplicates[id] = duplicates;
                    }

                    duplicates.Add(obj);
                }
                else
                {
                    _objects[id] = obj;
                }
            }

            // Initialize dictionaries used for connectivity traversal
            foreach (var obj in _objects.Values)
            {
                if (obj is Terminal)
                {
                    Terminal terminal = obj as Terminal;

                    // Check if terminal has a proper connection to both conducting equipment and connectivity node before creating connection object
                    if (terminal.ConductingEquipment != null &&
                        terminal.ConductingEquipment.@ref != null &&
                        _objects.ContainsKey(terminal.ConductingEquipment.@ref) &&
                        terminal.ConnectivityNode != null &&
                        terminal.ConnectivityNode.@ref != null &&
                        _objects.ContainsKey(terminal.ConnectivityNode.@ref))
                    {
                        var tc = new TerminalConnection()
                        {
                            Terminal = terminal,
                            ConductingEquipment = GetObject<ConductingEquipment>(terminal.ConductingEquipment.@ref),
                            ConnectivityNode = GetObject<ConnectivityNode>(terminal.ConnectivityNode.@ref)
                        };

                        // Upsert connectivity node connections
                        if (!_connectivityNodeConnections.ContainsKey(tc.ConnectivityNode))
                            _connectivityNodeConnections[tc.ConnectivityNode] = new List<TerminalConnection> { tc };
                        else
                            _connectivityNodeConnections[tc.ConnectivityNode].Add(tc);

                        // Upsert conducting equipment connections
                        if (!_conductingEquipmentConnections.ContainsKey(tc.ConductingEquipment))
                            _conductingEquipmentConnections[tc.ConductingEquipment] = new List<TerminalConnection> { tc };
                        else
                            _conductingEquipmentConnections[tc.ConductingEquipment].Add(tc);
                    }
                }
            }

            // Initialize dictionary for voltage levels lookup
            foreach (var obj in _objects.Values)
            {
                if (obj is VoltageLevel)
                {
                    VoltageLevel vl = obj as VoltageLevel;

                    if (vl.EquipmentContainer1 != null &&
                        vl.EquipmentContainer1.@ref != null &&
                        _objects.ContainsKey(vl.EquipmentContainer1.@ref))
                    {
                        var st = GetObject<Substation>(vl.EquipmentContainer1.@ref);

                        // Upsert voltage levels dictionary
                        if (!_substationVoltageLevels.ContainsKey(st))
                            _substationVoltageLevels[st] = new List<VoltageLevel> { vl };
                        else
                            _substationVoltageLevels[st].Add(vl);
                    }

                }
            }

            // Initialize dictionary for substation children lookup
            foreach (var obj in _objects.Values)
            {
                if (obj is Equipment)
                {
                    var eq = obj as Equipment;

                        
                    if (eq.IsInsideSubstation(this))
                    {
                        var st = eq.GetSubstation(true, this);

                        // Upsert substation children dictionary
                        if (!_substationChildren.ContainsKey(st))
                            _substationChildren[st] = new List<Equipment> { eq };
                        else
                            _substationChildren[st].Add(eq);

                    }

                }
            }

            // Initialize dictionary for power transformer ends lookup
            foreach (var obj in _objects.Values)
            {
                if (obj is PowerTransformerEnd)
                {
                    var ptEnd = obj as PowerTransformerEnd;


                    if (ptEnd.PowerTransformer != null && ptEnd.PowerTransformer.@ref != null)
                    {
                        var pt = _objects[ptEnd.PowerTransformer.@ref] as PowerTransformer;

                        // Upsert power transformer end
                        if (!_powerTransformerEnds.ContainsKey(pt))
                            _powerTransformerEnds[pt] = new List<PowerTransformerEnd> { ptEnd };
                        else
                            _powerTransformerEnds[pt].Add(ptEnd);
                    }
                }
            }

            // Initialize dictionary for power transformer tapchanger lookup
            foreach (var obj in _objects.Values)
            {
                if (obj is RatioTapChanger)
                {
                    var ptTap = obj as RatioTapChanger;


                    if (ptTap.TransformerEnd != null && ptTap.TransformerEnd.@ref != null)
                    {
                        var end = _objects[ptTap.TransformerEnd.@ref] as PowerTransformerEnd;

                        // Upsert power transformer tab changer
                        if (!_ptEndTapChanges.ContainsKey(end))
                            _ptEndTapChanges[end] = new List<TapChanger> { ptTap };
                        else
                            _ptEndTapChanges[end].Add(ptTap);
                    }
                }
            }


        }

        public override IEnumerable<TIdentifiedObject> OfType<TIdentifiedObject>()
        {
            return _objects.Values.OfType<TIdentifiedObject>();
        }

        public override TIdentifiedObject GetObject<TIdentifiedObject>(string mRID)
        {
            IdentifiedObject obj;

            if (!_objects.TryGetValue(mRID, out obj))
            {
                throw new ArgumentException($"Could not find object with mRID {mRID}");
            }

            try
            {
                return (TIdentifiedObject) obj;
            }
            catch (Exception exception)
            {
                throw new ArgumentException($"Could not return object with mRID {mRID} as {typeof(TIdentifiedObject)} because it is {obj.GetType()}", exception);
            }
        }

        public override List<IdentifiedObject> GetAllObjects()
        {
            return _objects.Values.ToList();
        }

        public override List<TerminalConnection> GetConnections(ConductingEquipment ci)
        {
            if (_conductingEquipmentConnections.ContainsKey(ci))
                return _conductingEquipmentConnections[ci];
            else
                return new List<TerminalConnection>();
        }

        public override List<TerminalConnection> GetConnections(ConnectivityNode cn)
        {
            if (_connectivityNodeConnections.ContainsKey(cn))
                return _connectivityNodeConnections[cn];
            else
                return new List<TerminalConnection>();
        }

        public override List<TerminalConnection> GetConnections(IdentifiedObject io)
        {
            if (io is ConductingEquipment)
                return GetConnections((ConductingEquipment)io);
            else if (io is ConnectivityNode)
                return GetConnections((ConnectivityNode)io);
            else
                return new List<TerminalConnection>();
        }

        public override List<VoltageLevel> GetSubstationVoltageLevels(Substation st)
        {
            if (_substationVoltageLevels.ContainsKey(st))
                return _substationVoltageLevels[st];
            else
                return new List<VoltageLevel>();
        }

        public override List<Equipment> GetSubstationEquipments(Substation st)
        {
            if (_substationChildren.ContainsKey(st))
                return _substationChildren[st];
            else
                return new List<Equipment>();
        }

        public override List<PowerTransformerEnd> GetPowerTransformerEnds(PowerTransformer pt)
        {
            if (_powerTransformerEnds.ContainsKey(pt))
                return _powerTransformerEnds[pt];
            else
                return new List<PowerTransformerEnd>();
        }

        public override List<TapChanger> GetPowerTransformerEndTapChangers(PowerTransformerEnd end)
        {
            if (_ptEndTapChanges.ContainsKey(end))
                return _ptEndTapChanges[end];
            else
                return new List<TapChanger>();
        }

        public override void ConnectTerminalToAnotherConnectitityNode(Terminal terminal, ConnectivityNode newCn)
        {
            var terminalCe = GetObject<ConductingEquipment>(terminal.ConductingEquipment.@ref);
            var terminalExistingCn = GetObject<ConnectivityNode>(terminal.ConnectivityNode.@ref);

            // Remove and add terminal connection on from terminal equipment
            var fromTerminalConnections = GetConnections(terminalCe);
            var terminalConnectionToRemove = fromTerminalConnections.Find(o => o.ConnectivityNode == terminalExistingCn);
            var newTerminalConnection = new TerminalConnection() { ConductingEquipment = terminalCe, Terminal = terminal, ConnectivityNode = newCn };

            if (newTerminalConnection.ConductingEquipment == null)
                throw new Exception("Terminal with mRID=" + terminal.mRID + " has no conducting equipment relation");
            
            // Remove existing terminal connection from terminal
            fromTerminalConnections.Remove(fromTerminalConnections.Find(o => o.ConnectivityNode == terminalExistingCn));

            // Add new terminal connection to terminal
            fromTerminalConnections.Add(newTerminalConnection);

            // Remove terminal connection on from existing connectivity node
            var existingCnConnections = GetConnections(terminalExistingCn);
            existingCnConnections.Remove(existingCnConnections.Find(o => o.Terminal == terminal));

            // Add terminal connection to new CN
            var newCnConnections = GetConnections(newCn);
            newCnConnections.Add(newTerminalConnection);

            terminal.ConnectivityNode.@ref = newCn.mRID;
        }

        /// <summary>
        /// Disconnect a terminal from its connectivity node
        /// </summary>
        /// <param name="terminal"></param>
        public override void DisconnectTerminalFromConnectitityNode(Terminal terminal)
        {
            var terminalCe = GetObject<ConductingEquipment>(terminal.ConductingEquipment.@ref);
            var terminalExistingCn = GetObject<ConnectivityNode>(terminal.ConnectivityNode.@ref);

            // Remove terminal connection on from terminal equipment
            var fromTerminalConnections = GetConnections(terminalCe);
            var terminalConnectionToRemove = fromTerminalConnections.Find(o => o.ConnectivityNode == terminalExistingCn);
            fromTerminalConnections.Remove(fromTerminalConnections.Find(o => o.ConnectivityNode == terminalExistingCn));

            // Remove terminal connection on from existing connectivity node
            var existingCnConnections = GetConnections(terminalExistingCn);
            existingCnConnections.Remove(existingCnConnections.Find(o => o.Terminal == terminal));

            terminal.ConnectivityNode = null;
        }

        public override double Tolerance => 0.00001;
    }
}