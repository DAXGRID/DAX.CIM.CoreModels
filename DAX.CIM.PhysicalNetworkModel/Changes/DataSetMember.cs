using System;
using System.Xml.Serialization;

namespace DAX.CIM.PhysicalNetworkModel.Changes
{
    [Serializable]
    [XmlType(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public class DataSetMember : IdentifiedObject
    {
        public TargetObject TargetObject { get; set; }

        public ChangeSetMember Change { get; set; }

        /// <summary>
        /// Only relevant if <see cref="Change"/> is <see cref="ObjectModification"/> or <see cref="ObjectDeletion"/>
        /// </summary>
        public ObjectReverseModification ReverseChange { get; set; }
    }
}