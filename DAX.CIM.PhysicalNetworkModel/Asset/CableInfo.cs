using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class CableInfo : WireInfo
    {

        private WireMaterialKind materialField;

        private bool materialFieldSpecified;

        private CableOuterJacketKind outerJacketKindField;

        private bool outerJacketKindFieldSpecified;

        private CurrentFlow ratedCurrentField;

        private CableShieldMaterialKind shieldMaterialField;

        private bool shieldMaterialFieldSpecified;

        /// <remarks/>
        public WireMaterialKind material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool materialSpecified
        {
            get
            {
                return this.materialFieldSpecified;
            }
            set
            {
                this.materialFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CableOuterJacketKind outerJacketKind
        {
            get
            {
                return this.outerJacketKindField;
            }
            set
            {
                this.outerJacketKindField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool outerJacketKindSpecified
        {
            get
            {
                return this.outerJacketKindFieldSpecified;
            }
            set
            {
                this.outerJacketKindFieldSpecified = value;
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
        public CableShieldMaterialKind shieldMaterial
        {
            get
            {
                return this.shieldMaterialField;
            }
            set
            {
                this.shieldMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shieldMaterialSpecified
        {
            get
            {
                return this.shieldMaterialFieldSpecified;
            }
            set
            {
                this.shieldMaterialFieldSpecified = value;
            }
        }
    }

}
