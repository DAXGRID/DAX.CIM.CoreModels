using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using System.IO;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using Debaser;
using System.Collections.Generic;
using System.Linq;

namespace DAX.CIM.PhysicalNetworkModel.LineInfo.Tests
{
    [TestClass]
    public class TestLineInfoARU_KRL : FixtureBase
    {
        CimContext _context;
        LineInfoContext _lineContext;
        string _csonFilename = @"Data\hsp_aru_krl_lineinfo_test_anonymized.jsonl";

        protected override void SetUp()
        {

            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _csonFilename));
            var objects = reader.Read();

            _context = CimContext.Create(objects);
            Using(_context);

            _lineContext = new LineInfoContext(_context);
            _lineContext.CreateLineInfo();
        }

        [TestMethod]
        public void TestLineInfoBetweenARUandKRL()
        {
            var lines = _lineContext.GetLines();

            var krlAruLine = lines.Find(l => l.Name == "KRL-ÅRU");
            Assert.IsNotNull(krlAruLine);

            // line consist of 9 ACLS's
            Assert.AreEqual(9, krlAruLine.Children.Count);
        }
    }
}
