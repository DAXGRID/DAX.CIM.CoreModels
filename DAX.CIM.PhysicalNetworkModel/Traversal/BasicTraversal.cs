using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;

namespace DAX.CIM.PhysicalNetworkModel.Traversal
{
    public class BasicTraversal
    {
        private IdentifiedObject _startConductingEquipment = null;
        public BasicTraversal(IdentifiedObject startEquipment)
        {
            _startConductingEquipment = startEquipment;
        }

        /// <summary>
        /// Conducts a Depth First Search (DFS)
        /// </summary>
        /// <param name="ciCriteria">
        /// A criteria that is evaluated on all conducting equipment visited.
        /// If true, the conducting equipment will be included in the result, and all edges (connection to other conducting equipments through terminal and connectivity nodes) will be followed.
        /// If false, the conducting equipment will not be included in the result, and the traversal will not folow any more edges on this conducting equipment.
        /// </param>
        /// <param name="context"></param>
        /// <returns>Both conducting equipments and connetivity nodes will be returned in the result.</returns>
        public List<IdentifiedObject> DFS(Predicate<ConductingEquipment> ciCriteria, Predicate<ConnectivityNode> cnCriteria, bool includeEquipmentsWhereCriteriaIsFalse = false, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            Queue<IdentifiedObject> traverseOrder = new Queue<IdentifiedObject>();
            Stack<IdentifiedObject> stack = new Stack<IdentifiedObject>();
            HashSet<IdentifiedObject> visited = new HashSet<IdentifiedObject>();

            stack.Push(_startConductingEquipment);
            visited.Add(_startConductingEquipment);

            while (stack.Count > 0)
            {
                IdentifiedObject p = stack.Pop();

                traverseOrder.Enqueue(p);

                var connections = context.GetConnections(p);

                foreach (var con in connections)
                {
                    // If we're dealing with a connection from a conucting equipment
                    if (con.ConductingEquipment == p)
                    {
                        if (!visited.Contains(con.ConnectivityNode))
                        {
                            visited.Add(con.ConnectivityNode);

                            if (cnCriteria == null)
                                stack.Push(con.ConnectivityNode);
                            else if (cnCriteria.Invoke(con.ConnectivityNode))
                                stack.Push(con.ConnectivityNode);
                            else
                            {
                                if (includeEquipmentsWhereCriteriaIsFalse)
                                    traverseOrder.Enqueue(con.ConnectivityNode);
                            }
                        }
                    }
                    // We're dealing with a connection from a connectivity node
                    else
                    {
                        if (!visited.Contains(con.ConductingEquipment))
                        {
                            visited.Add(con.ConductingEquipment);

                            // If the criteria holds, add the conducting equipment to the stack for further traversal
                            if (ciCriteria.Invoke(con.ConductingEquipment))
                                stack.Push(con.ConductingEquipment);
                            else
                            {
                                if (includeEquipmentsWhereCriteriaIsFalse)
                                    traverseOrder.Enqueue(con.ConductingEquipment);
                            }
                        }
                    }
                }
            }

            return traverseOrder.ToList();
        }


