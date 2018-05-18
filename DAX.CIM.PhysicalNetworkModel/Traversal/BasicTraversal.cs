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
    }
}
