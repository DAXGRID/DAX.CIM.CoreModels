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

        private ReactivePower maximumReactivePowerField;

        private ReactivePower minimumReactivePowerField;

        private ReactivePower actualReactivePowerField;

        private ActivePower lossField;

        private float qualityFactoryField;

        private string technologyField;


        public Voltage ratedVoltage => ratedVoltageField;
      
        public ReactivePower minimumReactivePower => minimumReactivePowerField;

        public ReactivePower maximumReactivePower => maximumReactivePower;

        public ReactivePower actualReactivePower => actualReactivePowerField;

        public ActivePower loss => lossField;

        public float qualityFactor => qualityFactoryField;

        public string technology => technologyField;

    }

}
