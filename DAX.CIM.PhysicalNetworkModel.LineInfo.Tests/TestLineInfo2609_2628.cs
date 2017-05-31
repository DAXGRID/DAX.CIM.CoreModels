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
    public class TestLineInfo2609_2628 : FixtureBase
    {
        CimContext _context;
        LineInfoContext _lineContext;
        string _csonFilename = @"Data\msp_2609_2628_lineinfo_test_anonymized.jsonl";

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
        public void TestLineInfoBetween2609and2628()
        {
            var lines = _lineContext.GetLines();

            var line = lines.Find(l => l.Name == "2609-2628");
            Assert.IsNotNull(line);

            // line consist of 4 ACLS's
            Assert.AreEqual(4, line.Children.Count);
        }
    }
}
