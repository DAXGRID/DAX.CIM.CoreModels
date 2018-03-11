namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A tap changer that changes the voltage ratio impacting the voltage magnitude but not the phase angle across the transformer.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class RatioTapChanger : TapChanger
    {

        private PerCent stepVoltageIncrementField;

        private RatioTapChangerTransformerEnd transformerEndField;

        /// <remarks/>
        public PerCent stepVoltageIncrement
        {
            get
            {
                return this.stepVoltageIncrementField;
            }
            set
            {
                this.stepVoltageIncrementField = value;
            }
        }

        /// <remarks/>
        public RatioTapChangerTransformerEnd TransformerEnd
        {
            get
            {
                return this.transformerEndField;
            }
            set
            {
                this.transformerEndField = value;
            }
        }
    }
}
