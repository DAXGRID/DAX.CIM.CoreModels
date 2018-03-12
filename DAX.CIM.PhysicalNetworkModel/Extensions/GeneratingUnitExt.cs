namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class GeneratingUnitExt : GeneratingUnit
    {

        private string gSRMField;

        private ApparentPower ratedSField;

        private string meteringPointIdField;

        private GeneratingUnitKind typeField;

        private GeneratingUnitExtEnergyConsumer energyConsumerField;

        /// <remarks/>
        public string GSRM
        {
            get
            {
                return this.gSRMField;
            }
            set
            {
                this.gSRMField = value;
            }
        }
        
        /// <remarks/>
        public string meteringPointId
        {
            get
            {
                return this.meteringPointIdField;
            }
            set
            {
                this.meteringPointIdField = value;
            }
        }

        /// <remarks/>
        public GeneratingUnitKind type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }


        /// <summary>
        /// Apparent power rating for the generating unit as a whole. The attribute shall have a positive value.
        /// </summary>
        public ApparentPower ratedS
        {
            get
            {
                return this.ratedSField;
            }
            set
            {
                this.ratedSField = value;
            }
        }

        /// <remarks/>
        public GeneratingUnitExtEnergyConsumer EnergyConsumer
        {
            get
            {
                return this.energyConsumerField;
            }
            set
            {
                this.energyConsumerField = value;
            }
        }
    }
}
