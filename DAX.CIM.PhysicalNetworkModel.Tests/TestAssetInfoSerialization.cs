using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using DAX.CIM.PhysicalNetworkModel.FeederInfo;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using System.IO;

namespace DAX.CIM.PhysicalNetworkModel.Tests
{
    [TestClass]
    public class TestAssetInfoSerialization : FixtureBase
    {
        CimContext _context;
        FeederInfoContext _feederContext;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\trb06_anonymized.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _feederContext = new FeederInfoContext(_context);
            _feederContext.CreateFeederObjects();
        }

        [TestMethod]
        public void TestAssetInfoSerialize()
        {
            List<IdentifiedObject> cimObjects = new List<IdentifiedObject>();

            // Create ACLS
            ACLineSegmentExt acls = new ACLineSegmentExt();
            acls.mRID = Guid.NewGuid().ToString();
            acls.name = "Test acls";
            acls.iK = new CurrentFlow() { multiplier = UnitMultiplier.k, unit = UnitSymbol.A, Value = 999 };
            cimObjects.Add(acls);

            // Create Asset
            Asset asset = new Asset();
            asset.mRID = Guid.NewGuid().ToString();
            asset.name = "Test asset";
            cimObjects.Add(asset);

            // Create cable info ext
            CableInfoExt ci = new CableInfoExt();
            ci.conductorCount = 3;
            ci.material = WireMaterialKind.aluminum;
            ci.conductorCrossSectionalArea = 240;
            ci.conductorCrossSectionalAreaSpecified = true;
            ci.mRID = Guid.NewGuid().ToString();

            // relate cable info to asset
            asset.AssetInfo = new AssetAssetInfo() { @ref = ci.mRID };

            cimObjects.Add(ci);

            DAX.Cson.CsonSerializer cson = new Cson.CsonSerializer();

            var stream = cson.SerializeObjects(cimObjects);

            var deserializedCimObjects = cson.DeserializeObjects(stream).ToList();

            var desAcls = deserializedCimObjects.Find(o => o is ACLineSegmentExt) as ACLineSegmentExt;
            var desAsset = deserializedCimObjects.Find(o => o is Asset) as Asset;
            var desCi = deserializedCimObjects.Find(o => o is CableInfoExt) as CableInfoExt;

            Assert.AreEqual(999,desAcls.iK.Value);

            Assert.AreEqual(desAsset.AssetInfo.@ref, ci.mRID);

            Assert.AreEqual(3, ci.conductorCount);

            Assert.AreEqual(240, ci.conductorCrossSectionalArea);

            Assert.AreEqual(WireMaterialKind.aluminum, ci.material);

            /*
            // Check that extension methods for fetching generation unit of a energy consumer works
            CimContext cimContext = CimContext.Create(deserializedCimObjects);

            Assert.IsTrue(desEc.HasGeneratingUnit());

            var genUnit = desEc.GetGeneratingUnit();

            Assert.AreEqual(gu.mRID, genUnit.mRID);
            */
        }
    }
}
