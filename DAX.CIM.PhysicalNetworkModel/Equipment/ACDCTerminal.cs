namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// An electrical connection point (AC or DC) to a piece of conducting equipment. Terminals are connected at physical connection points called connectivity nodes.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Terminal))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class ACDCTerminal : IdentifiedObject
    {
        private string sequenceNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string sequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }
    }
}
