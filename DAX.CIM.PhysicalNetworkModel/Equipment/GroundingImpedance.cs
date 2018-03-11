namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class GroundingImpedance : EarthFaultCompensator
    {

        private Reactance xField;

        /// <remarks/>
        public Reactance x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
    }
}
