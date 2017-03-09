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
    public class TestFeederInfo : FixtureBase
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
        }

        [TestMethod]
        public void BasicFeederInfoTest()
        {
            _feederContext.CreateFeederObjects();

            //var tzxcest = _context.GetObject<ConductingEquipment>("11b75495-ed32-41fd-863e-cf95ddbff563");

            //var transformer = _context.GetObject<ConductingEquipment>(EngumTestMRIDs.Engum_St_300071_Tr_1);

            //var test = _feederContext.GeConductingEquipmentFeeders(transformer);

        }
    }

}