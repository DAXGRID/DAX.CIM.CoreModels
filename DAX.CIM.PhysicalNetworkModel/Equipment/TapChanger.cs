namespace DAX.CIM.PhysicalNetworkModel
{
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
}
