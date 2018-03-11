namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// PowerTransformerEnd extension containing losses, uk and exicingCurrentZero
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PowerTransformerEndExt : PowerTransformerEnd
    {

        private PerCent excitingCurrentZeroField;

        private KiloActivePower lossField;

        private KiloActivePower lossZeroField;

        private Voltage nominalVoltageField;

        private PerCent ukField;

        /// <remarks/>
        public PerCent excitingCurrentZero
        {
            get
            {
                return this.excitingCurrentZeroField;
            }
            set
            {
                this.excitingCurrentZeroField = value;
            }
        }

        /// <remarks/>
        public KiloActivePower loss
        {
            get
            {
                return this.lossField;
            }
            set
            {
                this.lossField = value;
            }
        }

        /// <remarks/>
        public KiloActivePower lossZero
        {
            get
            {
                return this.lossZeroField;
            }
            set
            {
                this.lossZeroField = value;
            }
        }

        /// <remarks/>
        public Voltage nominalVoltage
        {
            get
            {
                return this.nominalVoltageField;
            }
            set
            {
                this.nominalVoltageField = value;
            }
        }

        /// <remarks/>
        public PerCent uk
        {
            get
            {
                return this.ukField;
            }
            set
            {
                this.ukField = value;
            }
        }
    }
}
