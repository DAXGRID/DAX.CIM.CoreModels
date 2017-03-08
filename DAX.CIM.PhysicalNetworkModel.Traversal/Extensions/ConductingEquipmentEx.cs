using System;
using System.Collections.Generic;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Extensions
{
    public static class ConductingEquipmentEx
    {
        public static IEnumerable<IdentifiedObject> Traverse(this ConductingEquipment start, Predicate<ConductingEquipment> criteria, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var traversal = new BasicTraversal(start);

            return traversal.DFS(criteria, context);
        }

        public static bool IsOpen(this ConductingEquipment conductingEquipment)
        {
            return (conductingEquipment as Switch)?.normalOpen ?? false;
        }

        public static bool IsInsideSubstation(this ConductingEquipment conductingEquipment, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            return conductingEquipment.GetSubstation(false, context) != null;
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

        public static Substation GetSubstation(this ConductingEquipment conductingEquipment, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var equipmentContainer = conductingEquipment.EquipmentContainer.Get(context);

            return equipmentContainer.GetSubstation(throwIfNotFound, context);
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