namespace DAX.CIM.PhysicalNetworkModel
{
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
}
