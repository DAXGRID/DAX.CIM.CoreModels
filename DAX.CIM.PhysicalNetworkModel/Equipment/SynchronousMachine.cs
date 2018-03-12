namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// An electromechanical device that operates with shaft rotating synchronously with the network. It is a single machine operating either as a generator or synchronous condenser or pump.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class SynchronousMachine : RotatingMachine
    {

        private CurrentFlow ikkField;

        private ReactivePower maxQField;

        private ReactivePower minQField;

        private double muField;

        private bool muFieldSpecified;

        private PerCent qPercentField;

        private Resistance rField;

        private PU r0Field;

        private PU r2Field;

        private string referencePriorityField;

        private PU satDirectSubtransXField;

        private ShortCircuitRotorKind shortCircuitRotorTypeField;

        private bool shortCircuitRotorTypeFieldSpecified;

        private SynchronousMachineKind typeField;

        private PerCent voltageRegulationRangeField;

        private PU x0Field;

        private PU x2Field;

        private SynchronousMachineInitialReactiveCapabilityCurve initialReactiveCapabilityCurveField;

        /// <remarks/>
        public CurrentFlow ikk
        {
            get
            {
                return this.ikkField;
            }
            set
            {
                this.ikkField = value;
            }
        }

        /// <remarks/>
        public ReactivePower maxQ
        {
            get
            {
                return this.maxQField;
            }
            set
            {
                this.maxQField = value;
            }
        }

        /// <remarks/>
        public ReactivePower minQ
        {
            get
            {
                return this.minQField;
            }
            set
            {
                this.minQField = value;
            }
        }

        /// <remarks/>
        public double mu
        {
            get
            {
                return this.muField;
            }
            set
            {
                this.muField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool muSpecified
        {
            get
            {
                return this.muFieldSpecified;
            }
            set
            {
                this.muFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PerCent qPercent
        {
            get
            {
                return this.qPercentField;
            }
            set
            {
                this.qPercentField = value;
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
        public PU r0
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
        public PU r2
        {
            get
            {
                return this.r2Field;
            }
            set
            {
                this.r2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string referencePriority
        {
            get
            {
                return this.referencePriorityField;
            }
            set
            {
                this.referencePriorityField = value;
            }
        }

        /// <remarks/>
        public PU satDirectSubtransX
        {
            get
            {
                return this.satDirectSubtransXField;
            }
            set
            {
                this.satDirectSubtransXField = value;
            }
        }

        /// <remarks/>
        public ShortCircuitRotorKind shortCircuitRotorType
        {
            get
            {
                return this.shortCircuitRotorTypeField;
            }
            set
            {
                this.shortCircuitRotorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shortCircuitRotorTypeSpecified
        {
            get
            {
                return this.shortCircuitRotorTypeFieldSpecified;
            }
            set
            {
                this.shortCircuitRotorTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SynchronousMachineKind type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public PerCent voltageRegulationRange
        {
            get
            {
                return this.voltageRegulationRangeField;
            }
            set
            {
                this.voltageRegulationRangeField = value;
            }
        }

        /// <remarks/>
        public PU x0
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
        public PU x2
        {
            get
            {
                return this.x2Field;
            }
            set
            {
                this.x2Field = value;
            }
        }

        /// <remarks/>
        public SynchronousMachineInitialReactiveCapabilityCurve InitialReactiveCapabilityCurve
        {
            get
            {
                return this.initialReactiveCapabilityCurveField;
            }
            set
            {
                this.initialReactiveCapabilityCurveField = value;
            }
        }
    }
}
