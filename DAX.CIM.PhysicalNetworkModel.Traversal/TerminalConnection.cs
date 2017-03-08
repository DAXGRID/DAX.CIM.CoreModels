using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.Traversal
{
    public struct TerminalConnection
    {
        public ConductingEquipment ConductingEquipment { get; set; }
        public Terminal Terminal { get; set; }
        public ConnectivityNode ConnectivityNode { get; set; }
    }
}
