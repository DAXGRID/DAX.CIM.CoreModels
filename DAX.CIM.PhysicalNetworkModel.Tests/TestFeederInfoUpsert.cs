using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using System.IO;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using Debaser;
using System.Collections.Generic;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.FeederInfo;

namespace DAX.CIM.PhysicalNetworkModel.Tests
{
    [TestClass]
    public class TestFeederInfoUpsert : FixtureBase
    {
        bool run = true;
        CimContext _context;
        FeederInfoContext _feederContext;

        string _csonFilename = @"C:\temp\cim\complete_net_anonymized.jsonl";

        protected override void SetUp()
        {
            if (run)
            {
                //var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\engum_anonymized.jsonl"));

                var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _csonFilename));
                var objects = reader.Read();

                _context = CimContext.Create(objects);
                Using(_context);

                _feederContext = new FeederInfoContext(_context);
                _feederContext.CreateFeederObjects();
            }
        }

        [TestMethod]
        public void UpsertFeederInfo()
        {
            if (run)
            {

                var feeders = _feederContext.GetConductionEquipmentFeeders();

                string connection = "Data Source=vsqlgis-test;Initial Catalog=Data1;User Id=dataadmin;Password=dataadmin";

                var upsert = new UpsertHelper<FeederInfo>(connection, "FeederInfo2");

                List<FeederInfo> feederInfos = new List<FeederInfo>();
                HashSet<Guid> alreadyAdded = new HashSet<Guid>();

                foreach (var cnFeeder in feeders)
                {
                    int seqNo = 1;

                    List<FeederInfo> feederInfosToAdd = new List<FeederInfo>();

                    // loop through msp feeders
                    foreach (var mspFeeder in cnFeeder.Value.Where(f => f.FeederType == FeederType.SecondarySubstation))
                    {
                        bool hspFeedersFound = false;

                        // Check if power transformer has hsp feeders
                        if (mspFeeder.ConnectionPoint.PowerTransformer != null)
                        {
                            var hspFeeders = _feederContext.GeConductingEquipmentFeeders(mspFeeder.ConnectionPoint.PowerTransformer);

                            foreach (var hspFeeder in hspFeeders)
                            {
                                FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, cnFeeder);
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
                            FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, cnFeeder);
                            seqNo++;

                            AddMspFeederInfo(mspFeeder, feederInfo);

                            feederInfosToAdd.Add(feederInfo);
                        }
                    }

                    // Find hsp feeders
                    foreach (var hspFeeder in cnFeeder.Value.Where(f => f.FeederType == FeederType.PrimarySubstation))
                    {
                        FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, cnFeeder);
                        seqNo++;

                        AddHspFeederInfo(hspFeeder, feederInfo);
                        feederInfosToAdd.Add(feederInfo);
                    }

                    // If seqNo still 1, then we found no feeders
                    if (seqNo == 1)
                    {
                        // Add feeder info telling that we have no feed
                        FeederInfo feederInfo = CreateBasicFeederInfo(seqNo, cnFeeder);
                        feederInfo.MultiFeed = false;
                        feederInfo.NoFeed = true;
                        feederInfos.Add(feederInfo);
                    }

                    // If seqNo > 2 the components is multi feeded
                    if (seqNo > 2)
                    {
                        foreach (var f in feederInfosToAdd)
                            f.MultiFeed = true;
                    }

                    feederInfos.AddRange(feederInfosToAdd);
                }

                // Add components that has no feeder
                foreach (var cimObj in _context.GetAllObjects())
                {
                    if (cimObj is ConductingEquipment)
                    {
                        var cn = cimObj as ConductingEquipment;

                        if (_feederContext.GeConductingEquipmentFeeders(cn).Count == 0)
                        {
                            var feederInfo = new FeederInfo()
                            {
                                SeqNo = 1,
                                Id = CreateDerivedGuid(Guid.Parse(cn.mRID), 1),
                                EquipmentMRID = Guid.Parse(cn.mRID),
                                EquipmentClass = cn.GetType().Name,
                                EquipmentPSRType = cn.PSRType,
                                VoltageLevel = (int)cn.BaseVoltage,
                                MultiFeed = false,
                                NoFeed = true
                            };

                            feederInfos.Add(feederInfo);
                        }
                    }
                }


                //upsert.CreateSchema();
                upsert.Upsert(feederInfos).Wait();

            }
        }

        private static void AddHspFeederInfo(Feeder hspFeeder, FeederInfo feederInfo)
        {
            if (hspFeeder.ConnectionPoint.Substation != null)
                feederInfo.PrimarySubstationMRID = Guid.Parse(hspFeeder.ConnectionPoint.Substation.mRID);

            if (hspFeeder.ConnectionPoint.Bay != null)
                feederInfo.PrimarySubstationBayMRID = Guid.Parse(hspFeeder.ConnectionPoint.Bay.mRID);

            if (hspFeeder.ConnectionPoint.PowerTransformer != null)
                feederInfo.PrimarySubstationTransformerMRID = Guid.Parse(hspFeeder.ConnectionPoint.PowerTransformer.mRID);
        }

        private static void AddMspFeederInfo(Feeder mspFeeder, FeederInfo feederInfo)
        {
            if (mspFeeder.ConnectionPoint.Substation != null)
                feederInfo.SecondarySubstationMRID = Guid.Parse(mspFeeder.ConnectionPoint.Substation.mRID);

            if (mspFeeder.ConnectionPoint.Bay != null)
                feederInfo.SecondarySubstationBayMRID = Guid.Parse(mspFeeder.ConnectionPoint.Bay.mRID);

            if (mspFeeder.ConnectionPoint.PowerTransformer != null)
                feederInfo.SecondarySubstationTransformerMRID = Guid.Parse(mspFeeder.ConnectionPoint.PowerTransformer.mRID);
        }

        private FeederInfo CreateBasicFeederInfo(int seqNo, KeyValuePair<ConductingEquipment,List<Feeder>> cnFeeder)
        {
            var feederInfo = new FeederInfo()
            {
                SeqNo = seqNo,
                Id = CreateDerivedGuid(Guid.Parse(cnFeeder.Key.mRID), seqNo),
                EquipmentMRID = Guid.Parse(cnFeeder.Key.mRID),
                EquipmentClass = cnFeeder.Key.GetType().Name,
                EquipmentPSRType = cnFeeder.Key.PSRType,
                VoltageLevel = (int)cnFeeder.Key.BaseVoltage,
                MultiFeed = false,
                NoFeed = false
            };

            var cableBoxFeeder = cnFeeder.Value.Find(f => f.FeederType == FeederType.CableBox);

            if (cableBoxFeeder != null)
            {
                feederInfo.CableBoxMRID = Guid.Parse(cableBoxFeeder.ConnectionPoint.Substation.mRID);
                if (cableBoxFeeder.ACLineSegment != null)
                    feederInfo.CustomerFeederCableMRID = Guid.Parse(cableBoxFeeder.ACLineSegment.mRID);
            }

            return feederInfo;
        }

        public Guid CreateDerivedGuid(Guid orig, int no, bool longRange = false)
        {
            byte[] a = orig.ToByteArray();
            byte[] b = new byte[16];

            for (int i = 0; i < 8; i++)
                b[i] = (byte)no;

            if (no > 255)
            {
                int divVal = no / 255;
                b[0] = (byte)divVal;
                b[0] += 128;
                b[1] = (byte)divVal;
            }

            if (!longRange)
            {
                // XOR
                return new Guid(BitConverter.GetBytes(BitConverter.ToUInt64(a, 0) ^ BitConverter.ToUInt64(b, 8))
                    .Concat(BitConverter.GetBytes(BitConverter.ToUInt64(a, 8) ^ BitConverter.ToUInt64(b, 0))).ToArray());
            }
            else
            {

                // AND
                for (int i = 0; i < 16; i++)
                    b[i] = (byte)no;

                int div = no / 255;
                b[0] = (byte)div;
                b[2] = (byte)div;
                b[4] = (byte)div;
                b[6] = (byte)div;
                b[8] = (byte)div;
                b[10] = (byte)div;
                b[12] = (byte)div;
                b[14] = (byte)div;

                for (int i = 0; i < 16; i++)
                    a[i] += b[i];

                return new Guid(a);
            }
        }
    }

    public class FeederInfo
    {
        public Guid Id { get; set; }
        public Guid EquipmentMRID { get; set; }
        public int SeqNo { get; set; }
        public string EquipmentClass { get; set; }
        public string EquipmentPSRType { get; set; }
        public int VoltageLevel { get; set; }
        public bool NoFeed { get; set; }
        public bool MultiFeed { get; set; }
        public Guid CustomerFeederCableMRID { get; set; }
        public Guid CableBoxMRID { get; set; }
        public Guid CableBoxBusbarMRID { get; set; }
        public Guid SecondarySubstationMRID { get; set; }
        public Guid SecondarySubstationBayMRID { get; set; }
        public Guid SecondarySubstationTransformerMRID { get; set; }
        public Guid PrimarySubstationMRID { get; set; }
        public Guid PrimarySubstationBayMRID { get; set; }
        public Guid PrimarySubstationTransformerMRID { get; set; }
        public Guid SourceMRID { get; set; }
    }


  
}
