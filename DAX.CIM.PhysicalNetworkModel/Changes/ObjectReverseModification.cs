using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DAX.CIM.PhysicalNetworkModel.Changes
{
    [Serializable]
    [XmlType(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public class ObjectReverseModification : ChangeSetMember
    {
        public Dictionary<string, object> Properties { get; set; }
    }
}