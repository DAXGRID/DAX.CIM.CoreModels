using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.FeederInfo;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using System.IO;
using System.Linq;

namespace DAX.CIM.PhysicalNetworkModel.Tests
{
    [TestClass]
    public class TestFeederInfoBAS : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\BAS_feederinfo_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void BASTest()
        {

            // ACLine segement that had problems before getting feeded from power transformer
            var acls = _context.GetObject<ACLineSegment>("c494d297-9d5c-46dd-813d-1971b63d6f86");
            var aclsFeeders = _feederContext.GeConductingEquipmentFeeders(acls);
            Assert.IsNotNull(aclsFeeders[0].ConnectionPoint.PowerTransformer);



        }
    }
}
