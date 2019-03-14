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
    public class TestLineInfo637_5465 : FixtureBase
    {
        CimContext _context;
        LineInfoContext _lineContext;
        string _csonFilename = @"Data\tjunction_637_5465_lineinfo_test_anonymized.jsonl";

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
        public void TestLineInfoBetween637and5465()
        {
            var lines = _lineContext.GetLines();

            var line = lines.Find(l => l.Name == "637-5465");
            Assert.IsNotNull(line);

            // line consist more than 30 ACLS's
            Assert.IsTrue(line.Children.Count > 30);
        }
    }
}
