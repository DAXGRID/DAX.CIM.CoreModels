namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A mechanical switching device capable of making, carrying, and breaking currents under normal circuit conditions and also making, carrying for a specified time, and breaking currents under specified abnormal circuit conditions e.g.  those of short circuit.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Breaker : ProtectedSwitch
    {

        private CurrentFlow breakingCapacityField;

        /// <remarks/>
        public CurrentFlow breakingCapacity
        {
            get
            {
                return this.breakingCapacityField;
            }
            set
            {
                this.breakingCapacityField = value;
            }
        }
    }
}
