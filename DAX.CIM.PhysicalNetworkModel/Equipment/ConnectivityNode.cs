namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Connectivity nodes are points where terminals of AC conducting equipment are connected together with zero impedance.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ConnectivityNode : IdentifiedObject
    {
        public override string ToString()
        {
            return this.GetType().Name + " mRID=" + mRID;
        }
    }
}
