using System;
using System.Xml.Serialization;

namespace DAX.CIM.PhysicalNetworkModel.Changes
{
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public class TargetObject
    {
        [XmlAttribute]
        public string referenceType { get; set; }

        [XmlAttribute]
        public string @ref { get; set; }
    }
}