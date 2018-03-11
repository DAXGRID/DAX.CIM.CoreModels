namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShuntCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonlinearShuntCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearShuntCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RotatingMachine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SynchronousMachine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AsynchronousMachine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExternalNetworkInjection))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class RegulatingCondEq : ConductingEquipment
    {
    }
}