        public List<IdentifiedObjectWithHopInfo> DFSWithHopInfo(Predicate<ConductingEquipment> ciCriteria, Predicate<ConnectivityNode> cnCriteria, bool includeEquipmentsWhereCriteriaIsFalse = false, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            Queue<IdentifiedObjectWithHopInfo> traverseOrder = new Queue<IdentifiedObjectWithHopInfo>();
            Stack<IdentifiedObject> stack = new Stack<IdentifiedObject>();
            HashSet<IdentifiedObject> visited = new HashSet<IdentifiedObject>();
            Stack<IdentifiedObject> visitedStations = new Stack<IdentifiedObject>();

            stack.Push(_startConductingEquipment);
            visited.Add(_startConductingEquipment);

            while (stack.Count > 0)
            {
                IdentifiedObject p = stack.Pop();

                // Branching checking
                if (p is ConductingEquipment)
                {
                    var ci = p as ConductingEquipment;

                    if (ci.IsInsideSubstation(context))
                    {
                        var st = ci.GetSubstation(true, context);

                        if (!visitedStations.Contains(st))
                            visitedStations.Push(st);
                        else
                        {
                            if (visitedStations.Peek() == st)
                            {
                                // We're moving around in the same station, so we're not branched
                            }
                            else
                            {
                                visitedStations.Pop();
                                // we have been branching
                            }
                        }
                    }
                }

                traverseOrder.Enqueue(new IdentifiedObjectWithHopInfo()
                {
                    IdentifiedObject = p,
                    stationHop = visitedStations.Count
                });

                var connections = SortConnectionsInternalCableLast(context, context.GetConnections(p));

                


                foreach (var con in connections)
                {
                    // If we're dealing with a connection from a conucting equipment
                    if (con.ConductingEquipment == p)
                    {
                        if (!visited.Contains(con.ConnectivityNode))
                        {
                            visited.Add(con.ConnectivityNode);

                            if (cnCriteria == null)
                                stack.Push(con.ConnectivityNode);
                            else if (cnCriteria.Invoke(con.ConnectivityNode))
                                stack.Push(con.ConnectivityNode);
                            else
                            {
                                if (includeEquipmentsWhereCriteriaIsFalse)
                                    traverseOrder.Enqueue(
                                        new IdentifiedObjectWithHopInfo()
                                        {
                                            IdentifiedObject = con.ConnectivityNode
                                        });
                            }
                        }
                    }
                    // We're dealing with a connection from a connectivity node
                    else
                    {
                        if (!visited.Contains(con.ConductingEquipment))
                        {
                            visited.Add(con.ConductingEquipment);

                            // If the criteria holds, add the conducting equipment to the stack for further traversal
                            if (ciCriteria.Invoke(con.ConductingEquipment))
                                stack.Push(con.ConductingEquipment);
                            else
                            {
                                if (includeEquipmentsWhereCriteriaIsFalse)
                                    traverseOrder.Enqueue(
                                        new IdentifiedObjectWithHopInfo()
                                        {
                                            IdentifiedObject = con.ConnectivityNode,
                                            stationHop = visitedStations.Count
                                        });
                            }
                        }
                    }
                }
            }

            return traverseOrder.ToList();
        }



        private List<TerminalConnection> SortConnectionsInternalCableLast(CimContext context, List<TerminalConnection> connections)
        {
            List<TerminalConnection> result = new List<TerminalConnection>();

            Dictionary<TerminalConnection, int> sortKey = new Dictionary<TerminalConnection, int>();

            foreach (var con in connections)
            {
                // Always trace busbars first
                if (con.ConductingEquipment is BusbarSection)
                    sortKey.Add(con, 99);
                // Trace customer line segments second 
                else if (con.ConductingEquipment is ACLineSegment && con.ConductingEquipment.PSRType != null && con.ConductingEquipment.PSRType.ToLower().Contains("customer"))
                    sortKey.Add(con, 98);
                // Trace non internal cables third
                else if (con.ConductingEquipment is ACLineSegment && con.ConductingEquipment.PSRType != "InternalCable")
                    sortKey.Add(con, 97);
                // If component sitting in a bay, use bay type to dertimine trace order
                else if (con.ConductingEquipment.HasBay(false, context))
                {
                    var bay = con.ConductingEquipment.GetBay(true, context);

                    // Componenets sitting in transformer bay should be traced last
                    if (bay.PSRType != null && bay.PSRType == "TransformerBay")
                        sortKey.Add(con, 1);
                    else
                        sortKey.Add(con, 96);
                }
                else
                {
                    sortKey.Add(con, 95);
                }
            }

            // Notice that the the last connections in the list will be traced first, because they are push to stack by caller!            
            var sortedConnections = connections.OrderBy(c => sortKey[c]);

            return sortedConnections.ToList();
        }
    }

    public class IdentifiedObjectWithHopInfo
    {
        public IdentifiedObject IdentifiedObject { get; set; }
        public int stationHop = 0;
        public override string ToString()
        {
            return "Hop: " + stationHop + " - " + IdentifiedObject.ToString();
        }

    }
}
