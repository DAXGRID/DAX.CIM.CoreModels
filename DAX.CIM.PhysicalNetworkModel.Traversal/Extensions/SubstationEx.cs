using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Extensions
{
    public static class SubstationEx
    {
        public static double GetPrimaryVoltageLevel(this Substation st, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var voltageLevels = context.GetSubstationVoltageLevels(st);

            double voltageLevel = 0;

            foreach (var vl in voltageLevels)
            {
                if (vl.BaseVoltage > voltageLevel)
                    voltageLevel = vl.BaseVoltage;
            }

            // To support substations that have no voltage levels
            if (voltageLevel == 0)
            {
                var eq = st.GetEquipments().Find(cimOBj => cimOBj is PowerTransformer);
                if (eq != null)
                {
                    PowerTransformer pt = eq as PowerTransformer;
                    var ptNeighbors = pt.GetNeighborConductingEquipments();

                    foreach (var n in ptNeighbors)
                    {
                        if (n.BaseVoltage > voltageLevel)
                            voltageLevel = n.BaseVoltage;
                    }
                }
            }
            
            return voltageLevel;
        }

        public static VoltageLevel GetVoltageLevel(this Substation st, double voltageLevel, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var voltageLevels = context.GetSubstationVoltageLevels(st);

            VoltageLevel foundVoltageLevel = null;

            foreach (var vl in voltageLevels)
            {
                if (vl.BaseVoltage == voltageLevel)
                    foundVoltageLevel = vl;
            }

            if (throwIfNotFound && foundVoltageLevel == null)
                throw new KeyNotFoundException("Cannot find a voltage level with voltage=" + voltageLevel + " in substation mRID: " + st.mRID);
            
            return foundVoltageLevel;
        }

        /// <summary>
        /// Get all identified objects related to this substation.
        /// This includes bays, voltage levels, conducting equipments etc.
        /// </summary>
        /// <param name="st"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<Equipment> GetEquipments(this Substation st, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            return context.GetSubstationEquipments(st);
        }
    }
}
