using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.LineInfo
{
    public class EndInfo
    {
        public IdentifiedObject StartObj { get; set; }
        public Substation Substation { get; set; }
        public Bay Bay { get; set; }
    }
}
