namespace DAX.CIM.PhysicalNetworkModel
{
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
}
