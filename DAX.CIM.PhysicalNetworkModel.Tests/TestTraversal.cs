using System;
using System.IO;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Traversal
{
    [TestClass]
    public class TestTraversal : FixtureBase
    {
        CimContext _context;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\engum_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);

            Using(_context);
        }

        [TestMethod]
        public void BasicNavigationTest()
        {
            // Find transformer belonging to station 30071 (Engum Bronx)
            var transformer = _context.GetObject<ConductingEquipment>(EngumTestMRIDs.Engum_St_300071_Tr_1);
            Assert.AreEqual("30071", transformer.GetSubstation().name);

            // Get neighboor conducting equipments, expect two transformer cables
            var tranformerCables = transformer.GetNeighborConductingEquipments();
            Assert.AreEqual(2, tranformerCables.Count);
            Assert.IsInstanceOfType(tranformerCables[0], typeof(ACLineSegmentExt));
            Assert.IsInstanceOfType(tranformerCables[1], typeof(ACLineSegmentExt));

            // Try if we can reach the transformer from cable 1
            var cableNeighbors = tranformerCables[0].GetNeighborConductingEquipments();

            // One of the cable's neighbors must be the transformer
            Assert.IsTrue(cableNeighbors.Contains(transformer));
        }

        [TestMethod]
        public void SubstationInternalTraversalTest()
        {
            // Find transformer belonging to station 30071 (Engum Bronx)
            var transformer = _context.GetObject<ConductingEquipment>(EngumTestMRIDs.Engum_St_300071_Tr_1);
            Assert.AreEqual("30071", transformer.GetSubstation().name);

            // Traverse the low voltage side of the substation
            var relatedLowVoltageEquipments = transformer
                            .Traverse(ci => !ci.IsOpen()
                                           && ci.BaseVoltage < transformer.GetSubstation().GetPrimaryVoltageLevel()
                                           && ci.IsInsideSubstation())
                            .ToList();

            // Expect 3 LV fuses
            Assert.AreEqual(3, relatedLowVoltageEquipments.Count(io => io is Fuse && ((ConductingEquipment)io).BaseVoltage == 400));

            // Expect 3 LV load break switches
            Assert.AreEqual(3, relatedLowVoltageEquipments.Count(io => io is LoadBreakSwitch && ((ConductingEquipment)io).BaseVoltage == 400));
        }

        [TestMethod]
        public void SubstationTranformerTraversalTest()
        {
            // Find transformer belonging to station 30071 (Engum Bronx)
            var transformer = _context.GetObject<ConductingEquipment>(EngumTestMRIDs.Engum_St_300071_Tr_1);
            Assert.AreEqual("30071", transformer.GetSubstation().name);

            // Traverse the low voltage network connected to this transformer
            var relatedLowVoltageEquipments = transformer
                            .Traverse(ci => 
                                !ci.IsOpen()
                                && 
                                ci.BaseVoltage < transformer.GetSubstation().GetPrimaryVoltageLevel()
                                &&
                                (
                                  (ci.IsInsideSubstation() && ci.GetSubstation() == transformer.GetSubstation())
                                  ||
                                  (ci.IsInsideSubstation() && ci.GetSubstation().PSRType == "CableBox")
                                  ||
                                  (!ci.IsInsideSubstation() && ci.BaseVoltage == 400)
                                )
                            ).ToList();

            // 35 energy consumers are connected to that substation
            Assert.AreEqual(35, relatedLowVoltageEquipments.Count(io => io is EnergyConsumer));
        }

    }
}