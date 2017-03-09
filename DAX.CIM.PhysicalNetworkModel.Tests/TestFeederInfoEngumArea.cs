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
    public class TestFeederInfoEngumArea : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\engum_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        } 

        [TestMethod]
        public void EngumSt30071TrafoFeederInfoTest()
        {
            var st30071trafo = _context.GetObject<ConductingEquipment>(TestMRIDs.Engum_St_30071_Tr_1);

            var feeders = _feederContext.GeConductingEquipmentFeeders(st30071trafo);

            Assert.AreEqual(1, feeders.Count);
            Assert.AreEqual("BRB", feeders[0].ConnectionPoint.Substation.name);
            Assert.IsTrue(feeders[0].ConnectionPoint.Bay.name.StartsWith("03JULI"));

        }
    }

}