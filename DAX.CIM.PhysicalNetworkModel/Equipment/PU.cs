namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Per Unit - a positive or negative value referred to a defined base. Values typically range from -10 to +10.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PU
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public PU()
        {
            this.unitField = UnitSymbol.none;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitMultiplier multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UnitSymbol unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool unitSpecified
        //{
        //    get
        //    {
        //        return this.unitFieldSpecified;
        //    }
        //    set
        //    {
        //        this.unitFieldSpecified = value;
        //    }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
