using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.Traversal.Extensions
{
    public static class PowerTransformerEndEx
    {
        public static List<TapChanger> GetTapChangers(this PowerTransformerEnd end, CimContext context = null)
        {
            context = context ?? CimContext.GetCurrent();

            return context.GetPowerTransformerEndTapChangers(end);
        }
    }
}
