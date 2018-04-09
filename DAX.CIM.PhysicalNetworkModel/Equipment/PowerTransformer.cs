using System.Runtime.Serialization;

namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// An electrical device consisting of  two or more coupled windings, with or without a magnetic core, for introducing mutual coupling between electric circuits. Transformers can be used to control voltage and phase shift (active power flow).
    /// A power transformer may be composed of separate transformer tanks that need not be identical.
    /// A power transformer can be modeled with or without tanks and is intended for use in both balanced and unbalanced representations.A power transformer typically has two terminals, but may have one(grounding), three or more terminals.
    /// The inherited association ConductingEquipment.BaseVoltage should not be used.The association from TransformerEnd to BaseVoltage should be used instead.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class PowerTransformer : ConductingEquipment
    {
        [IgnoreDataMember]
        public int EnergyConsumerCount { get; set; }
    }
}
