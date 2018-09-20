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
        public ConductingEquipment ConductingEquipment { get; set; }

        /// <summary>
        /// Helper function that generates a unique feeder name containing station name and bay name.
        /// </summary>
        /// <returns></returns>
        public string FullName
        {
            get
            {
                string feederName = ConnectionPoint.Substation.name;

                // Add bay name if avaible
                if (ConnectionPoint.Bay != null && ConnectionPoint.Bay.name != null)
                {
                    feederName += " " + ConnectionPoint.Bay.name;
                }
                // No bay name, so let's try power transformer name, because cable is probably connected directly to power transformer
                else if (ConnectionPoint.PowerTransformer != null && ConnectionPoint.PowerTransformer.name != null)
                {
                    feederName += " " + ConnectionPoint.PowerTransformer.name;
                }

                // If multiple cables are connected to same bay. Make sure name is still unique.
                if (ConnectionPoint.Feeders.Count > 1)
                {
                    var feederIndex = 1;
                    foreach (var feeder in ConnectionPoint.Feeders)
                    {
                        if (feeder == this)
                            break;

                        feederIndex++;
                    }

                    feederName += " " + feederIndex;
                }

                return feederName;
            }
        }
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
