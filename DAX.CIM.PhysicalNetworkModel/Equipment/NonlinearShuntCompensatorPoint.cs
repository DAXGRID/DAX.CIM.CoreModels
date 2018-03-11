namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class NonlinearShuntCompensatorPoint
    {

        private Susceptance bField;

        private Susceptance b0Field;

        private Conductance gField;

        private Conductance g0Field;

        private string sectionNumberField;

        private NonlinearShuntCompensatorPointNonlinearShuntCompensator nonlinearShuntCompensatorField;

        /// <remarks/>
        public Susceptance b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        /// <remarks/>
        public Susceptance b0
        {
            get
            {
                return this.b0Field;
            }
            set
            {
                this.b0Field = value;
            }
        }

        /// <remarks/>
        public Conductance g
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        public Conductance g0
        {
            get
            {
                return this.g0Field;
            }
            set
            {
                this.g0Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string sectionNumber
        {
            get
            {
                return this.sectionNumberField;
            }
            set
            {
                this.sectionNumberField = value;
            }
        }

        /// <remarks/>
        public NonlinearShuntCompensatorPointNonlinearShuntCompensator NonlinearShuntCompensator
        {
            get
            {
                return this.nonlinearShuntCompensatorField;
            }
            set
            {
                this.nonlinearShuntCompensatorField = value;
            }
        }
    }
}
