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
    public class TestUpsert : FixtureBase
    {
        CimContext _context;
        LineInfoContext _lineContext;
        string _csonFilename = @"C:\temp\cim\complete_net_anonymized.jsonl";

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
        public void UpsertLineInfo()
        {
            var lines = _lineContext.GetLines();

            string connection = "Data Source=vsqlgis-test;Initial Catalog=Data1;User Id=dataadmin;Password=dataadmin";

            var upsert = new UpsertHelper<LineInfo>(connection, "LineInfo2");

            List<LineInfo> lineInfos = new List<LineInfo>();
            HashSet<Guid> alreadyAdded = new HashSet<Guid>();

            foreach (var line in lines)
            {
                foreach (var lineRel in line.Children)
                {
                    var lineInfo = new LineInfo()
                    {
                        Id = Guid.Parse(lineRel.Equipment.mRID),
                        EquipmentClass = lineRel.Equipment.GetType().Name,
                        EquipmentPSRType = lineRel.Equipment.PSRType,
                        FromNode = line.FromSubstation != null ? Guid.Parse(line.FromSubstation.mRID) : Guid.Empty,
                        ToNode = line.ToSubstation != null ? Guid.Parse(line.ToSubstation.mRID) : Guid.Empty,
                        FromBay = line.FromBay != null ? Guid.Parse(line.FromBay.mRID) : Guid.Empty,
                        ToBay = line.ToBay != null ? Guid.Parse(line.ToBay.mRID) : Guid.Empty,
                        Position = lineRel.Order,
                        VoltageLevel = Convert.ToInt32(((ConductingEquipment)lineRel.Equipment).BaseVoltage)
                    };

                    if (!alreadyAdded.Contains(lineInfo.Id))
                    {
                        lineInfos.Add(lineInfo);
                        alreadyAdded.Add(lineInfo.Id);
                    }


                }
            }
            //upsert.CreateSchema();
            upsert.Upsert(lineInfos).Wait();
            

        }
    }

    public class LineInfo
    {
        public Guid Id { get; set; }
        public string EquipmentClass { get; set; }
        public string EquipmentPSRType { get; set; }
        public int VoltageLevel { get; set; }
        public Guid FromBay { get; set; }
        public Guid ToBay { get; set; }
        public int Position { get; set; }
        public Guid FromNode { get; set; }
        public Guid ToNode { get; set; }
    }
}
