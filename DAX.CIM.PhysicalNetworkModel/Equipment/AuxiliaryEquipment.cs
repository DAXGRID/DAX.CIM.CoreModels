namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// AuxiliaryEquipment describe equipment that is not performing any primary functions but support for the equipment performing the primary function.
    /// AuxiliaryEquipment is attached to primary eqipment via an association with Terminal.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Sensor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformerExt))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultIndicator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultIndicatorExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class AuxiliaryEquipment : Equipment
    {

        private AuxiliaryEquipmentTerminal terminalField;

        /// <remarks/>
        public AuxiliaryEquipmentTerminal Terminal
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
