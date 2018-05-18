using System;
using System.Xml.Serialization;

namespace DAX.CIM.PhysicalNetworkModel.Changes
{
    [Serializable]
    [XmlType(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public class ObjectCreation : ChangeSetMember
    {
        public IdentifiedObject Object { get; set; }        
    }
}