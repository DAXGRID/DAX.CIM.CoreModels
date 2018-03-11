namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// Product of RMS value of the voltage and the RMS value of the quadrature component of the current.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ReactivePower
    {

        private UnitMultiplier multiplierField;

        private UnitSymbol unitField;

        //private bool unitFieldSpecified;

        private double valueField;

        public ReactivePower()
        {
            this.unitField = UnitSymbol.VAr;
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
