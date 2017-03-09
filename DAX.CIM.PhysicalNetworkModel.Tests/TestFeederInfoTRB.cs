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
    public class TestFeederInfoTRB : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\trb06_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void TRBTest()
        {
            // Check 2304 customer
            var cust = _context.GetObject<ConductingEquipment>(TestMRIDs.St259_Customer);
            var feeders = _feederContext.GeConductingEquipmentFeeders(cust);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("259", feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.Substation.name);
            Assert.AreEqual(0, feeders.Count(f => f.FeederType == FeederType.CableBox));
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("1: STIK BYGNING 220"));
                   
            // Check if customer if feeded from TRB
            var custPt = feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.PowerTransformer;
            feeders = _feederContext.GeConductingEquipmentFeeders(custPt);
            Assert.AreEqual("TRB", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("06: 153"));

            // Check 2304 customer connected directly to power transformer
            cust = _context.GetObject<ConductingEquipment>(TestMRIDs.St259_TrafoCustomer);
            feeders = _feederContext.GeConductingEquipmentFeeders(cust);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("259", feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.Substation.name);
            Assert.AreEqual(0, feeders.Count(f => f.FeederType == FeederType.CableBox));
            Assert.IsNull(feeders[0].ConnectionPoint.Bay);

            // Check if customer if feeded from TRB
            custPt = feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.PowerTransformer;
            feeders = _feederContext.GeConductingEquipmentFeeders(custPt);
            Assert.AreEqual("TRB", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("06: 153"));
        }
    }

}