namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Tangible resource of the utility, including power system equipment, various end devices, cabinets, buildings, etc. For electrical network equipment, the role of the asset is defined through PowerSystemResource and its subclasses, defined mainly in the Wires model (refer to IEC61970-301 and model package IEC61970::Wires). Asset description places emphasis on the physical characteristics of the equipment fulfilling that role.
    /// TODO: Move out of this model. Asset is another bounded context than the physical network model.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Asset : IdentifiedObject
    {

        private string lotNumberField;

        private string serialNumberField;

        private string typeField;

        private LifecycleDate lifecycleField;

        //private AssetOrganisationRoles[] organisationRolesField;

        private string ownerField;

        private string maintainerField;

        private AssetAssetInfo assetInfoField;

        public string owner
        {
            get { return this.ownerField; }
            set { ownerField = value; }
        }

        public string maintainer
        {
            get { return maintainerField; }
            set { maintainerField = value; }
        }

        /// <remarks/>
        public string lotNumber
        {
            get
            {
                return this.lotNumberField;
            }
            set
            {
                this.lotNumberField = value;
            }
        }

        /// <remarks/>
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public LifecycleDate lifecycle
        {
            get
            {
                return this.lifecycleField;
            }
            set
            {
                this.lifecycleField = value;
            }
        }

        /// <remarks/>
        public AssetAssetInfo AssetInfo
        {
            get
            {
                return this.assetInfoField;
            }
            set
            {
                this.assetInfoField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("OrganisationRoles")]
        //public AssetOrganisationRoles[] OrganisationRoles
        //{
        //    get
        //    {
        //        return this.organisationRolesField;
        //    }
        //    set
        //    {
        //        this.organisationRolesField = value;
        //    }
        //}
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class AssetAssetInfo
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
