using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class SwitchInfoExt : SwitchInfo
    {

        private CurrentFlow ratedBreakingCurrentField;

        private CurrentFlow ratedMakingCurrentField;

        private CurrentFlow ratedWithstandCurrent1secField;

        private CurrentFlow ratedWithstandCurrent3sekField;

        private string relayFunctionField;

        /// <remarks/>
        public CurrentFlow ratedBreakingCurrent
        {
            get
            {
                return this.ratedBreakingCurrentField;
            }
            set
            {
                this.ratedBreakingCurrentField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow ratedMakingCurrent
        {
            get
            {
                return this.ratedMakingCurrentField;
            }
            set
            {
                this.ratedMakingCurrentField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow ratedWithstandCurrent1sec
        {
            get
            {
                return this.ratedWithstandCurrent1secField;
            }
            set
            {
                this.ratedWithstandCurrent1secField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow ratedWithstandCurrent3sek
        {
            get
            {
                return this.ratedWithstandCurrent3sekField;
            }
            set
            {
                this.ratedWithstandCurrent3sekField = value;
            }
        }

        /// <remarks/>
        public string relayFunction
        {
            get
            {
                return this.relayFunctionField;
            }
            set
            {
                this.relayFunctionField = value;
            }
        }
    }
}
