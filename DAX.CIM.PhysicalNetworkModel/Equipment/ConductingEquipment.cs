namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// The parts of the AC power system that are designed to carry current or that are conductively connected through terminals.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Switch))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProtectedSwitch))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoadBreakSwitch))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Breaker))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroundDisconnector))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Fuse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Disconnector))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeriesCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegulatingCondEq))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShuntCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonlinearShuntCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearShuntCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RotatingMachine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SynchronousMachine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AsynchronousMachine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExternalNetworkInjection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerTransformer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ground))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnergyConsumer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EarthFaultCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PetersenCoil))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroundingImpedance))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Connector))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusbarSection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Conductor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACLineSegment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACLineSegmentExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class ConductingEquipment : Equipment
    {
        private double baseVoltageField;

        /// <summary>
        /// Base voltage in volts
        /// </summary>
        public double BaseVoltage
        {
            get
            {
                return this.baseVoltageField;
            }
            set
            {
                this.baseVoltageField = value;
            }
        }
    }
}
