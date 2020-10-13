using System;
using System.IO;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.FeederInfo;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Traversal
{
    [TestClass]
    public class TestStationHopFeederInfo : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\tor_udf2.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void TorUdf2HopTest()
        {
            // Check that HV cable is single feeded from MES source
            var cable1 = _context.GetObject<ConductingEquipment>("cb7e78aa-f64a-42b7-a3e0-463ebd5c8c9a") as ACLineSegment;
            var feederInfoCable1 = _feederContext.GeConductingEquipmentFeederInfo(cable1);
            Assert.AreEqual(0, feederInfoCable1.SubstationHop);

            // Cable after first substation, should be hop 1
            var cable2 = _context.GetObject<ConductingEquipment>("e6da0725-1e23-460d-a24c-4927a50f21ff") as ACLineSegment;
            var feederInfoCable2 = _feederContext.GeConductingEquipmentFeederInfo(cable2);
            Assert.AreEqual(1, feederInfoCable2.SubstationHop);

            // First cable after split substation 30406, should be hop 3
            var cable3 = _context.GetObject<ConductingEquipment>("e82eb2c4-56c8-48a3-a61e-0d7dc7087283") as ACLineSegment;
            var feederInfoCable3 = _feederContext.GeConductingEquipmentFeederInfo(cable3);            
            Assert.AreEqual(3, feederInfoCable3.SubstationHop);

            // Second cable after split substation 30406, should be also be hop 3
            var cable4 = _context.GetObject<ConductingEquipment>("518c872c-28ed-499e-abba-29d8ec0f8d0d") as ACLineSegment;
            var feederInfoCable4 = _feederContext.GeConductingEquipmentFeederInfo(cable4);
            Assert.AreEqual(3, feederInfoCable4.SubstationHop);

        }
    }
}