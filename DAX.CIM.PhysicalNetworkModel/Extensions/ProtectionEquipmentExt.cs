namespace DAX.CIM.PhysicalNetworkModel
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ProtectionEquipmentExt : ProtectionEquipment
    {

        private ProtectionEquipmentExtCurrentTransformers[] currentTransformersField;

        private ProtectionEquipmentExtPotentialTransformers[] potentialTransformersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrentTransformers")]
        public ProtectionEquipmentExtCurrentTransformers[] CurrentTransformers
        {
            get
            {
                return this.currentTransformersField;
            }
            set
            {
                this.currentTransformersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PotentialTransformers")]
        public ProtectionEquipmentExtPotentialTransformers[] PotentialTransformers
        {
            get
            {
                return this.potentialTransformersField;
            }
            set
            {
                this.potentialTransformersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ProtectionEquipmentExtCurrentTransformers
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ProtectionEquipmentExtPotentialTransformers
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
