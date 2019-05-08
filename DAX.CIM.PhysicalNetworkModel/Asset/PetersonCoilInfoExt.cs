using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class PetersenCoilInfoExt : AssetInfo
    {

        private CurrentFlow actualCurrentField;

        private CoolingKind coolingField;

        private bool coolingFieldSpecified;

        private CurrentFlow maximumCurrentField;

        private CurrentFlow minimumCurrentField;

        private PetersenCoilModeKind modeField;

        private bool modeFieldSpecified;

        private PetersenCoilOperationalLimitKind operationLimitField;

        private bool operationLimitFieldSpecified;

        private Voltage ratedImpluseWithstandVoltageField;

        private Voltage ratedIsolationVoltageField;

        private Voltage ratedVoltageField;

        /// <remarks/>
        public CurrentFlow actualCurrent
        {
            get
            {
                return this.actualCurrentField;
            }
            set
            {
                this.actualCurrentField = value;
            }
        }

        /// <remarks/>
        public CoolingKind cooling
        {
            get
            {
                return this.coolingField;
            }
            set
            {
                this.coolingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool coolingSpecified
        {
            get
            {
                return this.coolingFieldSpecified;
            }
            set
            {
                this.coolingFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CurrentFlow maximumCurrent
        {
            get
            {
                return this.maximumCurrentField;
            }
            set
            {
                this.maximumCurrentField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow minimumCurrent
        {
            get
            {
                return this.minimumCurrentField;
            }
            set
            {
                this.minimumCurrentField = value;
            }
        }

        /// <remarks/>
        public PetersenCoilModeKind mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modeSpecified
        {
            get
            {
                return this.modeFieldSpecified;
            }
            set
            {
                this.modeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PetersenCoilOperationalLimitKind operationLimit
        {
            get
            {
                return this.operationLimitField;
            }
            set
            {
                this.operationLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operationLimitSpecified
        {
            get
            {
                return this.operationLimitFieldSpecified;
            }
            set
            {
                this.operationLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Voltage ratedImpluseWithstandVoltage
        {
            get
            {
                return this.ratedImpluseWithstandVoltageField;
            }
            set
            {
                this.ratedImpluseWithstandVoltageField = value;
            }
        }

        /// <remarks/>
        public Voltage ratedIsolationVoltage
        {
            get
            {
                return this.ratedIsolationVoltageField;
            }
            set
            {
                this.ratedIsolationVoltageField = value;
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
