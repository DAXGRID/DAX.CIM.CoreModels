namespace DAX.CIM.PhysicalNetworkModel
{
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


        private Resistance neutral_rField;

        private Resistance neutral_r0Field;

        private Reactance neutral_xField;

        private Reactance neutral_x0Field;

        /// <remarks/>
        public Resistance neutral_r
        {
            get
            {
                return this.neutral_rField;
            }
            set
            {
                this.neutral_rField = value;
            }
        }

        /// <remarks/>
        public Resistance neutral_r0
        {
            get
            {
                return this.neutral_r0Field;
            }
            set
            {
                this.neutral_r0Field = value;
            }
        }

        /// <remarks/>
        public Reactance neutral_x
        {
            get
            {
                return this.neutral_xField;
            }
            set
            {
                this.neutral_xField = value;
            }
        }

        /// <remarks/>
        public Reactance neutral_x0
        {
            get
            {
                return this.neutral_x0Field;
            }
            set
            {
                this.neutral_x0Field = value;
            }
        }




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
}
