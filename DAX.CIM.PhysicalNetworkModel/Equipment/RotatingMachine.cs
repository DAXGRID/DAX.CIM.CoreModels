namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A rotating machine which may be used as a generator or motor.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SynchronousMachine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AsynchronousMachine))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class RotatingMachine : RegulatingCondEq
    {

        private double ratedPowerFactorField;

        private bool ratedPowerFactorFieldSpecified;

        private ApparentPower ratedSField;

        private Voltage ratedUField;

        /// <remarks/>
        public double ratedPowerFactor
        {
            get
            {
                return this.ratedPowerFactorField;
            }
            set
            {
                this.ratedPowerFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ratedPowerFactorSpecified
        {
            get
            {
                return this.ratedPowerFactorFieldSpecified;
            }
            set
            {
                this.ratedPowerFactorFieldSpecified = value;
            }
        }

        /// <summary>
        /// Nameplate apparent power rating for the unit. The attribute shall have a positive value.
        /// </summary>
        public ApparentPower ratedS
        {
            get
            {
                return this.ratedSField;
            }
            set
            {
                this.ratedSField = value;
            }
        }

        /// <remarks/>
        public Voltage ratedU
        {
            get
            {
                return this.ratedUField;
            }
            set
            {
                this.ratedUField = value;
            }
        }
    }
}
