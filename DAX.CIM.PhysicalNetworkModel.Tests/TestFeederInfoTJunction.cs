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
    public class TestFeederInfoTJunction : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\st75_tjunction.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        } 

        [TestMethod]
        public void St75TJunctionFeederTest()
        {
            // Check that t-junction customer is feeded from the corret cablebox
            var cust = _context.GetObject<ConductingEquipment>("a2dde82a-4c72-45f5-83e8-aa4c5fb4c699");
            var feeders = _feederContext.GeConductingEquipmentFeeders(cust);
            Assert.AreEqual(2, feeders.Count);
            Assert.AreEqual(1, feeders.Count(f => f.FeederType == FeederType.CableBox));
            Assert.AreEqual(1, feeders.Count(f => f.FeederType == FeederType.SecondarySubstation));

            // Must be feeded from cable box 564
            Assert.AreEqual(1, feeders.Count(f => f.FeederType == FeederType.CableBox && f.ConnectionPoint.Substation.name == "564"));
        }
    }

}