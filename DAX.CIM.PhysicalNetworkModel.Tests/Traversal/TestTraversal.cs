using System;
using System.IO;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using NUnit.Framework;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Traversal
{
    [TestFixture]
    public class TestTraversal : FixtureBase
    {
        CimContext _context;

        protected override void SetUp()
        {
            var reader = new CimXmlFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Torsted_0_1_3.xml"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);

            Using(_context);
        }

        [Test]
        public void GreatName()
        {
            Console.WriteLine($"Total count: {_context.Count}");

            var firstConductingEquipment = _context.OfType<ConductingEquipment>().First();

            Console.WriteLine($"First conducting equipment: {firstConductingEquipment}");

            var relatedEquipment = firstConductingEquipment
                .Traverse(c => !c.IsOpen()
                               && c.BaseVoltage.IsEqualTo(firstConductingEquipment.BaseVoltage)
                               && (!c.IsInsideSubstation() ||
                                   (c.IsInsideSubstation()
                                    && c.GetSubstation().PSRType == "CableBox")))
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, relatedEquipment));
        }
    }
}