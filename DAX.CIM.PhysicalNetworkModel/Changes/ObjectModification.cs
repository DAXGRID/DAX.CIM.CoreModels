using System;
using System.Xml.Serialization;

namespace DAX.CIM.PhysicalNetworkModel.Changes
{
    [Serializable]
    [XmlType(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public class ObjectModification : ChangeSetMember
    {
        public PropertyModification[] Modifications { get; set; }
    }
}