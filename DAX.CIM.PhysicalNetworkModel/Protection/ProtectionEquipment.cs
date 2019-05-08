namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ProtectionEquipment : Equipment
    {

        private ProtectionEquipmentProtectedSwitches[] protectedSwitchesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProtectedSwitches")]
        public ProtectionEquipmentProtectedSwitches[] ProtectedSwitches
        {
            get
            {
                return this.protectedSwitchesField;
            }
            set
            {
                this.protectedSwitchesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ProtectionEquipmentProtectedSwitches
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }
}
