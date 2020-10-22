using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class ShuntCompensatorInfoExt : AssetInfo
    {
        private Voltage ratedVoltageField;

        private ReactivePower minimumReactivePowerField;

        private ReactivePower maximumReactivePowerField;
             
        private ReactivePower actualReactivePowerField;

        private ActivePower lossField;

        private float qualityFactoryField;

        private string technologyField;


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
       

        public ReactivePower minimumReactivePower
        {
            get
            {
                return this.minimumReactivePowerField;
            }
            set
            {
                this.minimumReactivePowerField = value;
            }
        }

        public ReactivePower maximumReactivePower
        {
            get
            {
                return this.maximumReactivePowerField;
            }
            set
            {
                this.maximumReactivePowerField = value;
            }
        }

        public ReactivePower actualReactivePower
        {
            get
            {
                return this.actualReactivePowerField;
            }
            set
            {
                this.actualReactivePowerField = value;
            }
        }

        public ActivePower loss
        {
            get
            {
                return this.lossField;
            }
            set
            {
                this.lossField = value;
            }
        }


        public float qualityFactory
        {
            get
            {
                return this.qualityFactoryField;
            }
            set
            {
                this.qualityFactoryField = value;
            }
        }

        public string technology
        {
            get
            {
                return this.technologyField;
            }
            set
            {
                this.technologyField = value;
            }
        }




    }

}
