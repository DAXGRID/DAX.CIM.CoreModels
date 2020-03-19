namespace DAX.CIM.PhysicalNetworkModel
{
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

        private bool groundedField;

        private string connectionKindField;

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

        public string connectionKind
        {
            get
            {
                return this.connectionKindField;
            }
            set
            {
                this.connectionKindField = value;
            }
        }

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
}
