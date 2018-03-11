namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class GeneratingUnitExt : GeneratingUnit
    {

        private GeneratingUnitKind typeField;

        private GeneratingUnitExtEnergyConsumer energyConsumerField;

        private ApparentPower ratedSField;

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

        /// <summary>
        /// Nameplate apparent power rating for the unit. The attribute shall have a positive value.
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
    }
}
