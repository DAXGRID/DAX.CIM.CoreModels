namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A conductor, or group of conductors, with negligible impedance, that serve to connect other conducting equipment within a single substation and are modelled with a single logical terminal.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusbarSection))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class Connector : ConductingEquipment
    {
    }
}
