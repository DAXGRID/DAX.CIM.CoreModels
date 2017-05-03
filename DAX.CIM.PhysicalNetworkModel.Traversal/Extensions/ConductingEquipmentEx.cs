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

        public static bool IsOpen(this ConductingEquipment conductingEquipment)
        {
            return (conductingEquipment as Switch)?.normalOpen ?? false;
        }

        public static bool IsInsideSubstation(this IdentifiedObject identifiedObject, CimContext context = null)
        {
            if (identifiedObject.mRID == "11b75495-ed32-41fd-863e-cf95ddbff563")
            {
            }

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

            var equipmentContainer = conductingEquipment.EquipmentContainer.Get(context);

            return equipmentContainer.GetSubstation(throwIfNotFound, context);
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

        /*
        public static Bay xGetBay(this Equipment conductingEquipment, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var equipmentContainer = conductingEquipment.EquipmentContainer.Get(context);

            if (equipmentContainer != null && equipmentContainer is Bay)
                return (Bay)equipmentContainer;
            else
                return null;
        }

        public static Bay xGetBay(this ConnectivityNode connectivityNode, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var neighbors = context.GetConnections(connectivityNode);

            foreach (var n in neighbors)
            {
                if (n.ConductingEquipment.GetBay(context) != null)
                    return n.ConductingEquipment.GetBay(context);
            }

            return null;
        }
        */

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
    }
}