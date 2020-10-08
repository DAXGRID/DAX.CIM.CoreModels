using System;
using System.Collections.Generic;
using System.Linq;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Extensions
{
    public static class ConductingEquipmentEx
    {
        public static IEnumerable<IdentifiedObject> Traverse(this IdentifiedObject start, Predicate<ConductingEquipment> ciCriteria, Predicate<ConnectivityNode> cnCriteria = null, bool includeEquipmentsWhereCriteriaIsFalse = false, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var traversal = new BasicTraversal(start);

            return traversal.DFS(ciCriteria, cnCriteria, includeEquipmentsWhereCriteriaIsFalse, context);
        }

        public static IEnumerable<IdentifiedObjectWithHopInfo> TraverseWithHopInfo(this IdentifiedObject start, Predicate<ConductingEquipment> ciCriteria, Predicate<ConnectivityNode> cnCriteria = null, bool includeEquipmentsWhereCriteriaIsFalse = false, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var traversal = new BasicTraversal(start);

            return traversal.DFSWithHopInfo(ciCriteria, cnCriteria, includeEquipmentsWhereCriteriaIsFalse, context);
        }

        public static bool IsOpen(this ConductingEquipment conductingEquipment)
        {
            return (conductingEquipment as Switch)?.normalOpen ?? false;
        }

        public static bool IsInsideSubstation(this IdentifiedObject identifiedObject, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            if (identifiedObject is Equipment)
                return ((Equipment)identifiedObject).GetSubstation(false, context) != null;

            // If connectivity node, check if associated with something inside a substation
            if (identifiedObject is ConnectivityNode)
            {
                var neighbors = context.GetConnections(identifiedObject);

                if (neighbors.Count(n => n.ConductingEquipment.GetSubstation(false, context) != null) > 0)
                    return true;
            }

            if (identifiedObject is VoltageLevel)
            {
                var voltageLevel = (VoltageLevel)identifiedObject;

                return voltageLevel.EquipmentContainer1.Get(context).GetSubstation(false, context) != null;
            }

            if (identifiedObject is BayExt)
            {
                var bayExt = (BayExt)identifiedObject;

                return bayExt.VoltageLevel.Get(context).GetSubstation(false, context) != null;
            }

            if (identifiedObject is PowerTransformerEnd)
            {
                var ptEnd = (PowerTransformerEnd)identifiedObject;

                //return bayExt.VoltageLevel.Get(context).GetSubstation(false, context) != null;
                if (ptEnd.PowerTransformer != null && ptEnd.PowerTransformer.@ref != null)
                {
                    return context.GetObject<PowerTransformer>(ptEnd.PowerTransformer.@ref).GetSubstation(false, context) != null;
                }
            }

            return false;
        }

        public static bool IsInsideSubstation(this VoltageLevel voltageLevel, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            return voltageLevel.GetSubstation(false, context) != null;
        }

        public static Substation GetSubstation(this EquipmentContainer equipmentContainer, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            if (equipmentContainer is Substation)
            {
                return (Substation)equipmentContainer;
            }

            if (equipmentContainer is VoltageLevel)
            {
                var voltageLevel = (VoltageLevel)equipmentContainer;

                return voltageLevel.EquipmentContainer1.Get(context).GetSubstation(throwIfNotFound, context);
            }

            if (equipmentContainer is BayExt)
            {
                var bayExt = (BayExt)equipmentContainer;

                return bayExt.VoltageLevel.Get(context).GetSubstation(throwIfNotFound, context);
            }

            if (!throwIfNotFound) return null;

            throw new ArgumentException($"Could not find SubStation from equipment container {equipmentContainer}");
        }

        public static Substation GetSubstation(this Equipment conductingEquipment, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            if (throwIfNotFound)
            {
                var equipmentContainer = conductingEquipment.EquipmentContainer.Get(context);
                return equipmentContainer.GetSubstation(throwIfNotFound, context);

            }
            else
            {
                try
                {
                    var equipmentContainer = conductingEquipment.EquipmentContainer.Get(context);
                    return equipmentContainer.GetSubstation(throwIfNotFound, context);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public static Substation GetSubstation(this ConnectivityNode connectivityNode, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var neighbors = context.GetConnections(connectivityNode);

            foreach (var n in neighbors)
            {
                if (n.ConductingEquipment.GetSubstation(false, context) != null)
                    return n.ConductingEquipment.GetSubstation(false, context);
            }

            return null;
        }

        public static Substation GetSubstation(this IdentifiedObject identifiedObject, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            if (identifiedObject is Equipment)
                return GetSubstation((Equipment)identifiedObject, throwIfNotFound, context);
            else if (identifiedObject is ConnectivityNode)
                return GetSubstation((ConnectivityNode)identifiedObject, throwIfNotFound, context);
            else if (identifiedObject is VoltageLevel)
                return context.GetObject<Substation>(((VoltageLevel)identifiedObject).EquipmentContainer1.@ref);
            else if (identifiedObject is Bay)
                return GetSubstation(context.GetObject<VoltageLevel>(((Bay)identifiedObject).VoltageLevel.@ref), throwIfNotFound, context);
            else if (identifiedObject is TransformerEnd)
            {
                var terminal = context.GetObject<Terminal>(((TransformerEnd)identifiedObject).Terminal.@ref);
                var pt = context.GetObject<PowerTransformer>(terminal.ConductingEquipment.@ref);
                return context.GetObject<Substation>(pt.EquipmentContainer.@ref);
            }

            return null;
        }

        public static List<ConductingEquipment> GetNeighborConductingEquipments(this ConductingEquipment conductingEquipment, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            List<ConductingEquipment> result = new List<ConductingEquipment>();

            var eqConnections = context.GetConnections(conductingEquipment);
            foreach (var eqConn in eqConnections)
            {
                var cnConnections = context.GetConnections(eqConn.ConnectivityNode);

                foreach (var cnCon in cnConnections)
                {
                    if (cnCon.ConductingEquipment != conductingEquipment)
                        result.Add(cnCon.ConductingEquipment);
                }
            }

            return result;
        }

        public static List<ConductingEquipment> GetNeighborConductingEquipments(this ConnectivityNode cn, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            List<ConductingEquipment> result = new List<ConductingEquipment>();

            var cnConnections = context.GetConnections(cn);

            foreach (var cnCon in cnConnections)
            {
                result.Add(cnCon.ConductingEquipment);
            }

            return result;
        }

        public static Bay GetBay(this IdentifiedObject identifiedObject, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            if (identifiedObject is Equipment)
            {
                var equipmentContainer = ((Equipment)identifiedObject).EquipmentContainer.Get(context);

                if (equipmentContainer != null && equipmentContainer is Bay)
                    return (Bay)equipmentContainer;
                else
                    return null;
            }
            else if (identifiedObject is ConnectivityNode)
            {
                var neighbors = context.GetConnections(identifiedObject);

                foreach (var n in neighbors)
                {
                    if (n.ConductingEquipment.GetBay() != null)
                        return n.ConductingEquipment.GetBay();
                }

                return null;
            }
                

            return null;
        }

        public static bool HasBay(this IdentifiedObject identifiedObject, bool throwIfNotFound = true, CimContext context = null)
        {
            return GetBay(identifiedObject, false, context) != null;
        }


        public static EquipmentContainer Get(this EquipmentEquipmentContainer equipmentEquipmentContainer, CimContext context = null)
        {
            if (equipmentEquipmentContainer == null)
                return null;

            context = context ?? CimContext.GetCurrent();

            return context.GetObject<EquipmentContainer>(equipmentEquipmentContainer.@ref);
        }

        public static EquipmentContainer Get(this VoltageLevelEquipmentContainer voltageLevelEquipmentContainer, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            return context.GetObject<EquipmentContainer>(voltageLevelEquipmentContainer.@ref);
        }

        public static EquipmentContainer Get(this BayVoltageLevel bayVoltageLevel, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            return context.GetObject<EquipmentContainer>(bayVoltageLevel.@ref);
        }

        /// <summary>
        /// Find the terminal that is connected to the conducting equipment specified in connectedTo
        /// </summary>
        /// <param name="conductingEquipment"></param>
        /// <param name="connectedTo"></param>
        /// <param name="throwIfNotFound"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static Terminal GetTerminal(this ConductingEquipment conductingEquipment, ConductingEquipment connectedTo, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var terminalConnections = context.GetConnections(conductingEquipment);
            
            foreach (var connection in terminalConnections)
            {
                if (connection.ConnectivityNode != null)
                {
                    var cnConnections = context.GetConnections(connection.ConnectivityNode);

                    // See if any of the CEs that the terminal's CN is connected to is equal connectedTo
                    foreach (var cnConnection in cnConnections)
                    {
                        if (cnConnection.ConductingEquipment == connectedTo)
                            return connection.Terminal;
                    }
                }
            }

            if (throwIfNotFound)
                throw new KeyNotFoundException("Cannot find any conduction equipment with mRID=" + connectedTo.mRID + " connected to conducting equipment with mRID=" + conductingEquipment.mRID);

            return null;
        }

    }
}