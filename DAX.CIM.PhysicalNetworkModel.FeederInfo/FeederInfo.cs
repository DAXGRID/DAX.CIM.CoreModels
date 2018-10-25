using DAX.CIM.PhysicalNetworkModel.Traversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.FeederInfo
{
    /// <summary>
    /// Fat class to hold simplified/flatten-out feeder information that many non-electrical external systems are hungry for.
    /// </summary>
    public class FeederInfo
    {
        public Guid EquipmentMRID { get; set; }
        public String EquipmentName { get; set; }
        public String EquipmentClass { get; set; }
        public String EquipmentPSRType { get; set; }
        public int VoltageLevel { get; set; }
        public int SeqNo { get; set; }
        public bool Nofeed { get; set; }
        public bool Multifeed { get; set; }
        public Guid CustomerFeederCableMRID { get; set; }
        public String CustomerFeederCableName { get; set; }
        public Guid CableBoxMRID { get; set; }
        public String CableBoxName { get; set; }
        public Guid CableBoxBusbarMRID { get; set; }
        public Guid SecondarySubstationMRID { get; set; }
        public String SecondarySubstationName { get; set; }
        public Guid SecondarySubstationBayMRID { get; set; }
        public String SecondarySubstationBayName { get; set; }
        public Guid SecondarySubstationTransformerMRID { get; set; }
        public String SecondarySubstationTransformerName { get; set; }
        public Guid PrimarySubstationMRID { get; set; }
        public String PrimarySubstationName { get; set; }
        public Guid PrimarySubstationBayMRID { get; set; }
        public String PrimarySubstationBayName { get; set; }
        public Guid PrimarySubstationTransformerMRID { get; set; }
        public String PrimarySubstationTransformerName { get; set; }
        public Guid NetworkInjectionMRID { get; set; }
        public String NetworkInjectionName { get; set; }

        /// <summary>
        /// Creates one or more feeder ínfo objects for a given PNM equipment object.
        /// If the PNM object is not feeded, a feeder info object with NoFeed = true is returned.
        /// If the PNM object is multi feeded, a feeder into object with MultiFeed = true is returned for each source feeding the object.
        /// </summary>
        /// <param name="cimContext"></param>
        /// <param name="eq"></param>
        /// <returns></returns>
        public static List<FeederInfo> CreateFeederInfosFromEquipment(FeederInfoContext feederContext, Equipment eq)
        {
            int seqNo = 1;

            List<FeederInfo> feederInfosToAdd = new List<FeederInfo>();

            /////////////////////////////////////
            // MV feeders
            foreach (var mspFeeder in eq.Feeders.Where(f => f.FeederType == FeederType.SecondarySubstation))
            {
                bool hspFeedersFound = false;

                // Check if power transformer has hsp feeders
                if (mspFeeder.ConnectionPoint.PowerTransformer != null)
                {
                    var hspFeeders = feederContext.GeConductingEquipmentFeeders(mspFeeder.ConnectionPoint.PowerTransformer);

                    foreach (var hspFeeder in hspFeeders)
                    {
                        FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, eq, eq.Feeders);
                        seqNo++;

                        AddMspFeederInfo(mspFeeder, feederInfo);
                        AddHspFeederInfo(hspFeeder, feederInfo);

                        feederInfosToAdd.Add(feederInfo);
                        hspFeedersFound = true;
                    }
                }

                // If no hsp feeders just add msp feeder info only
                if (!hspFeedersFound)
                {
                    FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, eq, eq.Feeders);
                    seqNo++;

                    AddMspFeederInfo(mspFeeder, feederInfo);

                    feederInfosToAdd.Add(feederInfo);
                }
            }

            /////////////////////////////////////
            // HV feeders
            foreach (var hspFeeder in eq.Feeders.Where(f => f.FeederType == FeederType.PrimarySubstation))
            {
                FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, eq, eq.Feeders);
                seqNo++;

                AddHspFeederInfo(hspFeeder, feederInfo);
                feederInfosToAdd.Add(feederInfo);
            }


            /////////////////////////////////////
            // INJECTION feeders
            foreach (var injectionFeeder in eq.Feeders.Where(f => f.FeederType == FeederType.NetworkInjection))
            {
                FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, eq, eq.Feeders);
                if (injectionFeeder.ConductingEquipment != null)
                    feederInfo.NetworkInjectionMRID = Guid.Parse(injectionFeeder.ConductingEquipment.mRID);

                seqNo++;


                feederInfosToAdd.Add(feederInfo);
            }

            // If seqNo still 1, then we found no feeders
            if (seqNo == 1)
            {
                // Add feeder info telling that we have no feed
                FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, eq, eq.Feeders);
                feederInfo.Multifeed = false;
                feederInfo.Nofeed = true;
                feederInfosToAdd.Add(feederInfo);
            }

            // If seqNo > 2 the components is multi feeded
            if (seqNo > 2)
            {
                foreach (var f in feederInfosToAdd)
                {
                    f.Multifeed = true;
                }
            }

            return feederInfosToAdd;
        }

        static void AddHspFeederInfo(Feeder hspFeeder, FeederInfo feederInfo)
        {
            if (hspFeeder.ConnectionPoint.Substation != null)
            {
                feederInfo.PrimarySubstationMRID = Guid.Parse(hspFeeder.ConnectionPoint.Substation.mRID);
                feederInfo.PrimarySubstationName = hspFeeder.ConnectionPoint.Substation.name;
            }

            if (hspFeeder.ConnectionPoint.Bay != null)
            {
                feederInfo.PrimarySubstationBayMRID = Guid.Parse(hspFeeder.ConnectionPoint.Bay.mRID);
                feederInfo.PrimarySubstationBayName = hspFeeder.ConnectionPoint.Bay.name;
            }

            if (hspFeeder.ConnectionPoint.PowerTransformer != null)
            {
                feederInfo.PrimarySubstationTransformerMRID = Guid.Parse(hspFeeder.ConnectionPoint.PowerTransformer.mRID);
                feederInfo.PrimarySubstationTransformerName = hspFeeder.ConnectionPoint.PowerTransformer.name;

                if (hspFeeder.ConnectionPoint.PowerTransformer.Feeders.Count == 1 && hspFeeder.ConnectionPoint.PowerTransformer.Feeders.Count(f => f.FeederType == FeederType.NetworkInjection) == 1)
                {
                    if (hspFeeder.ConnectionPoint.PowerTransformer.Feeders[0].ConductingEquipment != null)
                    {
                        feederInfo.NetworkInjectionMRID = Guid.Parse(hspFeeder.ConnectionPoint.PowerTransformer.Feeders[0].ConductingEquipment.mRID);
                        feederInfo.NetworkInjectionName = hspFeeder.ConnectionPoint.PowerTransformer.Feeders[0].ConductingEquipment.name;
                    }
                }
            }
        }

        static void AddMspFeederInfo(Feeder mspFeeder, FeederInfo feederInfo)
        {
            if (mspFeeder.ConnectionPoint.Substation != null)
            {
                feederInfo.SecondarySubstationMRID = Guid.Parse(mspFeeder.ConnectionPoint.Substation.mRID);
                feederInfo.SecondarySubstationName = mspFeeder.ConnectionPoint.Substation.name;
            }

            if (mspFeeder.ConnectionPoint.Bay != null)
            {
                feederInfo.SecondarySubstationBayMRID = Guid.Parse(mspFeeder.ConnectionPoint.Bay.mRID);
                feederInfo.SecondarySubstationBayName = mspFeeder.ConnectionPoint.Bay.name;
            }

            if (mspFeeder.ConnectionPoint.PowerTransformer != null)
            {
                feederInfo.SecondarySubstationTransformerMRID = Guid.Parse(mspFeeder.ConnectionPoint.PowerTransformer.mRID);
                feederInfo.SecondarySubstationTransformerName = mspFeeder.ConnectionPoint.PowerTransformer.name;
            }
        }

        static FeederInfo CreateBasicFeederInfo(int seqNo, Equipment equipment, List<Feeder> feeders)
        {
            var feederInfo = new FeederInfo()
            {
                SeqNo = seqNo,
                EquipmentName = equipment.name,
                EquipmentMRID = Guid.Parse(equipment.mRID),
                EquipmentClass = equipment.GetType().Name,
                EquipmentPSRType = equipment.PSRType,
                Multifeed = false,
                Nofeed = false
            };

            if (equipment is ConductingEquipment)
                feederInfo.VoltageLevel = (int)((ConductingEquipment)equipment).BaseVoltage;

            var cableBoxFeeder = feeders.Find(f => f.FeederType == FeederType.CableBox);

            if (cableBoxFeeder != null)
            {
                feederInfo.CableBoxMRID = Guid.Parse(cableBoxFeeder.ConnectionPoint.Substation.mRID);
                feederInfo.CableBoxName = cableBoxFeeder.ConnectionPoint.Substation.name;

                if (cableBoxFeeder.ConductingEquipment != null)
                {
                    feederInfo.CustomerFeederCableName = cableBoxFeeder.ConductingEquipment.name;
                    feederInfo.CustomerFeederCableMRID = Guid.Parse(cableBoxFeeder.ConductingEquipment.mRID);
                }
            }

            return feederInfo;
        }
    }
}
