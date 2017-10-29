using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Extensions
{
    public static class EnergyConsumerEx
    {
        /// <summary>
        /// Get the generating unit of the energy consumer object. 
        /// </summary>
        /// <param name="identifiedObject"></param>
        /// <param name="throwIfNotFound"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static GeneratingUnit GetGeneratingUnit(this EnergyConsumer ec, bool throwIfNotFound = true, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var genUnit = context.GetEnergyConsumerGeneratingUnit(ec);

            if (genUnit != null)
                return genUnit;

            if (throwIfNotFound)
                    throw new KeyNotFoundException("Cannot find any generating unit on energy consumer with mRID=" + ec.mRID);

            return null;
        }

        /// <summary>
        /// Checks if the energy consumer has a generating unit
        /// </summary>
        /// <param name="ec"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool HasGeneratingUnit(this EnergyConsumer ec, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            var genUnit = context.GetEnergyConsumerGeneratingUnit(ec);

            if (genUnit != null)
                return true;
            else
                return false;
        }
    }
}
