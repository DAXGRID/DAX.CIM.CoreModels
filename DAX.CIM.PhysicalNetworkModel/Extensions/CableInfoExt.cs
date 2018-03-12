using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public class CableInfoExt : CableInfo
    {
        private string conductorCountField;

        private decimal conductorCrossSectionalAreaField;

        private bool conductorCrossSectionalAreaFieldSpecified;

        private decimal shieldCrossSectionalAreaField;

        private bool shieldCrossSectionalAreaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string conductorCount
        {
            get
            {
                return this.conductorCountField;
            }
            set
            {
                this.conductorCountField = value;
            }
        }

        /// <remarks/>
        public decimal conductorCrossSectionalArea
        {
            get
            {
                return this.conductorCrossSectionalAreaField;
            }
            set
            {
                this.conductorCrossSectionalAreaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool conductorCrossSectionalAreaSpecified
        {
            get
            {
                return this.conductorCrossSectionalAreaFieldSpecified;
            }
            set
            {
                this.conductorCrossSectionalAreaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal shieldCrossSectionalArea
        {
            get
            {
                return this.shieldCrossSectionalAreaField;
            }
            set
            {
                this.shieldCrossSectionalAreaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shieldCrossSectionalAreaSpecified
        {
            get
            {
                return this.shieldCrossSectionalAreaFieldSpecified;
            }
            set
            {
                this.shieldCrossSectionalAreaFieldSpecified = value;
            }
        }
    }
}
