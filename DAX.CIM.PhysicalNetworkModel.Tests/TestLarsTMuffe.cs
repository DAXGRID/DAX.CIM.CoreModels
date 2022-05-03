using DAX.CIM.PhysicalNetworkModel.FeederInfo;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Traversal
{
    [TestClass]
    public class TestLarsTMuffe : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader("C:/temp/cim/lars_tmuffe.jsonl");
            var objects = reader.Read();

            _context = CimContext.Create(objects);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();

            Using(_context);
        }

        [TestMethod]
        public void BasicNavigationTest()
        {
   


        }
    }
}