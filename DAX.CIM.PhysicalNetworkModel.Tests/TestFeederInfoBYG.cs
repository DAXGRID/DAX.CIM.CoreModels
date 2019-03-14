using System;
using System.IO;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAX.CIM.PhysicalNetworkModel.FeederInfo;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Traversal
{
    [TestClass]
    public class TestFeederInfoBYG : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\byg_hat_anonymized.jsonl"));
            //var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\temp\cim\hat_area_hsp_test.jsonl"));

            

            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void BYG_LocalTrafoDontInterfearTest()
        {
            // MES has a source that is connected to two different busbars with 2 cables.
            // We like to test that feeder info processor don't do multi feed on the HV network from that source
            var stByg = _context.GetObject<Substation>("82c69b59-0098-4e02-8bf9-5b12efbec42a");
            var bygChildren = stByg.GetEquipments(_context);

            // 60 kV kable fra hat
            var acls = _context.GetObject<ACLineSegment>("38e95d52-b924-4382-b0b2-e8fb887c7877");
            var aclsFeeders = _feederContext.GeConductingEquipmentFeeders(acls);

            var hatAdskiller = _context.GetObject<Disconnector>("c8224724-86b7-4223-90d1-7d21c8728242");

            Assert.IsNotNull(stByg);

            // check that all outgoing feeders has hat as source
            foreach (var bygFeeder in stByg.OutgoingFeeders)
            {
                if (bygFeeder.ConnectionPoint.Kind == ConnectionPointKind.Line)
                {
                    Assert.IsTrue(bygFeeder.ConnectionPoint.PowerTransformer.Feeders.Count == 1, "Expected power transformer" + bygFeeder.ConnectionPoint.PowerTransformer.ToString() + " feeding bay " + bygFeeder.ConnectionPoint.Bay.name + " to be feeder from one source");
                    Assert.IsTrue(bygFeeder.ConnectionPoint.PowerTransformer.Feeders[0].ConductingEquipment.name == "HAT");
                }
            }

            /*

            // Check that HV cable is single feeded from MES source
            var cable = _context.GetObject<ConductingEquipment>("5fd4f41a-3e6c-4c64-92f4-b25829b492bc") as ACLineSegment;

            var feeders = _feederContext.GeConductingEquipmentFeeders(cable);
            Assert.AreEqual(1, feeders.Count);

            var feederInfos = FeederInfo.FeederInfo.CreateFeederInfosFromEquipment(_feederContext, cable);
            Assert.AreEqual(1, feederInfos.Count);

            var allFeeders = _feederContext.GetConductionEquipmentFeeders();

            var allFeedersForCable = allFeeders.Where(f => f.Key == cable).ToList();
            Assert.AreEqual(1, allFeedersForCable.Count);
            Assert.AreEqual(1, allFeedersForCable[0].Value.Count);
            */

        }
    }

}