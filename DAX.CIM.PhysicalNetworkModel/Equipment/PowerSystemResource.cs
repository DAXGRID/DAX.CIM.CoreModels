using DAX.CIM.PhysicalNetworkModel.FeederInfo;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DAX.CIM.PhysicalNetworkModel
{
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeneratingUnit))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeneratingUnitExt))]
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

        #region DAX specific helper functions

        [IgnoreDataMember]
        public Asset Asset
        {
            get
            {
                if (Assets?.@ref != null)
                {
                    var asset = CimContext.Current.GetObject<Asset>(Assets.@ref);

                    if (asset.name == null)
                        asset.name = "Ukendt";

                    if (asset.lifecycle == null)
                        asset.lifecycle = new LifecycleDate() { installationDate = new System.DateTime(1900, 1, 1) };

                    return asset;
                }

                // Return emty asset to avoid problems with null pointer exceptions dotting into cim structure in dynamic linq etc.
                return new Asset() { name = "Ukendt", lifecycle = new LifecycleDate() { installationDate = new System.DateTime(1900, 1, 1) } };
            }
        }

        [IgnoreDataMember]
        public LocationExt GetLocation
        {
            get
            {
                if (Location?.@ref != null)
                {
                    var loc = CimContext.Current.GetObject<LocationExt>(Location.@ref);
                    return loc;
                }

                return null;
            }
        }

        /// <summary>
        /// Notice that this list is only populated when using the FeederInfoContext class
        /// from the DAX.CIM.PhysicalNetworkModel.FeederInfo assembly. You can use this list
        /// if you know what you're doing. But please take a look at the feeder helper functions first.
        /// </summary>
        [IgnoreDataMember]
        public List<Feeder> InternalFeeders;

        /// <summary>
        /// Gets feeders
        /// </summary>
        /// <returns></returns>
        [IgnoreDataMember]
        public List<Feeder> Feeders
        {
            get
            {
                if (InternalFeeders != null)
                    return InternalFeeders;
                else
                    return new List<Feeder>();
            }
        }

        [IgnoreDataMember]
        public bool IsFeeded
        {
            get
            {
                if (InternalFeeders != null && InternalFeeders.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        [IgnoreDataMember]
        public bool IsMultiFeeded
        {
            get
            {
                if (InternalFeeders != null && InternalFeeders.Count > 1)
                    return true;
                else
                    return false;
            }
        }

        #endregion
    }
}
