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
    public class TestFeederInfoFUS : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\fus03lang_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void FUSTest()
        {
            // Check 2304 customer
            var st31081cust = _context.GetObject<ConductingEquipment>(TestMRIDs.St31081_Customer);
            var feeders = _feederContext.GeConductingEquipmentFeeders(st31081cust);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("31081", feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.Substation.name);
            Assert.AreEqual(0, feeders.Count(f => f.FeederType == FeederType.CableBox));
         
            // Check if customer if feeded from FUS
            var custPt = feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.PowerTransformer;
            feeders = _feederContext.GeConductingEquipmentFeeders(custPt);
            Assert.AreEqual("FUS", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("03LANG"));
        }
    }

}