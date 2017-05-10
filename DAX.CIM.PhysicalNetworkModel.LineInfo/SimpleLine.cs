using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.LineInfo
{
    public class SimpleLine
    {
        public string Name { get; set; }

        public Substation FromSubstation { get; set; }
        public Substation ToSubstation { get; set; }

        public Bay FromBay { get; set; }
        public Bay ToBay { get; set; }
        public List<LineRelation> Children = new List<LineRelation>();

        public override string ToString()
        {
            return Name + " " + Children.Count + " children";
        }
    }
}
