namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class StreetDetail
    {

        private string numberField;

        private string nameField;

        private string suffixField;

        private string prefixField;

        private string typeField;

        private string codeField;

        private string buildingNameField;

        private string suiteNumberField;

        private string addressGeneralField;

        private bool withinTownLimitsField;

        private bool withinTownLimitsFieldSpecified;

        /// <remarks/>
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string suffix
        {
            get
            {
                return this.suffixField;
            }
            set
            {
                this.suffixField = value;
            }
        }

        /// <remarks/>
        public string prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
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
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string buildingName
        {
            get
            {
                return this.buildingNameField;
            }
            set
            {
                this.buildingNameField = value;
            }
        }

        /// <remarks/>
        public string suiteNumber
        {
            get
            {
                return this.suiteNumberField;
            }
            set
            {
                this.suiteNumberField = value;
            }
        }

        /// <remarks/>
        public string addressGeneral
        {
            get
            {
                return this.addressGeneralField;
            }
            set
            {
                this.addressGeneralField = value;
            }
        }

        /// <remarks/>
        public bool withinTownLimits
        {
            get
            {
                return this.withinTownLimitsField;
            }
            set
            {
                this.withinTownLimitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool withinTownLimitsSpecified
        {
            get
            {
                return this.withinTownLimitsFieldSpecified;
            }
            set
            {
                this.withinTownLimitsFieldSpecified = value;
            }
        }
    }
}
