namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// FaultIndicator extension containing resetKind attribute.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class FaultIndicatorExt : FaultIndicator
    {

        private FaultIndicatorResetKind resetKindField;

        private bool resetKindFieldSpecified;

        /// <remarks/>
        public FaultIndicatorResetKind resetKind
        {
            get
            {
                return this.resetKindField;
            }
            set
            {
                this.resetKindField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resetKindSpecified
        {
            get
            {
                return this.resetKindFieldSpecified;
            }
            set
            {
                this.resetKindFieldSpecified = value;
            }
        }
    }
}
