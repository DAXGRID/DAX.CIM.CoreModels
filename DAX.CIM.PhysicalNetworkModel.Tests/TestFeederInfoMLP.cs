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
    public class TestFeederInfoMLP : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\mlp_anonymized.jsonl"));
            //var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\temp\cim\complete_net_eq.jsonl"));
            
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void SwitchBetweenSwitchTest()
        {
            foreach (var cimObj in _context.GetAllObjects())
            {
                if (cimObj is Switch)
                {
                    var connections = _context.GetConnections(cimObj);

                    int neighborSwCount = 0;

                    foreach (var con in connections)
                    {
                        var cnSwCnt = con.ConnectivityNode.GetNeighborConductingEquipments().Count(c => c is Switch);

                        if (cnSwCnt > 1)
                            neighborSwCount++;
                    }

                    if (neighborSwCount > 1)
                    {
                        System.Diagnostics.Debug.WriteLine("'" + cimObj.mRID + "',");
                    }
                }
            }

        }

        [TestMethod]
        public void MLP_ParallelCableFeederInfoTest()
        {
            // MLP has 3 parallel MV cables goin out of bay 7.
            // We like to test that feeder info processor don't do multi feed on them cables.

            // Check cable that is connected after the 3 parallel cables on bay 7
            var cable = _context.GetObject<ConductingEquipment>("3f580793-ffb6-4aa1-bf0b-d7b96f51f550") as ACLineSegment;

            var feeders = _feederContext.GeConductingEquipmentFeeders(cable);
            Assert.AreEqual(1, feeders.Count);

            var feederInfos = FeederInfo.FeederInfo.CreateFeederInfosFromEquipment(_feederContext, cable);
            Assert.AreEqual(1, feederInfos.Count);

            var allFeeders = _feederContext.GetConductionEquipmentFeeders();

            var allFeedersForCable = allFeeders.Where(f => f.Key == cable).ToList();
            Assert.AreEqual(1, allFeedersForCable.Count);
            Assert.AreEqual(1, allFeedersForCable[0].Value.Count);

        }
    }

}