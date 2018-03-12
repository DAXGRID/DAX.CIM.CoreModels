namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class LifecycleDate
    {

        private System.DateTime manufacturedDateField;

        private bool manufacturedDateFieldSpecified;

        private System.DateTime purchaseDateField;

        private bool purchaseDateFieldSpecified;

        private System.DateTime receivedDateField;

        private bool receivedDateFieldSpecified;

        private System.DateTime installationDateField;

        private bool installationDateFieldSpecified;

        private System.DateTime removalDateField;

        private bool removalDateFieldSpecified;

        private System.DateTime retiredDateField;

        private bool retiredDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime manufacturedDate
        {
            get
            {
                return this.manufacturedDateField;
            }
            set
            {
                this.manufacturedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manufacturedDateSpecified
        {
            get
            {
                return this.manufacturedDateFieldSpecified;
            }
            set
            {
                this.manufacturedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime purchaseDate
        {
            get
            {
                return this.purchaseDateField;
            }
            set
            {
                this.purchaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseDateSpecified
        {
            get
            {
                return this.purchaseDateFieldSpecified;
            }
            set
            {
                this.purchaseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime receivedDate
        {
            get
            {
                return this.receivedDateField;
            }
            set
            {
                this.receivedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receivedDateSpecified
        {
            get
            {
                return this.receivedDateFieldSpecified;
            }
            set
            {
                this.receivedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime installationDate
        {
            get
            {
                return this.installationDateField;
            }
            set
            {
                this.installationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool installationDateSpecified
        {
            get
            {
                return this.installationDateFieldSpecified;
            }
            set
            {
                this.installationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime removalDate
        {
            get
            {
                return this.removalDateField;
            }
            set
            {
                this.removalDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool removalDateSpecified
        {
            get
            {
                return this.removalDateFieldSpecified;
            }
            set
            {
                this.removalDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime retiredDate
        {
            get
            {
                return this.retiredDateField;
            }
            set
            {
                this.retiredDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool retiredDateSpecified
        {
            get
            {
                return this.retiredDateFieldSpecified;
            }
            set
            {
                this.retiredDateFieldSpecified = value;
            }
        }
    }
}
