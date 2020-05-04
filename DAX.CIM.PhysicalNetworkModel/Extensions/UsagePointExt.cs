namespace DAX.CIM.PhysicalNetworkModel
{
    public partial class UsagePointExt : UsagePoint
    {

        private string customerCategoryCodeField;

        private string customerCategoryTextField;

        private string installationIdField;

        private string meterIdField;

        private string meteringPointIdField;

        private ApparentPower yearlyUsageField;

        /// <remarks/>
        public string customerCategoryCode
        {
            get
            {
                return this.customerCategoryCodeField;
            }
            set
            {
                this.customerCategoryCodeField = value;
            }
        }

        /// <remarks/>
        public string customerCategoryText
        {
            get
            {
                return this.customerCategoryTextField;
            }
            set
            {
                this.customerCategoryTextField = value;
            }
        }

        /// <remarks/>
        public string installationId
        {
            get
            {
                return this.installationIdField;
            }
            set
            {
                this.installationIdField = value;
            }
        }

        /// <remarks/>
        public string meterId
        {
            get
            {
                return this.meterIdField;
            }
            set
            {
                this.meterIdField = value;
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
        public ApparentPower yearlyUsage
        {
            get
            {
                return this.yearlyUsageField;
            }
            set
            {
                this.yearlyUsageField = value;
            }
        }
    }
}
