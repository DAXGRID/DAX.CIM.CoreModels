namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class CoordinateSystem : IdentifiedObject
    {

        private string crsUrnField;

        /// <remarks/>
        public string crsUrn
        {
            get
            {
                return this.crsUrnField;
            }
            set
            {
                this.crsUrnField = value;
            }
        }
    }
}
