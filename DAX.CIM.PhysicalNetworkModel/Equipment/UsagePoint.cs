namespace DAX.CIM.PhysicalNetworkModel
{
    /// <summary>
    /// CIM description:
    /// Logical or physical point in the network to which readings or events may be attributed.Used at the place where a physical or virtual meter may be located; however, it is not required that a meter be present.
    /// Danish stuff:
    /// Represents what in daily words is referred to as installation. The EAN(18 digit installationsnumber should be put in the name attribute).
    /// Repræsenter en installation/aftagepunkt, hvor der typisk sidder en maaler. EAN-/Aftagenummer skrives i navn. Bemaerk at der en 1-mange relation mellem ConductionEquipment og UsagePoint, som fx kan udnyttes i etageejendomme, hvor der kan vaere mange maalere tilknyttet en stikledning.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public partial class UsagePoint : IdentifiedObject
    {

        private UsagePointEquipments equipmentsField;

        /// <remarks/>
        public UsagePointEquipments Equipments
        {
            get
            {
                return this.equipmentsField;
            }
            set
            {
                this.equipmentsField = value;
            }
        }
    }
}
