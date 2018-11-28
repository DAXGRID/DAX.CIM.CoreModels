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
    public class TestPetersonCoilABO : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\aabo_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void ABOPetersonCoilTest()
        {
            var stAbo = _context.GetObject<Substation>("bf53ee6a-e772-4466-81fa-07d502a02f01");
            Assert.IsNotNull(stAbo);

            // Check that acls from statin if feedeed from trafo
            var acls1 = _context.GetObject<ACLineSegment>("cbfe60cc-e56c-40ef-a525-10abde3b81e8");
            Assert.IsNotNull(acls1.Feeders);
            Assert.IsTrue(acls1.Feeders.Count == 1);
            Assert.IsTrue(acls1.Feeders[0].ConnectionPoint.PowerTransformer != null);

            var stAboTrafo1 = _context.GetObject<PowerTransformer>("f06617c6-b615-478b-94dc-444cf0fa2e60");
            var stAboTrafo1Connections = _context.GetConnections(stAboTrafo1);
            
            // Check coil connectivity
            var coil = _context.GetObject<PetersenCoil>("d92f475c-db46-4c65-8b0b-45b622b97a17");
            var coilConnections = _context.GetConnections(coil);

            var traf1coilDis = _context.GetObject<Disconnector>("7b5d6daf-2ddd-4ccf-82b6-925a9aa655a0");
            var traf1coilDisConnections = _context.GetConnections(traf1coilDis);

            // Check that coil is connected to coils disconnector
            Assert.IsTrue(coilConnections.Exists(o => traf1coilDisConnections.Exists(d => d.ConnectivityNode == o.ConnectivityNode)), "No connection from coil to disconnector");

            // Check that disconnector is connected to trafo
            Assert.IsTrue(traf1coilDisConnections.Exists(o => stAboTrafo1Connections.Exists(d => d.ConnectivityNode == o.ConnectivityNode)), "No connection from coil disconnector to trafo");

            var acls60k = _context.GetNeighborConductingEquipments(stAboTrafo1).Find(o => o.BaseVoltage == 60000);

            var acls60kNeighbors = _context.GetNeighborConductingEquipments(acls60k);

            // check that trafo 1 is feeded
            //Assert.IsTrue(stAboTrafo1.Feeders.Count == 1);

        }


    }
}
