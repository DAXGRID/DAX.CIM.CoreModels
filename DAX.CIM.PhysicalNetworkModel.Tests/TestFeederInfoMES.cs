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
    public class TestFeederInfoMES : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\mes_anonymized.jsonl"));
            
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void MES_MultipleCablesFromSourceTest()
        {
            // MES has a source that is connected to two different busbars with 2 cables.
            // We like to test that feeder info processor don't do multi feed on the HV network from that source

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

        }
    }

}