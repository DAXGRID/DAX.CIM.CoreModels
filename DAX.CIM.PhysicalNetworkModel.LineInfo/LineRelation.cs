using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.LineInfo
{
    /// <summary>
    /// A class used to hold information about the relation between a CIM object and a Line
    /// </summary>
    public class LineRelation
    {
        public Equipment Equipment { get; set; }
        public SimpleLine Line { get; set; }

        /// <summary>
        /// In the DSO realm elements are typical numbered starting with the substation with the lowest number - e.g. 100-200#1, 100-200#2 and so forth.
        /// </summary>
        public int Order { get; set; }
        public bool IsFirst { get; set; }
        public bool IsLast { get; set; }

        public override string ToString()
        {
            if (Line != null)
                return Line.Name + "#" + Order;
            else
                return base.ToString();
        }
    }
}
