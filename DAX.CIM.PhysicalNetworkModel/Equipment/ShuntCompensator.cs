namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A shunt capacitor or reactor or switchable bank of shunt capacitors or reactors. A section of a shunt compensator is an individual capacitor or reactor.  A negative value for reactivePerSection indicates that the compensator is a reactor. ShuntCompensator is a single terminal device.  Ground is implied.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonlinearShuntCompensator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearShuntCompensator))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public abstract partial class ShuntCompensator : RegulatingCondEq
    {

        private Seconds aVRDelayField;

        private bool groundedField;

        private bool groundedFieldSpecified;

        private string maximumSectionsField;

        private Voltage nomUField;

        private string normalSectionsField;

        private string switchOnCountField;

        private System.DateTime switchOnDateField;

        private bool switchOnDateFieldSpecified;

        private VoltagePerReactivePower voltageSensitivityField;

        /// <remarks/>
        public Seconds aVRDelay
        {
            get
            {
                return this.aVRDelayField;
            }
            set
            {
                this.aVRDelayField = value;
            }
        }

        /// <remarks/>
        public bool grounded
        {
            get
            {
                return this.groundedField;
            }
            set
            {
                this.groundedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool groundedSpecified
        {
            get
            {
                return this.groundedFieldSpecified;
            }
            set
            {
                this.groundedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string maximumSections
        {
            get
            {
                return this.maximumSectionsField;
            }
            set
            {
                this.maximumSectionsField = value;
            }
        }

        /// <remarks/>
        public Voltage nomU
        {
            get
            {
                return this.nomUField;
            }
            set
            {
                this.nomUField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string normalSections
        {
            get
            {
                return this.normalSectionsField;
            }
            set
            {
                this.normalSectionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string switchOnCount
        {
            get
            {
                return this.switchOnCountField;
            }
            set
            {
                this.switchOnCountField = value;
            }
        }

        /// <remarks/>
        public System.DateTime switchOnDate
        {
            get
            {
                return this.switchOnDateField;
            }
            set
            {
                this.switchOnDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool switchOnDateSpecified
        {
            get
            {
                return this.switchOnDateFieldSpecified;
            }
            set
            {
                this.switchOnDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        public VoltagePerReactivePower voltageSensitivity
        {
            get
            {
                return this.voltageSensitivityField;
            }
            set
            {
                this.voltageSensitivityField = value;
            }
        }
    }
}
