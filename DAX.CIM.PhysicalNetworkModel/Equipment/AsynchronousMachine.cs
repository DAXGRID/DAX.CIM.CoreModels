namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A rotating machine whose shaft rotates asynchronously with the electrical field. Also known as an induction machine with no external connection to the rotor windings, e.g squirrel-cage induction machine.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class AsynchronousMachine : RotatingMachine
    {

        private bool converterFedDriveField;

        private PerCent efficiencyField;

        private double iaIrRatioField;

        private Frequency nominalFrequencyField;

        private RotationSpeed nominalSpeedField;

        private string polePairNumberField;

        private ActivePower ratedMechanicalPowerField;

        private bool reversibleField;

        private double rxLockedRotorRatioField;

        private bool rxLockedRotorRatioFieldSpecified;

        /// <remarks/>
        public bool converterFedDrive
        {
            get
            {
                return this.converterFedDriveField;
            }
            set
            {
                this.converterFedDriveField = value;
            }
        }

        /// <remarks/>
        public PerCent efficiency
        {
            get
            {
                return this.efficiencyField;
            }
            set
            {
                this.efficiencyField = value;
            }
        }

        /// <remarks/>
        public double iaIrRatio
        {
            get
            {
                return this.iaIrRatioField;
            }
            set
            {
                this.iaIrRatioField = value;
            }
        }

        /// <remarks/>
        public Frequency nominalFrequency
        {
            get
            {
                return this.nominalFrequencyField;
            }
            set
            {
                this.nominalFrequencyField = value;
            }
        }

        /// <remarks/>
        public RotationSpeed nominalSpeed
        {
            get
            {
                return this.nominalSpeedField;
            }
            set
            {
                this.nominalSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string polePairNumber
        {
            get
            {
                return this.polePairNumberField;
            }
            set
            {
                this.polePairNumberField = value;
            }
        }

        /// <remarks/>
        public ActivePower ratedMechanicalPower
        {
            get
            {
                return this.ratedMechanicalPowerField;
            }
            set
            {
                this.ratedMechanicalPowerField = value;
            }
        }

        /// <remarks/>
        public bool reversible
        {
            get
            {
                return this.reversibleField;
            }
            set
            {
                this.reversibleField = value;
            }
        }

        /// <remarks/>
        public double rxLockedRotorRatio
        {
            get
            {
                return this.rxLockedRotorRatioField;
            }
            set
            {
                this.rxLockedRotorRatioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rxLockedRotorRatioSpecified
        {
            get
            {
                return this.rxLockedRotorRatioFieldSpecified;
            }
            set
            {
                this.rxLockedRotorRatioFieldSpecified = value;
            }
        }
    }
}
