
namespace DAX.CIM.PhysicalNetworkModel
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://konstant.dk/eip")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://konstant.dk/eip", IsNullable = false)]
    public partial class EIP
    {

        private DistributionNodeAsset[] distributionNodeAssetField;

       // private DistributionNodeAssociation[] distributionNodeAssociationField;

        private IdentifiedObject[] identifiedObjectField;

        private PowerSystemResource[] powerSystemResourceField;

        private ServiceDeliveryPoint[] serviceDeliveryPointField;

        private UsagePoint[] usagePointField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DistributionNodeAsset")]
        public DistributionNodeAsset[] DistributionNodeAsset
        {
            get
            {
                return this.distributionNodeAssetField;
            }
            set
            {
                this.distributionNodeAssetField = value;
            }
        }

        /*
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DistributionNodeAssociation")]
        public DistributionNodeAssociation[] DistributionNodeAssociation
        {
            get
            {
                return this.distributionNodeAssociationField;
            }
            set
            {
                this.distributionNodeAssociationField = value;
            }
        }
        */

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentifiedObject")]
        public IdentifiedObject[] IdentifiedObject
        {
            get
            {
                return this.identifiedObjectField;
            }
            set
            {
                this.identifiedObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PowerSystemResource")]
        public PowerSystemResource[] PowerSystemResource
        {
            get
            {
                return this.powerSystemResourceField;
            }
            set
            {
                this.powerSystemResourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceDeliveryPoint")]
        public ServiceDeliveryPoint[] ServiceDeliveryPoint
        {
            get
            {
                return this.serviceDeliveryPointField;
            }
            set
            {
                this.serviceDeliveryPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsagePoint")]
        public UsagePoint[] UsagePoint
        {
            get
            {
                return this.usagePointField;
            }
            set
            {
                this.usagePointField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://konstant.dk/eip")]
    public partial class DistributionNodeAsset : PowerSystemResource
    {

        private Voltage baseVoltageField;

        private string eipNameField;

        private string eipSubtypeField;

        private string manufacturerField;

        private string productAssetModelField;

        private CurrentFlow ratedCurrentField;

        private ApparentPower ratedPowerField;

        private Voltage ratedVoltageField;

        private double wgs84LatitudeField;

        private bool wgs84LatitudeFieldSpecified;

        private double wgs84LongitudeField;

        private bool wgs84LongitudeFieldSpecified;

        private DistributionNodeParent parentField;

        private string parentEipNameField;

        public DistributionNodeParent parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        public string parentEipName
        {
            get
            {
                return this.parentEipNameField;
            }
            set
            {
                this.parentEipNameField = value;
            }
        }

        /// <remarks/>
        public Voltage baseVoltage
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
        public string eipName
        {
            get
            {
                return this.eipNameField;
            }
            set
            {
                this.eipNameField = value;
            }
        }

        /// <remarks/>
        public string eipSubtype
        {
            get
            {
                return this.eipSubtypeField;
            }
            set
            {
                this.eipSubtypeField = value;
            }
        }

        /// <remarks/>
        public string manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        public string productAssetModel
        {
            get
            {
                return this.productAssetModelField;
            }
            set
            {
                this.productAssetModelField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow ratedCurrent
        {
            get
            {
                return this.ratedCurrentField;
            }
            set
            {
                this.ratedCurrentField = value;
            }
        }

        /// <remarks/>
        public ApparentPower ratedPower
        {
            get
            {
                return this.ratedPowerField;
            }
            set
            {
                this.ratedPowerField = value;
            }
        }

        /// <remarks/>
        public Voltage ratedVoltage
        {
            get
            {
                return this.ratedVoltageField;
            }
            set
            {
                this.ratedVoltageField = value;
            }
        }

        /// <remarks/>
        public double wgs84Latitude
        {
            get
            {
                return this.wgs84LatitudeField;
            }
            set
            {
                this.wgs84LatitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wgs84LatitudeSpecified
        {
            get
            {
                return this.wgs84LatitudeFieldSpecified;
            }
            set
            {
                this.wgs84LatitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double wgs84Longitude
        {
            get
            {
                return this.wgs84LongitudeField;
            }
            set
            {
                this.wgs84LongitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wgs84LongitudeSpecified
        {
            get
            {
                return this.wgs84LongitudeFieldSpecified;
            }
            set
            {
                this.wgs84LongitudeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://konstant.dk/eip")]
    public partial class DistributionNodeParent
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://konstant.dk/eip")]
    public partial class ServiceDeliveryPoint : UsagePoint
    {
        private string eipNameField;

        private double wgs84LatitudeField;

        private bool wgs84LatitudeFieldSpecified;

        private double wgs84LongitudeField;

        private bool wgs84LongitudeFieldSpecified;

        private ServiceDeliveryPointDistributionNode distributionNodeField;

        /// <remarks/>
        public string eipName
        {
            get
            {
                return this.eipNameField;
            }
            set
            {
                this.eipNameField = value;
            }
        }

        /// <remarks/>
        public double wgs84Latitude
        {
            get
            {
                return this.wgs84LatitudeField;
            }
            set
            {
                this.wgs84LatitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wgs84LatitudeSpecified
        {
            get
            {
                return this.wgs84LatitudeFieldSpecified;
            }
            set
            {
                this.wgs84LatitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double wgs84Longitude
        {
            get
            {
                return this.wgs84LongitudeField;
            }
            set
            {
                this.wgs84LongitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wgs84LongitudeSpecified
        {
            get
            {
                return this.wgs84LongitudeFieldSpecified;
            }
            set
            {
                this.wgs84LongitudeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ServiceDeliveryPointDistributionNode distributionNode
        {
            get
            {
                return this.distributionNodeField;
            }
            set
            {
                this.distributionNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://konstant.dk/eip")]
    public partial class ServiceDeliveryPointDistributionNode
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

    /*
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionNodeAsset))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://konstant.dk/eip")]
    public partial class PowerSystemResource : IdentifiedObject {
    }
    */

    /*
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://konstant.dk/eip")]
    public partial class DistributionNodeAssociation : IdentifiedObject
    {

        private DistributionNodeAssociationChild childField;

        private string childEipNameField;

        private DistributionNodeAssociationParent parentField;

        private string parentEipNameField;



        /// <remarks/>
        public DistributionNodeAssociationChild child
        {
            get
            {
                return this.childField;
            }
            set
            {
                this.childField = value;
            }
        }

        public string childEipName
        {
            get
            {
                return this.childEipNameField;
            }
            set
            {
                this.childEipNameField = value;
            }
        }

        /// <remarks/>
        public DistributionNodeAssociationParent parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        public string parentEipName
        {
            get
            {
                return this.parentEipNameField;
            }
            set
            {
                this.parentEipNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://konstant.dk/eip")]
    public partial class DistributionNodeAssociationChild
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://konstant.dk/eip")]
    public partial class DistributionNodeAssociationParent
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
    */

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://konstant.dk/eip")]
    public enum DistributionNodeKind
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HV-ConnectivityNode")]
        HVConnectivityNode,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HV-InjectionPoint")]
        HVInjectionPoint,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HV-Measurement")]
        HVMeasurement,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HV-PowerTransformer")]
        HVPowerTransformer,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LV-Cabinet")]
        LVCabinet,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LV-CabinetFeeder")]
        LVCabinetFeeder,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LV-ConnectivityNode")]
        LVConnectivityNode,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LV-Feeder")]
        LVFeeder,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LV-Measurement")]
        LVMeasurement,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MV-ConnectivityNode")]
        MVConnectivityNode,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MV-Feeder")]
        MVFeeder,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MV-InjectionPoint")]
        MVInjectionPoint,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MV-Measurement")]
        MVMeasurement,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MV-PowerTransformer")]
        MVPowerTransformer,
    }
}
