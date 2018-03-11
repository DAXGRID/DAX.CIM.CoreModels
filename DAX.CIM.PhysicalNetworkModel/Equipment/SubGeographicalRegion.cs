namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class SubGeographicalRegion : IdentifiedObject
    {

        private SubGeographicalRegionSubstations[] substationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Substations")]
        public SubGeographicalRegionSubstations[] Substations
        {
            get
            {
                return this.substationsField;
            }
            set
            {
                this.substationsField = value;
            }
        }
    }
}
