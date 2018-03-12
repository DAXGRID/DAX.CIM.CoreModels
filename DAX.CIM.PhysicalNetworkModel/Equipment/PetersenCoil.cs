namespace DAX.CIM.PhysicalNetworkModel
{
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
}
