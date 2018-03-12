namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Location extension that keeps coordinates in an array instead of references to position points
    /// </summary>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class LocationExt : Location
    {
        private Point2D[] coordinatesField;

        public Point2D[] coordinates
        {
            get
            {
                return this.coordinatesField;
            }
            set
            {
                this.coordinatesField = value;
            }
        }
    }
}
