using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class PotentialTransformerInfoExt : AssetInfo
    {

        private Voltage primaryVoltageField;

        private Voltage secondaryVoltageField;

        /// <remarks/>
        public Voltage primaryVoltage
        {
            get
            {
                return this.primaryVoltageField;
            }
            set
            {
                this.primaryVoltageField = value;
            }
        }

        /// <remarks/>
        public Voltage secondaryVoltage
        {
            get
            {
                return this.secondaryVoltageField;
            }
            set
            {
                this.secondaryVoltageField = value;
            }
        }
    }
}
