using DAX.CIM.PhysicalNetworkModel.FeederInfo;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// A collection of equipment for purposes other than generation or utilization, through which electric energy in bulk is passed for the purposes of switching or modifying its characteristics.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class Substation : EquipmentContainer
    {

        private SubstationRegion regionField;

        /// <remarks/>
        public SubstationRegion Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        #region DAX specific helper functions

        /// <summary>
        /// Notice that this list is only populated when using the FeederInfoContext class
        /// from the DAX.CIM.PhysicalNetworkModel.FeederInfo assembly. You can use this list
        /// if you know what you're doing. But please take a look at the feeder helper functions first.
        /// </summary>
        [IgnoreDataMember]
        public List<ConnectionPoint> ConnectionPoints;

        /// <summary>
        /// Gets outgoing feeders - that is the circuits that the individual bays of the substation feeds.
        /// </summary>
        /// <returns></returns>
        [IgnoreDataMember]
        public List<Feeder> OutgoingFeeders
        {
            get
            {

                List<Feeder> result = new List<Feeder>();

                if (ConnectionPoints != null)
                {
                    foreach (var cp in ConnectionPoints)
                    {
                        foreach (var feeder in cp.Feeders)
                        {
                            result.Add(feeder);
                        }
                    }
                }

                return result;
            }
        }

        #endregion
    }
}
