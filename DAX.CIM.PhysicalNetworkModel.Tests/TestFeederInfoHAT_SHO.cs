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
    public class TestFeederInfoHAT_SHO : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\hat_sho_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void SHOExternalNetworkInjectionTest()
        {
            // SHO is feeded from HAT

            // trafo 1 should have no feeder, because breaker is normal open
            var stShoTrafo1 = _context.GetObject<PowerTransformer>("67423cd4-bb9e-4c75-99c4-a96c8dbd46b8");
            Assert.IsTrue(stShoTrafo1.Feeders.Count(f => f.FeederType == FeederType.NetworkInjection) == 0);
            Assert.IsTrue(stShoTrafo1.Feeders.Count() == 0);

            // trafo 2 should be feeded from hat
            var stShoTrafo2 = _context.GetObject<PowerTransformer>("eb0bed2f-0779-4a2e-ba56-bc2199666509");
            Assert.IsTrue(stShoTrafo2.Feeders.Count(f => f.FeederType == FeederType.NetworkInjection) == 1);
            Assert.IsTrue(stShoTrafo2.Feeders.Exists(f => f.ConductingEquipment.name == "HAT"));


        }
    }

}