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
            // Check that t-junction customer is feeded from the correct cablebox
            var cust = _context.GetObject<ConductingEquipment>("a2dde82a-4c72-45f5-83e8-aa4c5fb4c699");
            var feeders = _feederContext.GeConductingEquipmentFeeders(cust);
            Assert.AreEqual(2, feeders.Count);
            Assert.AreEqual(1, feeders.Count(f => f.FeederType == FeederType.CableBox));
            Assert.AreEqual(1, feeders.Count(f => f.FeederType == FeederType.SecondarySubstation));

            // Must be feeded from cable box 564
            Assert.AreEqual(1, feeders.Count(f => f.FeederType == FeederType.CableBox && f.ConnectionPoint.Substation.name == "564"));
        }


        [TestMethod]
        public void CustoemrCableFeederTest()
        {
            // Check that t-junction customer is feeded from the correct cable
            var cust = _context.GetObject<ConductingEquipment>("a2dde82a-4c72-45f5-83e8-aa4c5fb4c699");
            var custFeederInfo = _feederContext.GeConductingEquipmentFeederInfo(cust);
            Assert.IsTrue(custFeederInfo.FirstCustomerCableId == Guid.Parse("dc0f0387-b57c-4a55-9dfa-6b04b3979751"));

            var forsCable = _context.GetObject<ConductingEquipment>("05acea9f-d276-4372-9111-4c623c79f3ae");
            var forsCableFeederInfo = _feederContext.GeConductingEquipmentFeederInfo(forsCable);
            Assert.IsTrue(forsCableFeederInfo.FirstCustomerCableId == Guid.Empty);

            var cableInSol = _context.GetObject<ConductingEquipment>("8c069a3c-e426-4496-807f-9f87ad4dd14f");
            var cableInSolInfo = _feederContext.GeConductingEquipmentFeederInfo(cableInSol);
            Assert.IsTrue(cableInSolInfo.FirstCustomerCableId == Guid.Parse("dc0f0387-b57c-4a55-9dfa-6b04b3979751"));

        }
    }

}