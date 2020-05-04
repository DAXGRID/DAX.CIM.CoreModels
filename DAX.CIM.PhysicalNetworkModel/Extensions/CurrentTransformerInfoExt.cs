using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class CurrentTransformerInfoExt : AssetInfo
    {

        private CurrentFlow primaryCurrentField;

        private CurrentFlow secondaryCurrentField;

        /// <remarks/>
        public CurrentFlow primaryCurrent
        {
            get
            {
                return this.primaryCurrentField;
            }
            set
            {
                this.primaryCurrentField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow secondaryCurrent
        {
            get
            {
                return this.secondaryCurrentField;
            }
            set
            {
                this.secondaryCurrentField = value;
            }
        }
    }
}
