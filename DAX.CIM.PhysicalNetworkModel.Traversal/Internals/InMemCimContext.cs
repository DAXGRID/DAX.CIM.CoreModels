using System;
using System.Collections.Generic;
using System.Linq;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Internals
{
    class InMemCimContext : CimContext
    {
        // Dictionary used for identified object lookup
        readonly Dictionary<string, IdentifiedObject> _objects = new Dictionary<string, IdentifiedObject>();
        readonly Dictionary<string, List<IdentifiedObject>> _duplicates = new Dictionary<string, List<IdentifiedObject>>();

        // Dictionaries used for fast traversal
        readonly Dictionary<ConductingEquipment, List<TerminalConnection>> _conductingEquipmentConnections = new Dictionary<ConductingEquipment, List<TerminalConnection>>();
        readonly Dictionary<ConnectivityNode, List<TerminalConnection>> _connectivityNodeConnections = new Dictionary<ConnectivityNode, List<TerminalConnection>>();

        // Dictionary used for substation voltage levels lookup
        readonly Dictionary<Substation, List<VoltageLevel>> _substationVoltageLevels = new Dictionary<Substation, List<VoltageLevel>>();

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

        public override double Tolerance => 0.00001;
    }
}