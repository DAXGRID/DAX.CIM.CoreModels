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
        private ConductingEquipment _startConductingEquipment = null;
        public BasicTraversal(ConductingEquipment startEquipment)
        {
            _startConductingEquipment = startEquipment;
        }

        /// <summary>
        /// Conducts a Depth First Search (DFS)
        /// </summary>
        /// <param name="criteria">
        /// A criteria that is evaluated on all conducting equipment visited.
        /// If true, the conducting equipment will be included in the result, and all edges (connection to other conducting equipments through terminal and connectivity nodes) will be followed.
        /// If false, the conducting equipment will not be included in the result, and the traversal will not folow any more edges on this conducting equipment.
        /// </param>
        /// <param name="context"></param>
        /// <returns>Both conducting equipments and connetivity nodes will be returned in the result.</returns>
        public List<IdentifiedObject> DFS(Predicate<ConductingEquipment> criteria, CimContext context = null)
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
                            stack.Push(con.ConnectivityNode);
                        }
                    }
                    // We're dealing with a connection from a connectivity node
                    else
                    {
                        if (!visited.Contains(con.ConductingEquipment))
                        {
                            visited.Add(con.ConductingEquipment);

                            // If the criteria holds, add the conducting equipment to the stack for further traversal
                            if (criteria.Invoke(con.ConductingEquipment))
                                stack.Push(con.ConductingEquipment);
                            else
                            {
                                var test1 = con.ConductingEquipment.IsOpen();
                                var test2 = con.ConductingEquipment.IsInsideSubstation();
                                var test3 = con.ConductingEquipment.BaseVoltage;
                                if (test2)
                                {
                                    var test4 = con.ConductingEquipment.GetSubstation();
                                }
                            }
                        }
                    }
                }
            }

            return traverseOrder.ToList();
        }
    }
}
