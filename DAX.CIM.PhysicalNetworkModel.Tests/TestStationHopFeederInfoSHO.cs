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
    public class TestStationHopFeederInfoSHO : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\sho_udf2.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void BygUdf2HopTest()
        {
            // Check that first cable from SHO is hop 0
            var cable1 = _context.GetObject<ConductingEquipment>("8030204c-d959-417b-baa3-5d0c2fd63143") as ACLineSegment;
            var feederInfoCable1 = _feederContext.GeConductingEquipmentFeederInfo(cable1);
            Assert.AreEqual(0, feederInfoCable1.SubstationHop);

            // check cable 1 going north after 31298, should be hop 1
            var cable2 = _context.GetObject<ConductingEquipment>("6f27795d-65cc-4631-aba5-6918d7482f0f") as ACLineSegment;
            var feederInfoCable2 = _feederContext.GeConductingEquipmentFeederInfo(cable2);
            Assert.AreEqual(1, feederInfoCable2.SubstationHop);

            // check cable 1 going east after 31298, should be hop 1
            var cable3 = _context.GetObject<ConductingEquipment>("62fced80-674b-4128-861e-e714ee43e7ac") as ACLineSegment;
            var feederInfoCable3 = _feederContext.GeConductingEquipmentFeederInfo(cable3);            
            Assert.AreEqual(1, feederInfoCable3.SubstationHop);

            // check cable 2 going east after 31298, should be hop 2
            var cable4 = _context.GetObject<ConductingEquipment>("27dcfefe-8ef7-44de-9c52-3c11870dae33") as ACLineSegment;
            var feederInfoCable4 = _feederContext.GeConductingEquipmentFeederInfo(cable4);
            Assert.AreEqual(2, feederInfoCable4.SubstationHop);

            // check cable 1 after 30517, should be hop 3
            var cable5 = _context.GetObject<ConductingEquipment>("40192c7c-2f31-4e67-82a7-c7ecde2809a3") as ACLineSegment;
            var feederInfoCable5 = _feederContext.GeConductingEquipmentFeederInfo(cable5);
            Assert.AreEqual(3, feederInfoCable5.SubstationHop);

            // check cable 2 after 30517, should be hop 3
            var cable6 = _context.GetObject<ConductingEquipment>("75f483bf-dea6-4819-a239-0f489c9e6871") as ACLineSegment;
            var feederInfoCable6 = _feederContext.GeConductingEquipmentFeederInfo(cable6);
            Assert.AreEqual(3, feederInfoCable6.SubstationHop);
        }
    }
}