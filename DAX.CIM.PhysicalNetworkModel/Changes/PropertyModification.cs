using System;
using System.Xml.Serialization;

namespace DAX.CIM.PhysicalNetworkModel.Changes
{
    [Serializable]
    [XmlType(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public class PropertyModification
    {
        public string Name { get; set; }
        public bool IsReference { get; set; }
        public string Value { get; set; }
        public UnitSymbol? Unit { get; set; }
        public UnitMultiplier? Multiplier { get; set; }
    }
}