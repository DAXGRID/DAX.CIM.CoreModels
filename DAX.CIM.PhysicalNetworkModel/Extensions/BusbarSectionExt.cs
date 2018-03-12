namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// BusbarSection extension with short circuit attributes
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class BusbarSectionExt : BusbarSection
    {
        private ApparentPower sspMinField;
        private ApparentPower sspMaxField;
        private double powerFactorMinField;
        private bool powerFactorMinFieldSpecified;
        private double powerFactorMaxField;
        private bool powerFactorMaxFieldSpecified;

        /// <remarks/>
        public ApparentPower sspMin
        {
            get
            {
                return this.sspMinField;
            }
            set
            {
                this.sspMinField = value;
            }
        }

        /// <remarks/>
        public ApparentPower sspMax
        {
            get
            {
                return this.sspMaxField;
            }
            set
            {
                this.sspMaxField = value;
            }
        }

        /// <remarks/>
        public double powerFactorMin
        {
            get
            {
                return this.powerFactorMinField;
            }
            set
            {
                this.powerFactorMinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool powerFactorMinSpecified
        {
            get
            {
                return this.powerFactorMinFieldSpecified;
            }
            set
            {
                this.powerFactorMinFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double powerFactorMax
        {
            get
            {
                return this.powerFactorMaxField;
            }
            set
            {
                this.powerFactorMaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool powerFactorMaxSpecified
        {
            get
            {
                return this.powerFactorMaxFieldSpecified;
            }
            set
            {
                this.powerFactorMaxFieldSpecified = value;
            }
        }

    }
}
