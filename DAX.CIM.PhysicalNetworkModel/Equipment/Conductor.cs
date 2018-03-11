namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Combination of conducting material with consistent electrical characteristics, building a single electrical system, used to carry current between points in the power system.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACLineSegment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACLineSegmentExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class Conductor : ConductingEquipment
    {

        private Length lengthField;

        /// <remarks/>
        public Length length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }
    }
}
