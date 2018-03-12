namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class TapSchedule
    {

        private TapScheduleTapChanger tapChangerField;

        /// <remarks/>
        public TapScheduleTapChanger TapChanger
        {
            get
            {
                return this.tapChangerField;
            }
            set
            {
                this.tapChangerField = value;
            }
        }
    }
}
