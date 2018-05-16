using DAX.CIM.PhysicalNetworkModel.Changes;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;

namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// This is a root class to provide common identification for all classes needing identification and naming attributes.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransformerEnd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerTransformerEnd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerTransformerEndExt))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubGeographicalRegion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerSystemResource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TapChanger))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RatioTapChanger))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Equipment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryEquipment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Sensor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformerExt))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultIndicator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultIndicatorExt))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConductingEquipment))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConnectivityNodeContainer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EquipmentContainer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VoltageLevel))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Substation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bay))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BayExt))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeographicalRegion))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConnectivityNode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACDCTerminal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Terminal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UsagePoint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateSystem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Asset))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataSetMember))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class IdentifiedObject
    {

        private string mRIDField;

        private string descriptionField;

        private string nameField;

        private IdentifiedObjectNames[] namesField;

        /// <remarks/>
        public string mRID
        {
            get
            {
                return this.mRIDField;
            }
            set
            {
                this.mRIDField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Names")]
        public IdentifiedObjectNames[] Names
        {
            get
            {
                return this.namesField;
            }
            set
            {
                this.namesField = value;
            }
        }


        public Substation Substation
        {
            get
            {
                var context = CimContext.GetCurrent();

                if (this is Substation)
                {
                    return (Substation)this;
                }

                if (this is VoltageLevel)
                {
                    var voltageLevel = (VoltageLevel)this;

                    return voltageLevel.EquipmentContainer1.Get(context).GetSubstation(false, context);
                }

                if (this is BayExt)
                {
                    var bayExt = (BayExt)this;

                    return bayExt.VoltageLevel.Get(context).GetSubstation(false, context);
                }

                if (this is ConductingEquipment)
                {
                    var ce = (ConductingEquipment)this;

                    return ce.GetSubstation(false, context);
                }

                return null;
            }
        }

    }
}
