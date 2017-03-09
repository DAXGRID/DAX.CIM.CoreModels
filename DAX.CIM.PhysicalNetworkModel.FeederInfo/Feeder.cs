using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.FeederInfo
{
    public class Feeder
    {
        public FeederType FeederType { get; set; }
        public FeederVoltageLevel VoltageLevel { get; set; }
        public ConnectionPoint ConnectionPoint { get; set; }
        public ACLineSegment ACLineSegment { get; set; }
    }

    public enum FeederType
    {
        NetworkInjection,
        PrimarySubstation,
        SecondarySubstation,
        CableBox
    }

    public enum FeederVoltageLevel
    {
        LowVoltage,
        MediumVoltage,
        HighVoltage
    }
}
