namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Imaginary part of admittance.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Susceptance
    {

        private UnitMultiplier multiplierField;

        //private bool multiplierFieldSpecified;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public Susceptance()
        {
            this.unitField = UnitSymbol.S;
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
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool multiplierSpecified
        //{
        //    get
        //    {
        //        return this.multiplierFieldSpecified;
        //    }
        //    set
        //    {
        //        this.multiplierFieldSpecified = value;
        //    }
        //}

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

        ///// <remarks/>
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
