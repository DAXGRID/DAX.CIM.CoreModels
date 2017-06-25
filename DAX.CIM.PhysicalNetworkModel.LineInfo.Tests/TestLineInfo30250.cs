using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.LineInfo.Tests
{
    [TestClass]
    public class TestLineInfo30250 : FixtureBase
    {
        CimContext _context;
        LineInfoContext _lineContext;
        string _csonFilename = @"Data\lsp_30250_lineinfo_test_anonymized.jsonl";

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
        public void TestLineInfoBetween30250And44646And44647()
        {
            var lines = _lineContext.GetLines();

            var line = lines.Find(l => l.Name == "30250-44646");
            Assert.IsNotNull(line);
            Assert.AreEqual(1, line.Children.Count);
            Assert.AreEqual("258aaeb3-c36f-47be-9f7d-681f2866a6e9", line.Children[0].Equipment.mRID);

            var line2 = lines.Find(l => l.Name == "30250-44647");
            Assert.IsNotNull(line2);
            Assert.AreEqual(1, line2.Children.Count);
            Assert.AreEqual("fa628f1a-d760-4db8-b82e-45920473e366", line2.Children[0].Equipment.mRID);

        }
    }
}
