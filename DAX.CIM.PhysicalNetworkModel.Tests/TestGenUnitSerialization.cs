using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;


namespace DAX.CIM.PhysicalNetworkModel.Tests
{
    [TestClass]
    public class TestGenUnitSerialization
    {
        [TestMethod]
        public void TestGenUnitSerialize()
        {
            List<IdentifiedObject> cimObjects = new List<IdentifiedObject>();

            // Create Energy Consumer
            EnergyConsumer ec = new EnergyConsumer();
            ec.mRID = Guid.NewGuid().ToString();
            ec.name = "Test customer";
            cimObjects.Add(ec);

            // Create Generating Unit Ext
            GeneratingUnitExt gu = new GeneratingUnitExt();

            // Relate to EnergyConsumer
            gu.mRID = Guid.NewGuid().ToString();
            gu.EnergyConsumer = new GeneratingUnitExtEnergyConsumer() { @ref = ec.mRID };

            // 6 kW PV unit
            gu.ratedS = new ApparentPower() { multiplier = UnitMultiplier.k, unit = UnitSymbol.W, Value = 6 };
            gu.type = GeneratingUnitKind.Solar;

            cimObjects.Add(gu);

            DAX.Cson.CsonSerializer cson = new Cson.CsonSerializer();

            var stream = cson.SerializeObjects(cimObjects);

            var deserializedCimObjects = cson.DeserializeObjects(stream).ToList();

            var desEc = deserializedCimObjects.Find(o => o is EnergyConsumer) as EnergyConsumer;
            var desGu = deserializedCimObjects.Find(o => o is GeneratingUnitExt) as GeneratingUnitExt;

            Assert.AreEqual(ec.mRID, desEc.mRID);

            Assert.AreEqual(gu.mRID, desGu.mRID);

            Assert.AreEqual(ec.mRID, desGu.EnergyConsumer.@ref);

            Assert.AreEqual(GeneratingUnitKind.Solar, desGu.type);

            Assert.AreEqual(6, desGu.ratedS.Value);

            Assert.AreEqual(UnitSymbol.W, desGu.ratedS.unit);

            Assert.AreEqual(UnitMultiplier.k, desGu.ratedS.multiplier);

            // Check that extension methods for fetching generation unit of a energy consumer works
            CimContext cimContext = CimContext.Create(deserializedCimObjects);

            Assert.IsTrue(desEc.HasGeneratingUnit());

            var genUnit = desEc.GetGeneratingUnit();

            Assert.AreEqual(gu.mRID, genUnit.mRID);
        }
    }
}
