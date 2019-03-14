using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public class WireInfoExt : WireInfo
    {

        private Susceptance b0chField;

        private Susceptance bchField;

        private decimal conductorCrossSectionalAreaField;

        private bool conductorCrossSectionalAreaFieldSpecified;

        private Conductance g0chField;

        private Conductance gchField;

        private Resistance rField;

        private Resistance r0Field;

        private Voltage ratedVoltageField;

        private CurrentFlow ratedWithstandCurrent1secField;

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
        public decimal conductorCrossSectionalArea
        {
            get
            {
                return this.conductorCrossSectionalAreaField;
            }
            set
            {
                this.conductorCrossSectionalAreaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool conductorCrossSectionalAreaSpecified
        {
            get
            {
                return this.conductorCrossSectionalAreaFieldSpecified;
            }
            set
            {
                this.conductorCrossSectionalAreaFieldSpecified = value;
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
        public Voltage ratedVoltage
        {
            get
            {
                return this.ratedVoltageField;
            }
            set
            {
                this.ratedVoltageField = value;
            }
        }

        /// <remarks/>
        public CurrentFlow ratedWithstandCurrent1sec
        {
            get
            {
                return this.ratedWithstandCurrent1secField;
            }
            set
            {
                this.ratedWithstandCurrent1secField = value;
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
