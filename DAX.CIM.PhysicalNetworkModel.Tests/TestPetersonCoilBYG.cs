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
    public class TestPetersonCoilBYG : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\byg_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void BYGPetersonCoilTest()
        {

            var stByg = _context.GetObject<Substation>("82c69b59-0098-4e02-8bf9-5b12efbec42a");
            Assert.IsNotNull(stByg);

            var stBygTrafo1 = _context.GetObject<PowerTransformer>("e4aa6412-6faf-44b9-a369-4f3abad57e93");
            var stBygTrafo1Connections = _context.GetConnections(stBygTrafo1);

            // Check that acls from statin if feedeed from trao
            var acls1 = _context.GetObject<ACLineSegment>("cf87d5ef-6493-4d58-898a-6600d7230c9b");
            Assert.IsNotNull(acls1.Feeders);
            Assert.IsTrue(acls1.Feeders.Count == 1);
            Assert.IsTrue(acls1.Feeders[0].ConnectionPoint.PowerTransformer != null);

            // Check coil connectivity
            var coil = _context.GetObject<PetersenCoil>("582e765b-8281-4a10-96cc-5c53a6943f42");
            var coilConnections = _context.GetConnections(coil);

            var traf1coilDis = _context.GetObject<Disconnector>("956bdd78-8ac6-4fab-9b6d-532820ba2165");
            var traf1coilDisConnections = _context.GetConnections(traf1coilDis);

            // Check that coil is connected to coils disconnector
            Assert.IsTrue(coilConnections.Exists(o => traf1coilDisConnections.Exists(d => d.ConnectivityNode == o.ConnectivityNode)), "No connection from coil to disconnector");

            // Check that disconnector is connected to trafo
            Assert.IsTrue(traf1coilDisConnections.Exists(o => stBygTrafo1Connections.Exists(d => d.ConnectivityNode == o.ConnectivityNode)), "No connection from coil disconnector to trafo");


        }
    }
}
