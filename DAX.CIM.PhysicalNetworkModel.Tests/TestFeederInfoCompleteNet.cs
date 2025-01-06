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
    public class TestFeederInfoCompleteNet : FixtureBase
    {
        // Only run as part of konstant test
        bool run = true;

        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            if (run)
            {
                //var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\temp\nrgi\context-manager-cache-directory\data-129164.jsonl"));
                var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\temp\nrgi\context-manager-cache-directory\data-104532.jsonl"));

                var objects = reader.Read();

                _context = CimContext.Create(objects);
                Using(_context);

                _feederContext = new FeederInfoContext(_context);
                _feederContext.CreateFeederObjects();
            }
        }

        [TestMethod]
        public void MES_MultipleCablesFromSourceTest()
        {

            if (run)
            {
                // MES has a source that is connected to two different busbars with 2 cables.
                // We like to test that feeder info processor don't do multi feed on the HV network from that source

                // Check that HV cable is single feeded from MES source
                var cable = _context.GetObject<ConductingEquipment>("6f27795d-65cc-4631-aba5-6918d7482f0f") as ACLineSegment;

                var ec = _context.GetObject<ConductingEquipment>("A62107B8-E1A1-4296-BEB6-4B306AA0A667") as ACLineSegment;
                var ecFeederInfos = FeederInfo.FeederInfo.CreateFeederInfosFromEquipment(_feederContext, ec);

                var feederInfo = _feederContext.GeConductingEquipmentFeederInfo(cable);


                var feeders = _feederContext.GeConductingEquipmentFeeders(cable);
                Assert.AreEqual(1, feeders.Count);

                var feederInfos = FeederInfo.FeederInfo.CreateFeederInfosFromEquipment(_feederContext, cable);
                Assert.AreEqual(1, feederInfos.Count);

                var allFeeders = _feederContext.GetConductionEquipmentFeeders();

                var allFeedersForCable = allFeeders.Where(f => f.Key == cable).ToList();
                Assert.AreEqual(1, allFeedersForCable.Count);
                Assert.AreEqual(1, allFeedersForCable[0].Value.Count);
            }
        }
    }

}