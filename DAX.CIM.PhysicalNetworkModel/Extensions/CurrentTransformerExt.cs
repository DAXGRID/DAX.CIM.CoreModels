namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Instrument transformer used to measure electrical qualities of the circuit that is being protected and/or monitored. Typically used as current transducer for the purpose of metering or protection. A typical secondary current rating would be 5A.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class CurrentTransformerExt : CurrentTransformer
    {

        private CurrentFlow maximumCurrentField;

        /// <remarks/>
        public CurrentFlow maximumCurrent
        {
            get
            {
                return this.maximumCurrentField;
            }
            set
            {
                this.maximumCurrentField = value;
            }
        }
    }
}
