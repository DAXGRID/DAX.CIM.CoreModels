namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class AssetExt : Asset
    {

        private System.DateTime lastMaintenanceDateField;

        private bool lastMaintenanceDateFieldSpecified;

        /// <remarks/>
        public System.DateTime lastMaintenanceDate
        {
            get
            {
                return this.lastMaintenanceDateField;
            }
            set
            {
                this.lastMaintenanceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lastMaintenanceDateSpecified
        {
            get
            {
                return this.lastMaintenanceDateFieldSpecified;
            }
            set
            {
                this.lastMaintenanceDateFieldSpecified = value;
            }
        }
    }
}
