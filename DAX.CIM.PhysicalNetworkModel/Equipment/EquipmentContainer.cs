namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A modeling construct to provide a root class for containing equipment.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VoltageLevel))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Substation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bay))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BayExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class EquipmentContainer : ConnectivityNodeContainer
    {
    }
}
