using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class WireInfo : AssetInfo
    {

        private WireInsulationKind insulationMaterialField;

        private bool insulationMaterialFieldSpecified;

        private WireMaterialKind materialField;

        private bool materialFieldSpecified;

        private CurrentFlow ratedCurrentField;

        

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public WireInsulationKind insulationMaterial
        {
            get
            {
                return this.insulationMaterialField;
            }
            set
            {
                this.insulationMaterialField = value;
            }
        }
        

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool insulationMaterialSpecified
        {
            get
            {
                return this.insulationMaterialFieldSpecified;
            }
            set
            {
                this.insulationMaterialFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
    }
}
