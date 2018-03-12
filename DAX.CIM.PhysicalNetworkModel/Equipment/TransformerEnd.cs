namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A conducting connection point of a power transformer. It corresponds to a physical transformer winding terminal.  In earlier CIM versions, the TransformerWinding class served a similar purpose, but this class is more flexible because it associates to terminal but is not a specialization of ConductingEquipment.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerTransformerEnd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerTransformerEndExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class TransformerEnd : IdentifiedObject
    {

        private string endNumberField;

        private bool groundedField;

        private Resistance rgroundField;

        private Reactance xgroundField;

        private double baseVoltageField;

        private TransformerEndTerminal terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string endNumber
        {
            get
            {
                return this.endNumberField;
            }
            set
            {
                this.endNumberField = value;
            }
        }

        /// <remarks/>
        public bool grounded
        {
            get
            {
                return this.groundedField;
            }
            set
            {
                this.groundedField = value;
            }
        }

        /// <remarks/>
        public Resistance rground
        {
            get
            {
                return this.rgroundField;
            }
            set
            {
                this.rgroundField = value;
            }
        }

        /// <remarks/>
        public Reactance xground
        {
            get
            {
                return this.xgroundField;
            }
            set
            {
                this.xgroundField = value;
            }
        }

        /// <summary>
        /// Base voltage in volts
        /// </summary>
        public double BaseVoltage
        {
            get
            {
                return this.baseVoltageField;
            }
            set
            {
                this.baseVoltageField = value;
            }
        }

        /// <remarks/>
        public TransformerEndTerminal Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }
}
