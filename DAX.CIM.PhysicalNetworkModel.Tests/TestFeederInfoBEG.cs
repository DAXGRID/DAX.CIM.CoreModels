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
    public class TestFeederInfoBEG : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\beg_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void BEGFeederInfoTest()
        {
            // Check cable directly on power transformer in 2189
            var pt = _context.GetObject<ConductingEquipment>(TestMRIDs.St2198_Tr1);
            var feeders = _feederContext.GeConductingEquipmentFeeders(pt);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("BEG", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("08BORU"));

            // Check feeder cable on 2198
            var feed1cable = _context.GetObject<ConductingEquipment>(TestMRIDs.St2198_Feeder1_Cable);
            feeders = _feederContext.GeConductingEquipmentFeeders(feed1cable);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("2198", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("1: MOD VÆNGESØGÅRD"));

            // Check tranformer primary substation feeder
            feeders = _feederContext.GeConductingEquipmentFeeders(feeders[0].ConnectionPoint.PowerTransformer);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("BEG", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("08BORU: 895"));

            // Check 2304 customer
            var st2304cust = _context.GetObject<ConductingEquipment>(TestMRIDs.St2304_Customer);
            feeders = _feederContext.GeConductingEquipmentFeeders(st2304cust);
            Assert.AreEqual("2304", feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.Substation.name);
            Assert.AreEqual("22400", feeders.Find(f => f.FeederType == FeederType.CableBox).ConnectionPoint.Substation.name);
            Assert.AreEqual(TestMRIDs.St2304_CustomerCableBoxBay, feeders.Find(f => f.FeederType == FeederType.CableBox).ConnectionPoint.Bay.mRID);

            // Check if customer if feeded from BEG 04STRA
            var custPt = feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.PowerTransformer;
            feeders = _feederContext.GeConductingEquipmentFeeders(custPt);
            Assert.AreEqual("BEG", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("04STRA"));
        }

        [TestMethod]
        public void BEGNullMridCheck()
        {
            foreach (var cn in _context.GetAllObjects())
            {
                Assert.IsFalse(cn.mRID == null);
                Assert.IsFalse(cn.mRID == "00000000-0000-0000-0000-000000000000");
            }
        }
    }

}