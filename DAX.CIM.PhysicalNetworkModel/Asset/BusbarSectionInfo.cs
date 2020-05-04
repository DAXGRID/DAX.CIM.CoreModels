using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class BusbarSectionInfo : AssetInfo
    {

        private CurrentFlow ratedCurrentField;

        private Voltage ratedVoltageField;

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
