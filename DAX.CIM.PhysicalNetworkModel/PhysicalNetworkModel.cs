namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Envelope that can be used for XML serialization and deserialisation
    /// However, DON'T USE IT! Because it's gonna die in the fucture.
    /// Serialize/deserialize collection/enumerable of identified objects instead.
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1", IsNullable = false)]
    public partial class PhysicalNetworkModelEnvelope
    {
        private ConnectivityNodeContainer[] connectivityNodeContainerField;

        private Asset[] assetField;

        //private AssetOwner[] assetOwnerField;

        //private Maintainer[] maintainerField;

        private CoordinateSystem[] coordinateSystemField;

        private Location[] locationField;

        private UsagePoint[] usagePointField;

        private Bay[] bayField;

        private ConnectivityNode[] connectivityNodeField;

        private GeographicalRegion[] geographicalRegionField;

        private Name[] nameField;

        private NameType[] nameTypeField;

        private SubGeographicalRegion[] subGeographicalRegionField;

        private Substation[] substationField;

        private Terminal[] terminalField;

        private VoltageLevel[] voltageLevelField;

        private ACLineSegment[] aCLineSegmentField;

        private ACLineSegmentExt[] aCLineSegmentExtField;

        private AsynchronousMachine[] asynchronousMachineField;

        private BayExt[] bayExtField;

        private Breaker[] breakerField;

        private BusbarSection[] busbarSectionField;

        private CurrentTransformer[] currentTransformerField;

        private CurrentTransformerExt[] currentTransformerExtField;

        private Disconnector[] disconnectorField;

        private EnergyConsumer[] energyConsumerField;

        private ExternalNetworkInjection[] externalNetworkInjectionField;

        private FaultIndicator[] faultIndicatorField;

        private FaultIndicatorExt[] faultIndicatorExtField;

        private Fuse[] fuseField;

        private Ground[] groundField;

        private GroundDisconnector[] groundDisconnectorField;

        private GroundingImpedance[] groundingImpedanceField;

        private LinearShuntCompensator[] linearShuntCompensatorField;

        private LoadBreakSwitch[] loadBreakSwitchField;

        private NonlinearShuntCompensator[] nonlinearShuntCompensatorField;

        private NonlinearShuntCompensatorPoint[] nonlinearShuntCompensatorPointField;

        private PetersenCoil[] petersenCoilField;

        private PowerTransformer[] powerTransformerField;

        private PowerTransformerEnd[] powerTransformerEndField;

        private PowerTransformerEndExt[] powerTransformerEndExtField;

        private RatioTapChanger[] ratioTapChangerField;

        private ReactiveCapabilityCurve[] reactiveCapabilityCurveField;

        private Sensor[] sensorField;

        private SeriesCompensator[] seriesCompensatorField;

        private Switch[] switchField;

        private SynchronousMachine[] synchronousMachineField;

        private TapSchedule[] tapScheduleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectivityNodeContainer")]
        public ConnectivityNodeContainer[] ConnectivityNodeContainer
        {
            get
            {
                return this.connectivityNodeContainerField;
            }
            set
            {
                this.connectivityNodeContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Asset")]
        public Asset[] Asset
        {
            get
            {
                return this.assetField;
            }
            set
            {
                this.assetField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("AssetOwner")]
        //public AssetOwner[] AssetOwner
        //{
        //    get
        //    {
        //        return this.assetOwnerField;
        //    }
        //    set
        //    {
        //        this.assetOwnerField = value;
        //    }
        //}

        ///// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("Maintainer")]
        //public Maintainer[] Maintainer
        //{
        //    get
        //    {
        //        return this.maintainerField;
        //    }
        //    set
        //    {
        //        this.maintainerField = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoordinateSystem")]
        public CoordinateSystem[] CoordinateSystem
        {
            get
            {
                return this.coordinateSystemField;
            }
            set
            {
                this.coordinateSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public Location[] Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsagePoint")]
        public UsagePoint[] UsagePoint
        {
            get
            {
                return this.usagePointField;
            }
            set
            {
                this.usagePointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Bay")]
        public Bay[] Bay
        {
            get
            {
                return this.bayField;
            }
            set
            {
                this.bayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectivityNode")]
        public ConnectivityNode[] ConnectivityNode
        {
            get
            {
                return this.connectivityNodeField;
            }
            set
            {
                this.connectivityNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GeographicalRegion")]
        public GeographicalRegion[] GeographicalRegion
        {
            get
            {
                return this.geographicalRegionField;
            }
            set
            {
                this.geographicalRegionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name")]
        public Name[] Name
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
        [System.Xml.Serialization.XmlElementAttribute("NameType")]
        public NameType[] NameType
        {
            get
            {
                return this.nameTypeField;
            }
            set
            {
                this.nameTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubGeographicalRegion")]
        public SubGeographicalRegion[] SubGeographicalRegion
        {
            get
            {
                return this.subGeographicalRegionField;
            }
            set
            {
                this.subGeographicalRegionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Substation")]
        public Substation[] Substation
        {
            get
            {
                return this.substationField;
            }
            set
            {
                this.substationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Terminal")]
        public Terminal[] Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VoltageLevel")]
        public VoltageLevel[] VoltageLevel
        {
            get
            {
                return this.voltageLevelField;
            }
            set
            {
                this.voltageLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ACLineSegment")]
        public ACLineSegment[] ACLineSegment
        {
            get
            {
                return this.aCLineSegmentField;
            }
            set
            {
                this.aCLineSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ACLineSegmentExt")]
        public ACLineSegmentExt[] ACLineSegmentExt
        {
            get
            {
                return this.aCLineSegmentExtField;
            }
            set
            {
                this.aCLineSegmentExtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AsynchronousMachine")]
        public AsynchronousMachine[] AsynchronousMachine
        {
            get
            {
                return this.asynchronousMachineField;
            }
            set
            {
                this.asynchronousMachineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BayExt")]
        public BayExt[] BayExt
        {
            get
            {
                return this.bayExtField;
            }
            set
            {
                this.bayExtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Breaker")]
        public Breaker[] Breaker
        {
            get
            {
                return this.breakerField;
            }
            set
            {
                this.breakerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BusbarSection")]
        public BusbarSection[] BusbarSection
        {
            get
            {
                return this.busbarSectionField;
            }
            set
            {
                this.busbarSectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrentTransformer")]
        public CurrentTransformer[] CurrentTransformer
        {
            get
            {
                return this.currentTransformerField;
            }
            set
            {
                this.currentTransformerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrentTransformerExt")]
        public CurrentTransformerExt[] CurrentTransformerExt
        {
            get
            {
                return this.currentTransformerExtField;
            }
            set
            {
                this.currentTransformerExtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Disconnector")]
        public Disconnector[] Disconnector
        {
            get
            {
                return this.disconnectorField;
            }
            set
            {
                this.disconnectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnergyConsumer")]
        public EnergyConsumer[] EnergyConsumer
        {
            get
            {
                return this.energyConsumerField;
            }
            set
            {
                this.energyConsumerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalNetworkInjection")]
        public ExternalNetworkInjection[] ExternalNetworkInjection
        {
            get
            {
                return this.externalNetworkInjectionField;
            }
            set
            {
                this.externalNetworkInjectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FaultIndicator")]
        public FaultIndicator[] FaultIndicator
        {
            get
            {
                return this.faultIndicatorField;
            }
            set
            {
                this.faultIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FaultIndicatorExt")]
        public FaultIndicatorExt[] FaultIndicatorExt
        {
            get
            {
                return this.faultIndicatorExtField;
            }
            set
            {
                this.faultIndicatorExtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fuse")]
        public Fuse[] Fuse
        {
            get
            {
                return this.fuseField;
            }
            set
            {
                this.fuseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Ground")]
        public Ground[] Ground
        {
            get
            {
                return this.groundField;
            }
            set
            {
                this.groundField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GroundDisconnector")]
        public GroundDisconnector[] GroundDisconnector
        {
            get
            {
                return this.groundDisconnectorField;
            }
            set
            {
                this.groundDisconnectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GroundingImpedance")]
        public GroundingImpedance[] GroundingImpedance
        {
            get
            {
                return this.groundingImpedanceField;
            }
            set
            {
                this.groundingImpedanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinearShuntCompensator")]
        public LinearShuntCompensator[] LinearShuntCompensator
        {
            get
            {
                return this.linearShuntCompensatorField;
            }
            set
            {
                this.linearShuntCompensatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoadBreakSwitch")]
        public LoadBreakSwitch[] LoadBreakSwitch
        {
            get
            {
                return this.loadBreakSwitchField;
            }
            set
            {
                this.loadBreakSwitchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NonlinearShuntCompensator")]
        public NonlinearShuntCompensator[] NonlinearShuntCompensator
        {
            get
            {
                return this.nonlinearShuntCompensatorField;
            }
            set
            {
                this.nonlinearShuntCompensatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NonlinearShuntCompensatorPoint")]
        public NonlinearShuntCompensatorPoint[] NonlinearShuntCompensatorPoint
        {
            get
            {
                return this.nonlinearShuntCompensatorPointField;
            }
            set
            {
                this.nonlinearShuntCompensatorPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PetersenCoil")]
        public PetersenCoil[] PetersenCoil
        {
            get
            {
                return this.petersenCoilField;
            }
            set
            {
                this.petersenCoilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PowerTransformer")]
        public PowerTransformer[] PowerTransformer
        {
            get
            {
                return this.powerTransformerField;
            }
            set
            {
                this.powerTransformerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PowerTransformerEnd")]
        public PowerTransformerEnd[] PowerTransformerEnd
        {
            get
            {
                return this.powerTransformerEndField;
            }
            set
            {
                this.powerTransformerEndField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PowerTransformerEndExt")]
        public PowerTransformerEndExt[] PowerTransformerEndExt
        {
            get
            {
                return this.powerTransformerEndExtField;
            }
            set
            {
                this.powerTransformerEndExtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RatioTapChanger")]
        public RatioTapChanger[] RatioTapChanger
        {
            get
            {
                return this.ratioTapChangerField;
            }
            set
            {
                this.ratioTapChangerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReactiveCapabilityCurve")]
        public ReactiveCapabilityCurve[] ReactiveCapabilityCurve
        {
            get
            {
                return this.reactiveCapabilityCurveField;
            }
            set
            {
                this.reactiveCapabilityCurveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Sensor")]
        public Sensor[] Sensor
        {
            get
            {
                return this.sensorField;
            }
            set
            {
                this.sensorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SeriesCompensator")]
        public SeriesCompensator[] SeriesCompensator
        {
            get
            {
                return this.seriesCompensatorField;
            }
            set
            {
                this.seriesCompensatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Switch")]
        public Switch[] Switch
        {
            get
            {
                return this.switchField;
            }
            set
            {
                this.switchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SynchronousMachine")]
        public SynchronousMachine[] SynchronousMachine
        {
            get
            {
                return this.synchronousMachineField;
            }
            set
            {
                this.synchronousMachineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TapSchedule")]
        public TapSchedule[] TapSchedule
        {
            get
            {
                return this.tapScheduleField;
            }
            set
            {
                this.tapScheduleField = value;
            }
        }
    }

    /// <summary>
    /// A base class for all objects that may contain connectivity nodes or topological nodes.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EquipmentContainer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VoltageLevel))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Substation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bay))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BayExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ConnectivityNodeContainer : PowerSystemResource
    {
    }

    /// <summary>
    /// A power system resource can be an item of equipment such as a switch, an equipment container containing many individual items of equipment such as a substation, or an organisational entity such as sub-control area. Power system resources can have measurements associated.
    /// </summary>
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
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class PowerSystemResource : IdentifiedObject
    {

        private string pSRTypeField;

        private PowerSystemResourceLocation locationField;

        private PowerSystemResourceAssets assetsField;

        /// <remarks/>
        public string PSRType
        {
            get
            {
                return this.pSRTypeField;
            }
            set
            {
                this.pSRTypeField = value;
            }
        }

        /// <remarks/>
        public PowerSystemResourceLocation Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public PowerSystemResourceAssets Assets
        {
            get
            {
                return this.assetsField;
            }
            set
            {
                this.assetsField = value;
            }
        }
    }



    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class TapSchedule
    {

        private TapScheduleTapChanger tapChangerField;

        /// <remarks/>
        public TapScheduleTapChanger TapChanger
        {
            get
            {
                return this.tapChangerField;
            }
            set
            {
                this.tapChangerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class TapScheduleTapChanger
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ReactiveCapabilityCurve
    {
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class NonlinearShuntCompensatorPoint
    {

        private Susceptance bField;

        private Susceptance b0Field;

        private Conductance gField;

        private Conductance g0Field;

        private string sectionNumberField;

        private NonlinearShuntCompensatorPointNonlinearShuntCompensator nonlinearShuntCompensatorField;

        /// <remarks/>
        public Susceptance b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        /// <remarks/>
        public Susceptance b0
        {
            get
            {
                return this.b0Field;
            }
            set
            {
                this.b0Field = value;
            }
        }

        /// <remarks/>
        public Conductance g
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        public Conductance g0
        {
            get
            {
                return this.g0Field;
            }
            set
            {
                this.g0Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string sectionNumber
        {
            get
            {
                return this.sectionNumberField;
            }
            set
            {
                this.sectionNumberField = value;
            }
        }

        /// <remarks/>
        public NonlinearShuntCompensatorPointNonlinearShuntCompensator NonlinearShuntCompensator
        {
            get
            {
                return this.nonlinearShuntCompensatorField;
            }
            set
            {
                this.nonlinearShuntCompensatorField = value;
            }
        }
    }

    /// <summary>
    /// Imaginary part of admittance.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Susceptance
    {

        private UnitMultiplier multiplierField;

        //private bool multiplierFieldSpecified;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Susceptance()
        {
            this.unitField = UnitSymbol.S;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool multiplierSpecified
        //{
        //    get
        //    {
        //        return this.multiplierFieldSpecified;
        //    }
        //    set
        //    {
        //        this.multiplierFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum UnitMultiplier
    {

        /// <remarks/>
        c,

        /// <remarks/>
        d,

        /// <remarks/>
        G,

        /// <remarks/>
        k,

        /// <remarks/>
        m,

        /// <remarks/>
        M,

        /// <remarks/>
        micro,

        /// <remarks/>
        n,

        /// <remarks/>
        none,

        /// <remarks/>
        p,

        /// <remarks/>
        T,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum UnitSymbol
    {

        /// <remarks/>
        A,

        /// <remarks/>
        deg,

        /// <remarks/>
        degC,

        /// <remarks/>
        F,

        /// <remarks/>
        g,

        /// <remarks/>
        h,

        /// <remarks/>
        H,

        /// <remarks/>
        Hz,

        /// <remarks/>
        J,

        /// <remarks/>
        m,

        /// <remarks/>
        m2,

        /// <remarks/>
        m3,

        /// <remarks/>
        min,

        /// <remarks/>
        N,

        /// <remarks/>
        none,

        /// <remarks/>
        ohm,

        /// <remarks/>
        Pa,

        /// <remarks/>
        rad,

        /// <remarks/>
        s,

        /// <remarks/>
        S,

        /// <remarks/>
        V,

        /// <remarks/>
        VA,

        /// <remarks/>
        VAh,

        /// <remarks/>
        VAr,

        /// <remarks/>
        VArh,

        /// <remarks/>
        W,

        /// <remarks/>
        Wh,
    }

    /// <summary>
    /// Factor by which voltage must be multiplied to give corresponding power lost from a circuit. Real part of admittance.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Conductance
    {

        private UnitMultiplier multiplierField;

        //private bool multiplierFieldSpecified;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Conductance()
        {
            this.unitField = UnitSymbol.S;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool multiplierSpecified
        //{
        //    get
        //    {
        //        return this.multiplierFieldSpecified;
        //    }
        //    set
        //    {
        //        this.multiplierFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class NonlinearShuntCompensatorPointNonlinearShuntCompensator
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class NameType
    {

        private string descriptionField;

        private string nameField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Name
    {

        private string nameField;

        private NameNameType nameTypeField;

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
        public NameNameType NameType
        {
            get
            {
                return this.nameTypeField;
            }
            set
            {
                this.nameTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class NameNameType
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    ///// <remarks/>
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(Maintainer))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(AssetOwner))]
    //[System.SerializableAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    //public abstract partial class AssetOrganisationRole
    //{

    //    private string mRIDField;

    //    private string nameField;

    //    /// <remarks/>
    //    public string mRID
    //    {
    //        get
    //        {
    //            return this.mRIDField;
    //        }
    //        set
    //        {
    //            this.mRIDField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    public string name
    //    {
    //        get
    //        {
    //            return this.nameField;
    //        }
    //        set
    //        {
    //            this.nameField = value;
    //        }
    //    }
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    //public partial class Maintainer : AssetOrganisationRole
    //{
    //}

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    //public partial class AssetOwner : AssetOrganisationRole
    //{
    //}

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class KiloActivePower
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public KiloActivePower()
        {
            this.unitField = UnitSymbol.W;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class VoltagePerReactivePower
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public VoltagePerReactivePower()
        {
            this.unitField = UnitSymbol.V;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Seconds
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Seconds()
        {
            this.unitField = UnitSymbol.s;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class RotationSpeed
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public RotationSpeed()
        {
            this.unitField = UnitSymbol.none;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Frequency
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Frequency()
        {
            this.multiplierField = UnitMultiplier.none;
            this.unitField = UnitSymbol.Hz;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(UnitMultiplier.none)]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PerCent
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public PerCent()
        {
            this.unitField = UnitSymbol.none;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Product of the RMS value of the voltage and the RMS value of the current.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ApparentPower
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public ApparentPower()
        {
            this.unitField = UnitSymbol.VA;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Per Unit - a positive or negative value referred to a defined base. Values typically range from -10 to +10.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PU
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public PU()
        {
            this.unitField = UnitSymbol.none;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Product of RMS value of the voltage and the RMS value of the quadrature component of the current.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ReactivePower
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public ReactivePower()
        {
            this.unitField = UnitSymbol.VAr;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Product of RMS value of the voltage and the RMS value of the in-phase component of the current.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ActivePower
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public ActivePower()
        {
            this.unitField = UnitSymbol.W;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ActivePowerPerFrequency
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public ActivePowerPerFrequency()
        {
            this.unitField = UnitSymbol.W;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Electrical current with sign convention: positive flow is out of the conducting equipment into the connectivity node. Can be both AC and DC.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class CurrentFlow
    {

        private UnitMultiplier multiplierField;

        //private bool multiplierFieldSpecified;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public CurrentFlow()
        {
            this.unitField = UnitSymbol.A;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool multiplierSpecified
        //{
        //    get
        //    {
        //        return this.multiplierFieldSpecified;
        //    }
        //    set
        //    {
        //        this.multiplierFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Capacitive part of reactance (imaginary part of impedance), at rated frequency.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Capacitance
    {

        private UnitMultiplier multiplierField;

        //private bool multiplierFieldSpecified;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Capacitance()
        {
            this.unitField = UnitSymbol.F;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool multiplierSpecified
        //{
        //    get
        //    {
        //        return this.multiplierFieldSpecified;
        //    }
        //    set
        //    {
        //        this.multiplierFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Reactance (imaginary part of impedance), at rated frequency.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Reactance
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Reactance()
        {
            this.unitField = UnitSymbol.ohm;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <summary>
    /// Resistance (real part of impedance).
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Resistance
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Resistance()
        {
            this.unitField = UnitSymbol.ohm;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Length
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Length()
        {
            this.unitField = UnitSymbol.m;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Voltage
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Voltage()
        {
            this.unitField = UnitSymbol.V;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class TelephoneNumber
    {

        private string countryCodeField;

        private string areaCodeField;

        private string cityCodeField;

        private string localNumberField;

        private string extensionField;

        /// <remarks/>
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public string areaCode
        {
            get
            {
                return this.areaCodeField;
            }
            set
            {
                this.areaCodeField = value;
            }
        }

        /// <remarks/>
        public string cityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }

        /// <remarks/>
        public string localNumber
        {
            get
            {
                return this.localNumberField;
            }
            set
            {
                this.localNumberField = value;
            }
        }

        /// <remarks/>
        public string extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }

    /// <summary>
    /// Current status information relevant to an entity.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Status
    {

        private double valueField;

        private System.DateTime dateTimeField;

        private bool dateTimeFieldSpecified;

        private string remarkField;

        private string reasonField;

        /// <remarks/>
        public double value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateTimeSpecified
        {
            get
            {
                return this.dateTimeFieldSpecified;
            }
            set
            {
                this.dateTimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string remark
        {
            get
            {
                return this.remarkField;
            }
            set
            {
                this.remarkField = value;
            }
        }

        /// <remarks/>
        public string reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class TownDetail
    {

        private string codeField;

        private string sectionField;

        private string nameField;

        private string stateOrProvinceField;

        private string countryField;

        /// <remarks/>
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string section
        {
            get
            {
                return this.sectionField;
            }
            set
            {
                this.sectionField = value;
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
        public string stateOrProvince
        {
            get
            {
                return this.stateOrProvinceField;
            }
            set
            {
                this.stateOrProvinceField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class StreetDetail
    {

        private string numberField;

        private string nameField;

        private string suffixField;

        private string prefixField;

        private string typeField;

        private string codeField;

        private string buildingNameField;

        private string suiteNumberField;

        private string addressGeneralField;

        private bool withinTownLimitsField;

        private bool withinTownLimitsFieldSpecified;

        /// <remarks/>
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
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
        public string suffix
        {
            get
            {
                return this.suffixField;
            }
            set
            {
                this.suffixField = value;
            }
        }

        /// <remarks/>
        public string prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
            }
        }

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string buildingName
        {
            get
            {
                return this.buildingNameField;
            }
            set
            {
                this.buildingNameField = value;
            }
        }

        /// <remarks/>
        public string suiteNumber
        {
            get
            {
                return this.suiteNumberField;
            }
            set
            {
                this.suiteNumberField = value;
            }
        }

        /// <remarks/>
        public string addressGeneral
        {
            get
            {
                return this.addressGeneralField;
            }
            set
            {
                this.addressGeneralField = value;
            }
        }

        /// <remarks/>
        public bool withinTownLimits
        {
            get
            {
                return this.withinTownLimitsField;
            }
            set
            {
                this.withinTownLimitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool withinTownLimitsSpecified
        {
            get
            {
                return this.withinTownLimitsFieldSpecified;
            }
            set
            {
                this.withinTownLimitsFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class StreetAddress
    {

        private StreetDetail streetDetailField;

        private TownDetail townDetailField;

        private Status statusField;

        /// <remarks/>
        public StreetDetail streetDetail
        {
            get
            {
                return this.streetDetailField;
            }
            set
            {
                this.streetDetailField = value;
            }
        }

        /// <remarks/>
        public TownDetail townDetail
        {
            get
            {
                return this.townDetailField;
            }
            set
            {
                this.townDetailField = value;
            }
        }

        /// <remarks/>
        public Status status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class LifecycleDate
    {

        private System.DateTime manufacturedDateField;

        private bool manufacturedDateFieldSpecified;

        private System.DateTime purchaseDateField;

        private bool purchaseDateFieldSpecified;

        private System.DateTime receivedDateField;

        private bool receivedDateFieldSpecified;

        private System.DateTime installationDateField;

        private bool installationDateFieldSpecified;

        private System.DateTime removalDateField;

        private bool removalDateFieldSpecified;

        private System.DateTime retiredDateField;

        private bool retiredDateFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime manufacturedDate
        {
            get
            {
                return this.manufacturedDateField;
            }
            set
            {
                this.manufacturedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manufacturedDateSpecified
        {
            get
            {
                return this.manufacturedDateFieldSpecified;
            }
            set
            {
                this.manufacturedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime purchaseDate
        {
            get
            {
                return this.purchaseDateField;
            }
            set
            {
                this.purchaseDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool purchaseDateSpecified
        {
            get
            {
                return this.purchaseDateFieldSpecified;
            }
            set
            {
                this.purchaseDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime receivedDate
        {
            get
            {
                return this.receivedDateField;
            }
            set
            {
                this.receivedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool receivedDateSpecified
        {
            get
            {
                return this.receivedDateFieldSpecified;
            }
            set
            {
                this.receivedDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime installationDate
        {
            get
            {
                return this.installationDateField;
            }
            set
            {
                this.installationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool installationDateSpecified
        {
            get
            {
                return this.installationDateFieldSpecified;
            }
            set
            {
                this.installationDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime removalDate
        {
            get
            {
                return this.removalDateField;
            }
            set
            {
                this.removalDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool removalDateSpecified
        {
            get
            {
                return this.removalDateFieldSpecified;
            }
            set
            {
                this.removalDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime retiredDate
        {
            get
            {
                return this.retiredDateField;
            }
            set
            {
                this.retiredDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool retiredDateSpecified
        {
            get
            {
                return this.retiredDateFieldSpecified;
            }
            set
            {
                this.retiredDateFieldSpecified = value;
            }
        }
    }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class IdentifiedObjectNames
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// A conducting connection point of a power transformer. It corresponds to a physical transformer winding terminal.  In earlier CIM versions, the TransformerWinding class served a similar purpose, but this class is more flexible because it associates to terminal but is not a specialization of ConductingEquipment.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerTransformerEnd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerTransformerEndExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class TransformerEnd : IdentifiedObject
    {

        private string endNumberField;

        private bool groundedField;

        private Resistance rgroundField;

        private Reactance xgroundField;

        private double baseVoltageField;

        private TransformerEndTerminal terminalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string endNumber
        {
            get
            {
                return this.endNumberField;
            }
            set
            {
                this.endNumberField = value;
            }
        }

        /// <remarks/>
        public bool grounded
        {
            get
            {
                return this.groundedField;
            }
            set
            {
                this.groundedField = value;
            }
        }

        /// <remarks/>
        public Resistance rground
        {
            get
            {
                return this.rgroundField;
            }
            set
            {
                this.rgroundField = value;
            }
        }

        /// <remarks/>
        public Reactance xground
        {
            get
            {
                return this.xgroundField;
            }
            set
            {
                this.xgroundField = value;
            }
        }

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

        /// <remarks/>
        public TransformerEndTerminal Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }



    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class TransformerEndTerminal
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// A PowerTransformerEnd is associated with each Terminal of a PowerTransformer.
    /// The impedance values r, r0, x, and x0 of a PowerTransformerEnd represents a star equivalent as follows
    ///1) for a two Terminal PowerTransformer the high voltage PowerTransformerEnd has non zero values on r, r0, x, and x0 while the low voltage PowerTransformerEnd has zero values for r, r0, x, and x0.
    ///2) for a three Terminal PowerTransformer the three PowerTransformerEnds represents a star equivalent with each leg in the star represented by r, r0, x, and x0 values.
    ///3) for a PowerTransformer with more than three Terminals the PowerTransformerEnd impedance values cannot be used.Instead use the TransformerMeshImpedance or split the transformer into multiple PowerTransformers.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PowerTransformerEndExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PowerTransformerEnd : TransformerEnd
    {

        private Susceptance bField;

        private Susceptance b0Field;

        private Conductance gField;

        private Conductance g0Field;

        private string phaseAngleClockField;

        private Resistance rField;

        private Resistance r0Field;

        private ApparentPower ratedSField;

        private Voltage ratedUField;

        private Reactance xField;

        private Reactance x0Field;

        private PowerTransformerEndPowerTransformer powerTransformerField;

        /// <remarks/>
        public Susceptance b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        /// <remarks/>
        public Susceptance b0
        {
            get
            {
                return this.b0Field;
            }
            set
            {
                this.b0Field = value;
            }
        }

        /// <remarks/>
        public Conductance g
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        public Conductance g0
        {
            get
            {
                return this.g0Field;
            }
            set
            {
                this.g0Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string phaseAngleClock
        {
            get
            {
                return this.phaseAngleClockField;
            }
            set
            {
                this.phaseAngleClockField = value;
            }
        }

        /// <remarks/>
        public Resistance r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        public Resistance r0
        {
            get
            {
                return this.r0Field;
            }
            set
            {
                this.r0Field = value;
            }
        }

        /// <remarks/>
        public ApparentPower ratedS
        {
            get
            {
                return this.ratedSField;
            }
            set
            {
                this.ratedSField = value;
            }
        }

        /// <remarks/>
        public Voltage ratedU
        {
            get
            {
                return this.ratedUField;
            }
            set
            {
                this.ratedUField = value;
            }
        }

        /// <remarks/>
        public Reactance x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public Reactance x0
        {
            get
            {
                return this.x0Field;
            }
            set
            {
                this.x0Field = value;
            }
        }

        /// <remarks/>
        public PowerTransformerEndPowerTransformer PowerTransformer
        {
            get
            {
                return this.powerTransformerField;
            }
            set
            {
                this.powerTransformerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PowerTransformerEndPowerTransformer
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// PowerTransformerEnd extension containing losses, uk and exicingCurrentZero
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PowerTransformerEndExt : PowerTransformerEnd
    {

        private PerCent excitingCurrentZeroField;

        private KiloActivePower lossField;

        private KiloActivePower lossZeroField;

        private Voltage nominalVoltageField;

        private PerCent ukField;

        /// <remarks/>
        public PerCent excitingCurrentZero
        {
            get
            {
                return this.excitingCurrentZeroField;
            }
            set
            {
                this.excitingCurrentZeroField = value;
            }
        }

        /// <remarks/>
        public KiloActivePower loss
        {
            get
            {
                return this.lossField;
            }
            set
            {
                this.lossField = value;
            }
        }

        /// <remarks/>
        public KiloActivePower lossZero
        {
            get
            {
                return this.lossZeroField;
            }
            set
            {
                this.lossZeroField = value;
            }
        }

        /// <remarks/>
        public Voltage nominalVoltage
        {
            get
            {
                return this.nominalVoltageField;
            }
            set
            {
                this.nominalVoltageField = value;
            }
        }

        /// <remarks/>
        public PerCent uk
        {
            get
            {
                return this.ukField;
            }
            set
            {
                this.ukField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class SubGeographicalRegion : IdentifiedObject
    {

        private SubGeographicalRegionSubstations[] substationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Substations")]
        public SubGeographicalRegionSubstations[] Substations
        {
            get
            {
                return this.substationsField;
            }
            set
            {
                this.substationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class SubGeographicalRegionSubstations
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class GeographicalRegion : IdentifiedObject
    {
    }

    /// <summary>
    /// Connectivity nodes are points where terminals of AC conducting equipment are connected together with zero impedance.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ConnectivityNode : IdentifiedObject
    {
    }

    /// <summary>
    /// An electrical connection point (AC or DC) to a piece of conducting equipment. Terminals are connected at physical connection points called connectivity nodes.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Terminal))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class ACDCTerminal : IdentifiedObject
    {
        private string sequenceNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string sequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }
    }

    /// <summary>
    /// An AC electrical connection point to a piece of conducting equipment. Terminals are connected at physical connection points called connectivity nodes.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Terminal : ACDCTerminal
    {

        private PhaseCode phasesField;

        private bool phasesFieldSpecified;

        private TerminalConductingEquipment conductingEquipmentField;

        private TerminalConnectivityNode connectivityNodeField;

        /// <remarks/>
        public PhaseCode phases
        {
            get
            {
                return this.phasesField;
            }
            set
            {
                this.phasesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool phasesSpecified
        {
            get
            {
                return this.phasesFieldSpecified;
            }
            set
            {
                this.phasesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TerminalConductingEquipment ConductingEquipment
        {
            get
            {
                return this.conductingEquipmentField;
            }
            set
            {
                this.conductingEquipmentField = value;
            }
        }

        /// <remarks/>
        public TerminalConnectivityNode ConnectivityNode
        {
            get
            {
                return this.connectivityNodeField;
            }
            set
            {
                this.connectivityNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum PhaseCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        AB,

        /// <remarks/>
        ABC,

        /// <remarks/>
        ABCN,

        /// <remarks/>
        ABN,

        /// <remarks/>
        AC,

        /// <remarks/>
        ACN,

        /// <remarks/>
        AN,

        /// <remarks/>
        B,

        /// <remarks/>
        BC,

        /// <remarks/>
        BCN,

        /// <remarks/>
        BN,

        /// <remarks/>
        C,

        /// <remarks/>
        CN,

        /// <remarks/>
        N,

        /// <remarks/>
        s1,

        /// <remarks/>
        s12,

        /// <remarks/>
        s12N,

        /// <remarks/>
        s1N,

        /// <remarks/>
        s2,

        /// <remarks/>
        s2N,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class TerminalConductingEquipment
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class TerminalConnectivityNode
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// CIM description:
    /// Logical or physical point in the network to which readings or events may be attributed.Used at the place where a physical or virtual meter may be located; however, it is not required that a meter be present.
    /// Danish stuff:
    /// Represents what in daily words is referred to as installation. The EAN(18 digit installationsnumber should be put in the name attribute).
    /// Repræsenter en installation/aftagepunkt, hvor der typisk sidder en maaler. EAN-/Aftagenummer skrives i navn. Bemaerk at der en 1-mange relation mellem ConductionEquipment og UsagePoint, som fx kan udnyttes i etageejendomme, hvor der kan vaere mange maalere tilknyttet en stikledning.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class UsagePoint : IdentifiedObject
    {

        private UsagePointEquipments equipmentsField;

        /// <remarks/>
        public UsagePointEquipments Equipments
        {
            get
            {
                return this.equipmentsField;
            }
            set
            {
                this.equipmentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class UsagePointEquipments
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// The place, scene, or point of something where someone or something has been, is, and/or will be at a given moment in time. It can be defined with one or more postition points (coordinates) in a given coordinate system.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationExt))]
    public partial class Location : IdentifiedObject
    {
        private string directionField;

        private StreetAddress mainAddressField;

        private TelephoneNumber phone1Field;

        private TelephoneNumber phone2Field;

        private LocationCoordinateSystem coordinateSystemField;

        /// <remarks/>
        public string direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        public StreetAddress mainAddress
        {
            get
            {
                return this.mainAddressField;
            }
            set
            {
                this.mainAddressField = value;
            }
        }

        /// <remarks/>
        public TelephoneNumber phone1
        {
            get
            {
                return this.phone1Field;
            }
            set
            {
                this.phone1Field = value;
            }
        }

        /// <remarks/>
        public TelephoneNumber phone2
        {
            get
            {
                return this.phone2Field;
            }
            set
            {
                this.phone2Field = value;
            }
        }

        /// <remarks/>
        public LocationCoordinateSystem CoordinateSystem
        {
            get
            {
                return this.coordinateSystemField;
            }
            set
            {
                this.coordinateSystemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class LocationCoordinateSystem
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class CoordinateSystem : IdentifiedObject
    {

        private string crsUrnField;

        /// <remarks/>
        public string crsUrn
        {
            get
            {
                return this.crsUrnField;
            }
            set
            {
                this.crsUrnField = value;
            }
        }
    }

    /// <summary>
    /// Tangible resource of the utility, including power system equipment, various end devices, cabinets, buildings, etc. For electrical network equipment, the role of the asset is defined through PowerSystemResource and its subclasses, defined mainly in the Wires model (refer to IEC61970-301 and model package IEC61970::Wires). Asset description places emphasis on the physical characteristics of the equipment fulfilling that role.
    /// TODO: Move out of this model. Asset is another bounded context than the physical network model.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Asset : IdentifiedObject
    {

        private string lotNumberField;

        private string serialNumberField;

        private string typeField;

        private LifecycleDate lifecycleField;

        //private AssetOrganisationRoles[] organisationRolesField;

        private string ownerField;

        private string maintainerField;

        public string owner
        {
            get { return this.ownerField; }
            set { ownerField = value; }
        }

        public string maintainer
        {
            get { return maintainerField; }
            set { maintainerField = value; }
        }

        /// <remarks/>
        public string lotNumber
        {
            get
            {
                return this.lotNumberField;
            }
            set
            {
                this.lotNumberField = value;
            }
        }

        /// <remarks/>
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public LifecycleDate lifecycle
        {
            get
            {
                return this.lifecycleField;
            }
            set
            {
                this.lifecycleField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute("OrganisationRoles")]
        //public AssetOrganisationRoles[] OrganisationRoles
        //{
        //    get
        //    {
        //        return this.organisationRolesField;
        //    }
        //    set
        //    {
        //        this.organisationRolesField = value;
        //    }
        //}
    }

    ///// <remarks/>
    //[System.SerializableAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    //public partial class AssetOrganisationRoles
    //{

    //    private string referenceTypeField;

    //    private string refField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string referenceType
    //    {
    //        get
    //        {
    //            return this.referenceTypeField;
    //        }
    //        set
    //        {
    //            this.referenceTypeField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string @ref
    //    {
    //        get
    //        {
    //            return this.refField;
    //        }
    //        set
    //        {
    //            this.refField = value;
    //        }
    //    }
    //}

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PowerSystemResourceLocation
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PowerSystemResourceAssets
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// Mechanism for changing transformer winding tap positions.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RatioTapChanger))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class TapChanger : PowerSystemResource
    {

        private string highStepField;

        private string lowStepField;

        private bool ltcFlagField;

        private string neutralStepField;

        private Voltage neutralUField;

        private string normalStepField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string highStep
        {
            get
            {
                return this.highStepField;
            }
            set
            {
                this.highStepField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string lowStep
        {
            get
            {
                return this.lowStepField;
            }
            set
            {
                this.lowStepField = value;
            }
        }

        /// <remarks/>
        public bool ltcFlag
        {
            get
            {
                return this.ltcFlagField;
            }
            set
            {
                this.ltcFlagField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string neutralStep
        {
            get
            {
                return this.neutralStepField;
            }
            set
            {
                this.neutralStepField = value;
            }
        }

        /// <remarks/>
        public Voltage neutralU
        {
            get
            {
                return this.neutralUField;
            }
            set
            {
                this.neutralUField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string normalStep
        {
            get
            {
                return this.normalStepField;
            }
            set
            {
                this.normalStepField = value;
            }
        }
    }

    /// <summary>
    /// A tap changer that changes the voltage ratio impacting the voltage magnitude but not the phase angle across the transformer.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class RatioTapChanger : TapChanger
    {

        private PerCent stepVoltageIncrementField;

        private RatioTapChangerTransformerEnd transformerEndField;

        /// <remarks/>
        public PerCent stepVoltageIncrement
        {
            get
            {
                return this.stepVoltageIncrementField;
            }
            set
            {
                this.stepVoltageIncrementField = value;
            }
        }

        /// <remarks/>
        public RatioTapChangerTransformerEnd TransformerEnd
        {
            get
            {
                return this.transformerEndField;
            }
            set
            {
                this.transformerEndField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class RatioTapChangerTransformerEnd
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// The parts of a power system that are physical devices, electronic or mechanical.
    /// </summary>
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
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class Equipment : PowerSystemResource
    {

        private bool aggregateField;

        private bool aggregateFieldSpecified;

        private EquipmentEquipmentContainer equipmentContainerField;

        /// <remarks/>
        public bool aggregate
        {
            get
            {
                return this.aggregateField;
            }
            set
            {
                this.aggregateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool aggregateSpecified
        {
            get
            {
                return this.aggregateFieldSpecified;
            }
            set
            {
                this.aggregateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public EquipmentEquipmentContainer EquipmentContainer
        {
            get
            {
                return this.equipmentContainerField;
            }
            set
            {
                this.equipmentContainerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class EquipmentEquipmentContainer
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// AuxiliaryEquipment describe equipment that is not performing any primary functions but support for the equipment performing the primary function.
    /// AuxiliaryEquipment is attached to primary eqipment via an association with Terminal.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Sensor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformerExt))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultIndicator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultIndicatorExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class AuxiliaryEquipment : Equipment
    {

        private AuxiliaryEquipmentTerminal terminalField;

        /// <remarks/>
        public AuxiliaryEquipmentTerminal Terminal
        {
            get
            {
                return this.terminalField;
            }
            set
            {
                this.terminalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class AuxiliaryEquipmentTerminal
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformerExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Sensor : AuxiliaryEquipment
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrentTransformerExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class CurrentTransformer : Sensor
    {
    }

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

    /// <summary>
    /// A FaultIndicator is typically only an indicator (which may or may not be remotely monitored), and not a piece of equipment that actually initiates a protection event. It is used for FLISR (Fault Location, Isolation and Restoration) purposes, assisting with the dispatch of crews to "most likely" part of the network (i.e. assists with determining circuit section where the fault most likely happened).
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaultIndicatorExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class FaultIndicator : AuxiliaryEquipment
    {
    }

    /// <summary>
    /// FaultIndicator extension containing resetKind attribute.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class FaultIndicatorExt : FaultIndicator
    {

        private FaultIndicatorResetKind resetKindField;

        private bool resetKindFieldSpecified;

        /// <remarks/>
        public FaultIndicatorResetKind resetKind
        {
            get
            {
                return this.resetKindField;
            }
            set
            {
                this.resetKindField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resetKindSpecified
        {
            get
            {
                return this.resetKindFieldSpecified;
            }
            set
            {
                this.resetKindFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum FaultIndicatorResetKind
    {

        /// <remarks/>
        automatic,

        /// <remarks/>
        manual,

        /// <remarks/>
        other,

        /// <remarks/>
        remote,
    }

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

    /// <summary>
    /// A generic device designed to close, or open, or both, one or more electric circuits.  All switches are two terminal devices including grounding switches.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProtectedSwitch))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoadBreakSwitch))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Breaker))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroundDisconnector))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Fuse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Disconnector))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Switch : ConductingEquipment
    {

        private bool normalOpenField;

        private CurrentFlow ratedCurrentField;

        /// <remarks/>
        public bool normalOpen
        {
            get
            {
                return this.normalOpenField;
            }
            set
            {
                this.normalOpenField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow ratedCurrent
        {
            get
            {
                return this.ratedCurrentField;
            }
            set
            {
                this.ratedCurrentField = value;
            }
        }
    }

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

    /// <summary>
    /// A mechanical switching device capable of making, carrying, and breaking currents under normal operating conditions.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class LoadBreakSwitch : ProtectedSwitch
    {
    }

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

    /// <summary>
    /// A manually operated or motor operated mechanical switching device used for isolating a circuit or equipment from ground.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class GroundDisconnector : Switch
    {
    }

    /// <summary>
    /// An overcurrent protective device with a circuit opening fusible part that is heated and severed by the passage of overcurrent through it. A fuse is considered a switching device because it breaks current.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Fuse : Switch
    {
    }

    /// <summary>
    /// A manually operated or motor operated mechanical switching device used for changing the connections in a circuit, or for isolating a circuit or equipment from a source of power. It is required to open or close circuits when negligible current is broken or made.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Disconnector : Switch
    {
    }

    /// <summary>
    /// A Series Compensator is a series capacitor or reactor or an AC transmission line without charging susceptance.  It is a two terminal device.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class SeriesCompensator : ConductingEquipment
    {

        private Resistance rField;

        private Resistance r0Field;

        private Reactance xField;

        private Reactance x0Field;

        /// <remarks/>
        public Resistance r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        public Resistance r0
        {
            get
            {
                return this.r0Field;
            }
            set
            {
                this.r0Field = value;
            }
        }

        /// <remarks/>
        public Reactance x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public Reactance x0
        {
            get
            {
                return this.x0Field;
            }
            set
            {
                this.x0Field = value;
            }
        }
    }

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

    /// <summary>
    /// A shunt capacitor or reactor or switchable bank of shunt capacitors or reactors. A section of a shunt compensator is an individual capacitor or reactor.  A negative value for reactivePerSection indicates that the compensator is a reactor. ShuntCompensator is a single terminal device.  Ground is implied.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonlinearShuntCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearShuntCompensator))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class ShuntCompensator : RegulatingCondEq
    {

        private Seconds aVRDelayField;

        private bool groundedField;

        private bool groundedFieldSpecified;

        private string maximumSectionsField;

        private Voltage nomUField;

        private string normalSectionsField;

        private string switchOnCountField;

        private System.DateTime switchOnDateField;

        private bool switchOnDateFieldSpecified;

        private VoltagePerReactivePower voltageSensitivityField;

        /// <remarks/>
        public Seconds aVRDelay
        {
            get
            {
                return this.aVRDelayField;
            }
            set
            {
                this.aVRDelayField = value;
            }
        }

        /// <remarks/>
        public bool grounded
        {
            get
            {
                return this.groundedField;
            }
            set
            {
                this.groundedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool groundedSpecified
        {
            get
            {
                return this.groundedFieldSpecified;
            }
            set
            {
                this.groundedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string maximumSections
        {
            get
            {
                return this.maximumSectionsField;
            }
            set
            {
                this.maximumSectionsField = value;
            }
        }

        /// <remarks/>
        public Voltage nomU
        {
            get
            {
                return this.nomUField;
            }
            set
            {
                this.nomUField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string normalSections
        {
            get
            {
                return this.normalSectionsField;
            }
            set
            {
                this.normalSectionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string switchOnCount
        {
            get
            {
                return this.switchOnCountField;
            }
            set
            {
                this.switchOnCountField = value;
            }
        }

        /// <remarks/>
        public System.DateTime switchOnDate
        {
            get
            {
                return this.switchOnDateField;
            }
            set
            {
                this.switchOnDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool switchOnDateSpecified
        {
            get
            {
                return this.switchOnDateFieldSpecified;
            }
            set
            {
                this.switchOnDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VoltagePerReactivePower voltageSensitivity
        {
            get
            {
                return this.voltageSensitivityField;
            }
            set
            {
                this.voltageSensitivityField = value;
            }
        }
    }

    /// <summary>
    /// A non linear shunt compensator has bank or section admittance values that differs.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class NonlinearShuntCompensator : ShuntCompensator
    {
    }

    /// <summary>
    /// A linear shunt compensator has banks or sections with equal admittance values.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class LinearShuntCompensator : ShuntCompensator
    {

        private Susceptance b0PerSectionField;

        private Susceptance bPerSectionField;

        private Conductance g0PerSectionField;

        private Conductance gPerSectionField;

        /// <remarks/>
        public Susceptance b0PerSection
        {
            get
            {
                return this.b0PerSectionField;
            }
            set
            {
                this.b0PerSectionField = value;
            }
        }

        /// <remarks/>
        public Susceptance bPerSection
        {
            get
            {
                return this.bPerSectionField;
            }
            set
            {
                this.bPerSectionField = value;
            }
        }

        /// <remarks/>
        public Conductance g0PerSection
        {
            get
            {
                return this.g0PerSectionField;
            }
            set
            {
                this.g0PerSectionField = value;
            }
        }

        /// <remarks/>
        public Conductance gPerSection
        {
            get
            {
                return this.gPerSectionField;
            }
            set
            {
                this.gPerSectionField = value;
            }
        }
    }

    /// <summary>
    /// A rotating machine which may be used as a generator or motor.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SynchronousMachine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AsynchronousMachine))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class RotatingMachine : RegulatingCondEq
    {

        private double ratedPowerFactorField;

        private bool ratedPowerFactorFieldSpecified;

        private ApparentPower ratedSField;

        private Voltage ratedUField;

        /// <remarks/>
        public double ratedPowerFactor
        {
            get
            {
                return this.ratedPowerFactorField;
            }
            set
            {
                this.ratedPowerFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ratedPowerFactorSpecified
        {
            get
            {
                return this.ratedPowerFactorFieldSpecified;
            }
            set
            {
                this.ratedPowerFactorFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ApparentPower ratedS
        {
            get
            {
                return this.ratedSField;
            }
            set
            {
                this.ratedSField = value;
            }
        }

        /// <remarks/>
        public Voltage ratedU
        {
            get
            {
                return this.ratedUField;
            }
            set
            {
                this.ratedUField = value;
            }
        }
    }

    /// <summary>
    /// An electromechanical device that operates with shaft rotating synchronously with the network. It is a single machine operating either as a generator or synchronous condenser or pump.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class SynchronousMachine : RotatingMachine
    {

        private CurrentFlow ikkField;

        private ReactivePower maxQField;

        private ReactivePower minQField;

        private double muField;

        private bool muFieldSpecified;

        private PerCent qPercentField;

        private Resistance rField;

        private PU r0Field;

        private PU r2Field;

        private string referencePriorityField;

        private PU satDirectSubtransXField;

        private ShortCircuitRotorKind shortCircuitRotorTypeField;

        private bool shortCircuitRotorTypeFieldSpecified;

        private SynchronousMachineKind typeField;

        private PerCent voltageRegulationRangeField;

        private PU x0Field;

        private PU x2Field;

        private SynchronousMachineInitialReactiveCapabilityCurve initialReactiveCapabilityCurveField;

        /// <remarks/>
        public CurrentFlow ikk
        {
            get
            {
                return this.ikkField;
            }
            set
            {
                this.ikkField = value;
            }
        }

        /// <remarks/>
        public ReactivePower maxQ
        {
            get
            {
                return this.maxQField;
            }
            set
            {
                this.maxQField = value;
            }
        }

        /// <remarks/>
        public ReactivePower minQ
        {
            get
            {
                return this.minQField;
            }
            set
            {
                this.minQField = value;
            }
        }

        /// <remarks/>
        public double mu
        {
            get
            {
                return this.muField;
            }
            set
            {
                this.muField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool muSpecified
        {
            get
            {
                return this.muFieldSpecified;
            }
            set
            {
                this.muFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PerCent qPercent
        {
            get
            {
                return this.qPercentField;
            }
            set
            {
                this.qPercentField = value;
            }
        }

        /// <remarks/>
        public Resistance r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        public PU r0
        {
            get
            {
                return this.r0Field;
            }
            set
            {
                this.r0Field = value;
            }
        }

        /// <remarks/>
        public PU r2
        {
            get
            {
                return this.r2Field;
            }
            set
            {
                this.r2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string referencePriority
        {
            get
            {
                return this.referencePriorityField;
            }
            set
            {
                this.referencePriorityField = value;
            }
        }

        /// <remarks/>
        public PU satDirectSubtransX
        {
            get
            {
                return this.satDirectSubtransXField;
            }
            set
            {
                this.satDirectSubtransXField = value;
            }
        }

        /// <remarks/>
        public ShortCircuitRotorKind shortCircuitRotorType
        {
            get
            {
                return this.shortCircuitRotorTypeField;
            }
            set
            {
                this.shortCircuitRotorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shortCircuitRotorTypeSpecified
        {
            get
            {
                return this.shortCircuitRotorTypeFieldSpecified;
            }
            set
            {
                this.shortCircuitRotorTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SynchronousMachineKind type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public PerCent voltageRegulationRange
        {
            get
            {
                return this.voltageRegulationRangeField;
            }
            set
            {
                this.voltageRegulationRangeField = value;
            }
        }

        /// <remarks/>
        public PU x0
        {
            get
            {
                return this.x0Field;
            }
            set
            {
                this.x0Field = value;
            }
        }

        /// <remarks/>
        public PU x2
        {
            get
            {
                return this.x2Field;
            }
            set
            {
                this.x2Field = value;
            }
        }

        /// <remarks/>
        public SynchronousMachineInitialReactiveCapabilityCurve InitialReactiveCapabilityCurve
        {
            get
            {
                return this.initialReactiveCapabilityCurveField;
            }
            set
            {
                this.initialReactiveCapabilityCurveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum ShortCircuitRotorKind
    {

        /// <remarks/>
        salientPole1,

        /// <remarks/>
        salientPole2,

        /// <remarks/>
        turboSeries1,

        /// <remarks/>
        turboSeries2,
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum SynchronousMachineKind
    {

        /// <remarks/>
        condenser,

        /// <remarks/>
        generator,

        /// <remarks/>
        generatorOrCondenser,

        /// <remarks/>
        generatorOrCondenserOrMotor,

        /// <remarks/>
        generatorOrMotor,

        /// <remarks/>
        motor,

        /// <remarks/>
        motorOrCondenser,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class SynchronousMachineInitialReactiveCapabilityCurve
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// A rotating machine whose shaft rotates asynchronously with the electrical field. Also known as an induction machine with no external connection to the rotor windings, e.g squirrel-cage induction machine.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class AsynchronousMachine : RotatingMachine
    {

        private bool converterFedDriveField;

        private PerCent efficiencyField;

        private double iaIrRatioField;

        private Frequency nominalFrequencyField;

        private RotationSpeed nominalSpeedField;

        private string polePairNumberField;

        private ActivePower ratedMechanicalPowerField;

        private bool reversibleField;

        private double rxLockedRotorRatioField;

        private bool rxLockedRotorRatioFieldSpecified;

        /// <remarks/>
        public bool converterFedDrive
        {
            get
            {
                return this.converterFedDriveField;
            }
            set
            {
                this.converterFedDriveField = value;
            }
        }

        /// <remarks/>
        public PerCent efficiency
        {
            get
            {
                return this.efficiencyField;
            }
            set
            {
                this.efficiencyField = value;
            }
        }

        /// <remarks/>
        public double iaIrRatio
        {
            get
            {
                return this.iaIrRatioField;
            }
            set
            {
                this.iaIrRatioField = value;
            }
        }

        /// <remarks/>
        public Frequency nominalFrequency
        {
            get
            {
                return this.nominalFrequencyField;
            }
            set
            {
                this.nominalFrequencyField = value;
            }
        }

        /// <remarks/>
        public RotationSpeed nominalSpeed
        {
            get
            {
                return this.nominalSpeedField;
            }
            set
            {
                this.nominalSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string polePairNumber
        {
            get
            {
                return this.polePairNumberField;
            }
            set
            {
                this.polePairNumberField = value;
            }
        }

        /// <remarks/>
        public ActivePower ratedMechanicalPower
        {
            get
            {
                return this.ratedMechanicalPowerField;
            }
            set
            {
                this.ratedMechanicalPowerField = value;
            }
        }

        /// <remarks/>
        public bool reversible
        {
            get
            {
                return this.reversibleField;
            }
            set
            {
                this.reversibleField = value;
            }
        }

        /// <remarks/>
        public double rxLockedRotorRatio
        {
            get
            {
                return this.rxLockedRotorRatioField;
            }
            set
            {
                this.rxLockedRotorRatioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rxLockedRotorRatioSpecified
        {
            get
            {
                return this.rxLockedRotorRatioFieldSpecified;
            }
            set
            {
                this.rxLockedRotorRatioFieldSpecified = value;
            }
        }
    }

    /// <summary>
    /// This class represents external network and it is used for IEC 60909 calculations.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ExternalNetworkInjection : RegulatingCondEq
    {

        private ActivePowerPerFrequency governorSCDField;

        private bool ikSecondField;

        private bool ikSecondFieldSpecified;

        private CurrentFlow maxInitialSymShCCurrentField;

        private ActivePower maxPField;

        private ReactivePower maxQField;

        private double maxR0ToX0RatioField;

        private double maxR1ToX1RatioField;

        private double maxZ0ToZ1RatioField;

        private CurrentFlow minInitialSymShCCurrentField;

        private ActivePower minPField;

        private ReactivePower minQField;

        private double minR0ToX0RatioField;

        private double minR1ToX1RatioField;

        private double minZ0ToZ1RatioField;

        private PU voltageFactorField;

        /// <remarks/>
        public ActivePowerPerFrequency governorSCD
        {
            get
            {
                return this.governorSCDField;
            }
            set
            {
                this.governorSCDField = value;
            }
        }

        /// <remarks/>
        public bool ikSecond
        {
            get
            {
                return this.ikSecondField;
            }
            set
            {
                this.ikSecondField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ikSecondSpecified
        {
            get
            {
                return this.ikSecondFieldSpecified;
            }
            set
            {
                this.ikSecondFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CurrentFlow maxInitialSymShCCurrent
        {
            get
            {
                return this.maxInitialSymShCCurrentField;
            }
            set
            {
                this.maxInitialSymShCCurrentField = value;
            }
        }

        /// <remarks/>
        public ActivePower maxP
        {
            get
            {
                return this.maxPField;
            }
            set
            {
                this.maxPField = value;
            }
        }

        /// <remarks/>
        public ReactivePower maxQ
        {
            get
            {
                return this.maxQField;
            }
            set
            {
                this.maxQField = value;
            }
        }

        /// <remarks/>
        public double maxR0ToX0Ratio
        {
            get
            {
                return this.maxR0ToX0RatioField;
            }
            set
            {
                this.maxR0ToX0RatioField = value;
            }
        }

        /// <remarks/>
        public double maxR1ToX1Ratio
        {
            get
            {
                return this.maxR1ToX1RatioField;
            }
            set
            {
                this.maxR1ToX1RatioField = value;
            }
        }

        /// <remarks/>
        public double maxZ0ToZ1Ratio
        {
            get
            {
                return this.maxZ0ToZ1RatioField;
            }
            set
            {
                this.maxZ0ToZ1RatioField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow minInitialSymShCCurrent
        {
            get
            {
                return this.minInitialSymShCCurrentField;
            }
            set
            {
                this.minInitialSymShCCurrentField = value;
            }
        }

        /// <remarks/>
        public ActivePower minP
        {
            get
            {
                return this.minPField;
            }
            set
            {
                this.minPField = value;
            }
        }

        /// <remarks/>
        public ReactivePower minQ
        {
            get
            {
                return this.minQField;
            }
            set
            {
                this.minQField = value;
            }
        }

        /// <remarks/>
        public double minR0ToX0Ratio
        {
            get
            {
                return this.minR0ToX0RatioField;
            }
            set
            {
                this.minR0ToX0RatioField = value;
            }
        }

        /// <remarks/>
        public double minR1ToX1Ratio
        {
            get
            {
                return this.minR1ToX1RatioField;
            }
            set
            {
                this.minR1ToX1RatioField = value;
            }
        }

        /// <remarks/>
        public double minZ0ToZ1Ratio
        {
            get
            {
                return this.minZ0ToZ1RatioField;
            }
            set
            {
                this.minZ0ToZ1RatioField = value;
            }
        }

        /// <remarks/>
        public PU voltageFactor
        {
            get
            {
                return this.voltageFactorField;
            }
            set
            {
                this.voltageFactorField = value;
            }
        }
    }

    /// <summary>
    /// An electrical device consisting of  two or more coupled windings, with or without a magnetic core, for introducing mutual coupling between electric circuits. Transformers can be used to control voltage and phase shift (active power flow).
    /// A power transformer may be composed of separate transformer tanks that need not be identical.
    /// A power transformer can be modeled with or without tanks and is intended for use in both balanced and unbalanced representations.A power transformer typically has two terminals, but may have one(grounding), three or more terminals.
    /// The inherited association ConductingEquipment.BaseVoltage should not be used.The association from TransformerEnd to BaseVoltage should be used instead.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PowerTransformer : ConductingEquipment
    {
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Ground : ConductingEquipment
    {
    }

    /// <summary>
    /// Generic user of energy - a  point of consumption on the power system model.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class EnergyConsumer : ConductingEquipment
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PetersenCoil))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroundingImpedance))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class EarthFaultCompensator : ConductingEquipment
    {

        private Resistance rField;

        /// <remarks/>
        public Resistance r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }
    }

    /// <summary>
    /// A tunable impedance device normally used to offset line charging during single line faults in an ungrounded section of network.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PetersenCoil : EarthFaultCompensator
    {

        private PetersenCoilModeKind modeField;

        private Voltage nominalUField;

        private CurrentFlow offsetCurrentField;

        private CurrentFlow positionCurrentField;

        private Reactance xGroundMaxField;

        private Reactance xGroundMinField;

        private Reactance xGroundNominalField;

        /// <remarks/>
        public PetersenCoilModeKind mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public Voltage nominalU
        {
            get
            {
                return this.nominalUField;
            }
            set
            {
                this.nominalUField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow offsetCurrent
        {
            get
            {
                return this.offsetCurrentField;
            }
            set
            {
                this.offsetCurrentField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow positionCurrent
        {
            get
            {
                return this.positionCurrentField;
            }
            set
            {
                this.positionCurrentField = value;
            }
        }

        /// <remarks/>
        public Reactance xGroundMax
        {
            get
            {
                return this.xGroundMaxField;
            }
            set
            {
                this.xGroundMaxField = value;
            }
        }

        /// <remarks/>
        public Reactance xGroundMin
        {
            get
            {
                return this.xGroundMinField;
            }
            set
            {
                this.xGroundMinField = value;
            }
        }

        /// <remarks/>
        public Reactance xGroundNominal
        {
            get
            {
                return this.xGroundNominalField;
            }
            set
            {
                this.xGroundNominalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum PetersenCoilModeKind
    {

        /// <remarks/>
        automaticPositioning,

        /// <remarks/>
        @fixed,

        /// <remarks/>
        manual,
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class GroundingImpedance : EarthFaultCompensator
    {

        private Reactance xField;

        /// <remarks/>
        public Reactance x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
    }

    /// <summary>
    /// A conductor, or group of conductors, with negligible impedance, that serve to connect other conducting equipment within a single substation and are modelled with a single logical terminal.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusbarSection))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class Connector : ConductingEquipment
    {
    }

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

    /// <summary>
    /// Combination of conducting material with consistent electrical characteristics, building a single electrical system, used to carry current between points in the power system.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACLineSegment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACLineSegmentExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class Conductor : ConductingEquipment
    {

        private Length lengthField;

        /// <remarks/>
        public Length length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }
    }

    /// <summary>
    /// A wire or combination of wires, with consistent electrical characteristics, building a single electrical system, used to carry alternating current between points in the power system.
    /// For symmetrical, transposed 3ph lines, it is sufficient to use attributes of the line segment, which describe impedances and admittances for the entire length of the segment.Additionally impedances can be computed by using length and associated per length impedances.
    /// The BaseVoltage at the two ends of ACLineSegments in a Line shall have the same BaseVoltage.nominalVoltage.However, boundary lines  may have slightly different BaseVoltage.nominalVoltages and  variation is allowed.Larger voltage difference in general requires use of an equivalent branch.</xs:documentation>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACLineSegmentExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ACLineSegment : Conductor
    {

        private Susceptance b0chField;

        private Susceptance bchField;

        private Conductance g0chField;

        private Conductance gchField;

        private Resistance rField;

        private Resistance r0Field;

        private Reactance xField;

        private Reactance x0Field;

        /// <remarks/>
        public Susceptance b0ch
        {
            get
            {
                return this.b0chField;
            }
            set
            {
                this.b0chField = value;
            }
        }

        /// <remarks/>
        public Susceptance bch
        {
            get
            {
                return this.bchField;
            }
            set
            {
                this.bchField = value;
            }
        }

        /// <remarks/>
        public Conductance g0ch
        {
            get
            {
                return this.g0chField;
            }
            set
            {
                this.g0chField = value;
            }
        }

        /// <remarks/>
        public Conductance gch
        {
            get
            {
                return this.gchField;
            }
            set
            {
                this.gchField = value;
            }
        }

        /// <remarks/>
        public Resistance r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        public Resistance r0
        {
            get
            {
                return this.r0Field;
            }
            set
            {
                this.r0Field = value;
            }
        }

        /// <remarks/>
        public Reactance x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public Reactance x0
        {
            get
            {
                return this.x0Field;
            }
            set
            {
                this.x0Field = value;
            }
        }
    }

    /// <summary>
    /// ACLineSegment extension with maximum current and capacitance
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ACLineSegmentExt : ACLineSegment
    {

        private string aliasNameField;

        private Capacitance cField;

        private Capacitance c0Field;

        private CurrentFlow maximumCurrentField;

        /// <remarks/>
        public string aliasName
        {
            get
            {
                return this.aliasNameField;
            }
            set
            {
                this.aliasNameField = value;
            }
        }

        /// <remarks/>
        public Capacitance c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        /// <remarks/>
        public Capacitance c0
        {
            get
            {
                return this.c0Field;
            }
            set
            {
                this.c0Field = value;
            }
        }

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

    /// <summary>
    /// A collection of equipment at one common system voltage forming a switchgear. The equipment typically consist of breakers, busbars, instrumentation, control, regulation and protection devices as well as assemblies of all these.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class VoltageLevel : EquipmentContainer
    {

        private Voltage highVoltageLimitField;

        private Voltage lowVoltageLimitField;

        private double baseVoltageField;

        private VoltageLevelEquipmentContainer equipmentContainer1Field;

        /// <remarks/>
        public Voltage highVoltageLimit
        {
            get
            {
                return this.highVoltageLimitField;
            }
            set
            {
                this.highVoltageLimitField = value;
            }
        }

        /// <remarks/>
        public Voltage lowVoltageLimit
        {
            get
            {
                return this.lowVoltageLimitField;
            }
            set
            {
                this.lowVoltageLimitField = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentContainer")]
        public VoltageLevelEquipmentContainer EquipmentContainer1
        {
            get
            {
                return this.equipmentContainer1Field;
            }
            set
            {
                this.equipmentContainer1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class VoltageLevelBaseVoltage
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class VoltageLevelEquipmentContainer
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }


    /// <summary>
    /// A collection of equipment for purposes other than generation or utilization, through which electric energy in bulk is passed for the purposes of switching or modifying its characteristics.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Substation : EquipmentContainer
    {

        private SubstationRegion regionField;

        /// <remarks/>
        public SubstationRegion Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class SubstationRegion
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// A collection of power system resources (within a given substation) including conducting equipment, protection relays, measurements, and telemetry.  A bay typically represents a physical grouping related to modularization of equipment.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BayExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Bay : EquipmentContainer
    {

        private BayVoltageLevel voltageLevelField;

        /// <remarks/>
        public BayVoltageLevel VoltageLevel
        {
            get
            {
                return this.voltageLevelField;
            }
            set
            {
                this.voltageLevelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class BayVoltageLevel
    {

        private string referenceTypeField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceType
        {
            get
            {
                return this.referenceTypeField;
            }
            set
            {
                this.referenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <summary>
    /// Bay extension with order attribut for automatic SLD generators
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class BayExt : Bay
    {

        private string orderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }
    }

    /// <summary>
    /// Location extension that keeps coordinates in an array instead of references to position points
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class LocationExt : Location
    {
        private Point2D[] coordinatesField;

        public Point2D[] coordinates
        {
            get
            {
                return this.coordinatesField;
            }
            set
            {
                this.coordinatesField = value;
            }
        }
    }

    public struct Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
