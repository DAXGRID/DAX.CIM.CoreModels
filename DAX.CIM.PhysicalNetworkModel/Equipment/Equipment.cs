using DAX.CIM.PhysicalNetworkModel.FeederInfo;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DAX.CIM.PhysicalNetworkModel
{
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

        [IgnoreDataMember]
        /// <summary>
        ///  Returns a unique name at by traversing the equipment hierarchy
        /// </summary>
        public string PathName
        {
            get {
                List<IdentifiedObject> visitedEquipments = new List<IdentifiedObject>();

                string retName = "";
                return NameTraverse(visitedEquipments, retName);
            }
        }

        internal string NameTraverse(List <IdentifiedObject> visitedEquipments, string name)
        {
            var context = CimContext.GetCurrent();

            if (!visitedEquipments.Contains(this))
            {
                visitedEquipments.Add(this);

                if (this != null)
                    name = this.name;
                else
                    name = "NULL";

                if (this is LoadBreakSwitch)
                    name = "LAST " + name;
                else if (this is Breaker)
                    name = "EFFEKT " + name;
                else if (this is Disconnector)
                    name = "ADSK " + name;
                else if (this is Fuse)
                    name = "SIK " + name;
                else if (this is BusbarSection)
                    name = "SKINNE " + name;
                else if (this is ACLineSegment)
                    name = "ACLS " + name;
                else if (this is ConnectivityNode)
                    name = "CN " + name;

                if (EquipmentContainer != null && EquipmentContainer.@ref != null)
                {
                    var ec = context.GetObject<EquipmentContainer>(EquipmentContainer.@ref);
                    return (ec.NameTraverse(visitedEquipments, name));
                }
                else
                    return name;
            }
            else
            {
                return name;
            }
        }


        public override string ToString()
        {
            return this.GetType().Name + ": " + PathName + " PSRType=" + this.PSRType + " mRID=" + mRID;
        }
    }

  
}
