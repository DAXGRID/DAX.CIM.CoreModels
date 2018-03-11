namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// The place, scene, or point of something where someone or something has been, is, and/or will be at a given moment in time. It can be defined with one or more postition points (coordinates) in a given coordinate system.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationExt))]
    public partial class Location : IdentifiedObject
    {
        private string directionField;

        private StreetAddress mainAddressField;

        private TelephoneNumber phone1Field;

        private TelephoneNumber phone2Field;

        private LocationCoordinateSystem coordinateSystemField;

        /// <remarks/>
        public string direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }

        /// <remarks/>
        public StreetAddress mainAddress
        {
            get
            {
                return this.mainAddressField;
            }
            set
            {
                this.mainAddressField = value;
            }
        }

        /// <remarks/>
        public TelephoneNumber phone1
        {
            get
            {
                return this.phone1Field;
            }
            set
            {
                this.phone1Field = value;
            }
        }

        /// <remarks/>
        public TelephoneNumber phone2
        {
            get
            {
                return this.phone2Field;
            }
            set
            {
                this.phone2Field = value;
            }
        }

        /// <remarks/>
        public LocationCoordinateSystem CoordinateSystem
        {
            get
            {
                return this.coordinateSystemField;
            }
            set
            {
                this.coordinateSystemField = value;
            }
        }
    }
}
