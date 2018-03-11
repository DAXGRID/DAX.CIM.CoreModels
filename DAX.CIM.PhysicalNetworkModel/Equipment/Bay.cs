namespace DAX.CIM.PhysicalNetworkModel
{
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
}
