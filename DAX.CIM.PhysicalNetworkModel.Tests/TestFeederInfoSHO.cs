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
    public class TestFeederInfoSHO : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\sho_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void SHOTest()
        {
            // Check 03HATT feeder cable
            var hattFeederCable = _context.GetObject<ConductingEquipment>(TestMRIDs.SHO_03HATT_FeederCable);
            var feeders = _feederContext.GeConductingEquipmentFeeders(hattFeederCable);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("SHO", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("03HATT"));

            // Check 03HATT feeder cable
            var hamFeederCable = _context.GetObject<ConductingEquipment>(TestMRIDs.SHO_14HAM2_FeederCable);
            feeders = _feederContext.GeConductingEquipmentFeeders(hamFeederCable);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("SHO", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("14HAM2"));

            // Trafo in 30906 must be feeded from 14HAN02
            var st30906tr1 = _context.GetObject<ConductingEquipment>(TestMRIDs.St30906_Tr1);
            feeders = _feederContext.GeConductingEquipmentFeeders(st30906tr1);
            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("SHO", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("14HAM2"));

            // Check that customer on st 30906  is multi feeded
            var st30906cust = _context.GetObject<ConductingEquipment>(TestMRIDs.St30906_Customer);
            feeders = _feederContext.GeConductingEquipmentFeeders(st30906cust);
            Assert.AreEqual(2, feeders.Count);
            Assert.AreEqual("30906", feeders[0].ConnectionPoint.Substation.name);
            Assert.AreEqual("30906", feeders[1].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.PowerTransformer != feeders[1].ConnectionPoint.PowerTransformer);

            // Check if customer is feeder from substation 30215 and 50474 
            var st30215st = _context.GetObject<ConductingEquipment>(TestMRIDs.St30215_Customer);
            feeders = _feederContext.GeConductingEquipmentFeeders(st30215st);
            Assert.AreEqual("30215", feeders.Find(f => f.FeederType == FeederType.SecondarySubstation).ConnectionPoint.Substation.name);
            Assert.AreEqual("50474", feeders.Find(f => f.FeederType == FeederType.CableBox).ConnectionPoint.Substation.name);
        }
    }

}