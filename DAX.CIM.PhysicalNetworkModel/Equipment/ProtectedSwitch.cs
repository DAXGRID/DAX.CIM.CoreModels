namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A ProtectedSwitch is a switching device that can be operated by ProtectionEquipment.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoadBreakSwitch))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Breaker))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class ProtectedSwitch : Switch
    {
    }
}
