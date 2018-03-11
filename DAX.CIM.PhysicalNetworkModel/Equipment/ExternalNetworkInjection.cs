namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// This class represents external network and it is used for IEC 60909 calculations.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ExternalNetworkInjection : RegulatingCondEq
    {

        private ActivePowerPerFrequency governorSCDField;

        private bool ikSecondField;

        private bool ikSecondFieldSpecified;

        private CurrentFlow maxInitialSymShCCurrentField;

        private ActivePower maxPField;

        private ReactivePower maxQField;

        private double maxR0ToX0RatioField;

        private double maxR1ToX1RatioField;

        private double maxZ0ToZ1RatioField;

        private CurrentFlow minInitialSymShCCurrentField;

        private ActivePower minPField;

        private ReactivePower minQField;

        private double minR0ToX0RatioField;

        private double minR1ToX1RatioField;

        private double minZ0ToZ1RatioField;

        private PU voltageFactorField;

        /// <remarks/>
        public ActivePowerPerFrequency governorSCD
        {
            get
            {
                return this.governorSCDField;
            }
            set
            {
                this.governorSCDField = value;
            }
        }

        /// <remarks/>
        public bool ikSecond
        {
            get
            {
                return this.ikSecondField;
            }
            set
            {
                this.ikSecondField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ikSecondSpecified
        {
            get
            {
                return this.ikSecondFieldSpecified;
            }
            set
            {
                this.ikSecondFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CurrentFlow maxInitialSymShCCurrent
        {
            get
            {
                return this.maxInitialSymShCCurrentField;
            }
            set
            {
                this.maxInitialSymShCCurrentField = value;
            }
        }

        /// <remarks/>
        public ActivePower maxP
        {
            get
            {
                return this.maxPField;
            }
            set
            {
                this.maxPField = value;
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
        public double maxR0ToX0Ratio
        {
            get
            {
                return this.maxR0ToX0RatioField;
            }
            set
            {
                this.maxR0ToX0RatioField = value;
            }
        }

        /// <remarks/>
        public double maxR1ToX1Ratio
        {
            get
            {
                return this.maxR1ToX1RatioField;
            }
            set
            {
                this.maxR1ToX1RatioField = value;
            }
        }

        /// <remarks/>
        public double maxZ0ToZ1Ratio
        {
            get
            {
                return this.maxZ0ToZ1RatioField;
            }
            set
            {
                this.maxZ0ToZ1RatioField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow minInitialSymShCCurrent
        {
            get
            {
                return this.minInitialSymShCCurrentField;
            }
            set
            {
                this.minInitialSymShCCurrentField = value;
            }
        }

        /// <remarks/>
        public ActivePower minP
        {
            get
            {
                return this.minPField;
            }
            set
            {
                this.minPField = value;
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
        public double minR0ToX0Ratio
        {
            get
            {
                return this.minR0ToX0RatioField;
            }
            set
            {
                this.minR0ToX0RatioField = value;
            }
        }

        /// <remarks/>
        public double minR1ToX1Ratio
        {
            get
            {
                return this.minR1ToX1RatioField;
            }
            set
            {
                this.minR1ToX1RatioField = value;
            }
        }

        /// <remarks/>
        public double minZ0ToZ1Ratio
        {
            get
            {
                return this.minZ0ToZ1RatioField;
            }
            set
            {
                this.minZ0ToZ1RatioField = value;
            }
        }

        /// <remarks/>
        public PU voltageFactor
        {
            get
            {
                return this.voltageFactorField;
            }
            set
            {
                this.voltageFactorField = value;
            }
        }
    }
}
