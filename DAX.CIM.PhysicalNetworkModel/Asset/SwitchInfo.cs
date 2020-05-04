using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class SwitchInfo : AssetInfo
    {

        private CurrentFlow breakingCapacityField;

        private CurrentFlow ratedCurrentField;

        private Voltage ratedVoltageField;

        /// <remarks/>
        public CurrentFlow breakingCapacity
        {
            get
            {
                return this.breakingCapacityField;
            }
            set
            {
                this.breakingCapacityField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow ratedCurrent
        {
            get
            {
                return this.ratedCurrentField;
            }
            set
            {
                this.ratedCurrentField = value;
            }
        }

        /// <remarks/>
        public Voltage ratedVoltage
        {
            get
            {
                return this.ratedVoltageField;
            }
            set
            {
                this.ratedVoltageField = value;
            }
        }
    }

}
