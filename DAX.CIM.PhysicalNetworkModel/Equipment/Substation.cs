namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A collection of equipment for purposes other than generation or utilization, through which electric energy in bulk is passed for the purposes of switching or modifying its characteristics.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Substation : EquipmentContainer
    {

        private SubstationRegion regionField;

        /// <remarks/>
        public SubstationRegion Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }
    }
}
