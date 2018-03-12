namespace DAX.CIM.PhysicalNetworkModel
{
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
}
