using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Extensions
{
    public static class SubstationEx
    {
        public static double GetPrimaryVoltageLevel(this Substation st,  CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var voltageLevels = context.GetSubstationVoltageLevels(st);

            double voltageLevel = 0;

            foreach (var vl in voltageLevels)
            {
                if (vl.BaseVoltage > voltageLevel)
                    voltageLevel = vl.BaseVoltage;
            }

            return voltageLevel;                          
        }

    }
}
