namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class StreetAddress
    {

        private StreetDetail streetDetailField;

        private TownDetail townDetailField;

        private Status statusField;

        /// <remarks/>
        public StreetDetail streetDetail
        {
            get
            {
                return this.streetDetailField;
            }
            set
            {
                this.streetDetailField = value;
            }
        }

        /// <remarks/>
        public TownDetail townDetail
        {
            get
            {
                return this.townDetailField;
            }
            set
            {
                this.townDetailField = value;
            }
        }

        /// <remarks/>
        public Status status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }
}
