namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A conductor, or group of conductors, with negligible impedance, that serve to connect other conducting equipment within a single substation. 
    /// Voltage measurements are typically obtained from VoltageTransformers that are connected to busbar sections.A bus bar section may have many physical terminals but for analysis is modelled with exactly one logical terminal.</xs:documentation>
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class BusbarSection : Connector
    {

        private CurrentFlow ipMaxField;

        /// <remarks/>
        public CurrentFlow ipMax
        {
            get
            {
                return this.ipMaxField;
            }
            set
            {
                this.ipMaxField = value;
            }
        }
    }
}
