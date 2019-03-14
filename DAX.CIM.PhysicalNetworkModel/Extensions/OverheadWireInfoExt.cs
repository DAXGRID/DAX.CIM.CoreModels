using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class OverheadWireInfoExt : WireInfoExt
    {
        private int conductorCountField;

        private decimal conductorCrossSectionalAreaField;

        private bool conductorCrossSectionalAreaFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public int conductorCount
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
    }

}
