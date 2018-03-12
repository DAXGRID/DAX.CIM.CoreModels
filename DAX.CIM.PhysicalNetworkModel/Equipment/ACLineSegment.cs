namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A wire or combination of wires, with consistent electrical characteristics, building a single electrical system, used to carry alternating current between points in the power system.
    /// For symmetrical, transposed 3ph lines, it is sufficient to use attributes of the line segment, which describe impedances and admittances for the entire length of the segment.Additionally impedances can be computed by using length and associated per length impedances.
    /// The BaseVoltage at the two ends of ACLineSegments in a Line shall have the same BaseVoltage.nominalVoltage.However, boundary lines  may have slightly different BaseVoltage.nominalVoltages and  variation is allowed.Larger voltage difference in general requires use of an equivalent branch.</xs:documentation>
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACLineSegmentExt))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class ACLineSegment : Conductor
    {

        private Susceptance b0chField;

        private Susceptance bchField;

        private Conductance g0chField;

        private Conductance gchField;

        private Resistance rField;

        private Resistance r0Field;

        private Reactance xField;

        private Reactance x0Field;

        /// <remarks/>
        public Susceptance b0ch
        {
            get
            {
                return this.b0chField;
            }
            set
            {
                this.b0chField = value;
            }
        }

        /// <remarks/>
        public Susceptance bch
        {
            get
            {
                return this.bchField;
            }
            set
            {
                this.bchField = value;
            }
        }

        /// <remarks/>
        public Conductance g0ch
        {
            get
            {
                return this.g0chField;
            }
            set
            {
                this.g0chField = value;
            }
        }

        /// <remarks/>
        public Conductance gch
        {
            get
            {
                return this.gchField;
            }
            set
            {
                this.gchField = value;
            }
        }

        /// <remarks/>
        public Resistance r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        public Resistance r0
        {
            get
            {
                return this.r0Field;
            }
            set
            {
                this.r0Field = value;
            }
        }

        /// <remarks/>
        public Reactance x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public Reactance x0
        {
            get
            {
                return this.x0Field;
            }
            set
            {
                this.x0Field = value;
            }
        }
    }
}
