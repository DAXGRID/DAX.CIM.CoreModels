namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A linear shunt compensator has banks or sections with equal admittance values.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class LinearShuntCompensator : ShuntCompensator
    {

        private Susceptance b0PerSectionField;

        private Susceptance bPerSectionField;

        private Conductance g0PerSectionField;

        private Conductance gPerSectionField;

        /// <remarks/>
        public Susceptance b0PerSection
        {
            get
            {
                return this.b0PerSectionField;
            }
            set
            {
                this.b0PerSectionField = value;
            }
        }

        /// <remarks/>
        public Susceptance bPerSection
        {
            get
            {
                return this.bPerSectionField;
            }
            set
            {
                this.bPerSectionField = value;
            }
        }

        /// <remarks/>
        public Conductance g0PerSection
        {
            get
            {
                return this.g0PerSectionField;
            }
            set
            {
                this.g0PerSectionField = value;
            }
        }

        /// <remarks/>
        public Conductance gPerSection
        {
            get
            {
                return this.gPerSectionField;
            }
            set
            {
                this.gPerSectionField = value;
            }
        }
    }
}
