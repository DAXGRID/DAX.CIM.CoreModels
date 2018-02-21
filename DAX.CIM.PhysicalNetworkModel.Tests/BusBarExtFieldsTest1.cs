using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAX.CIM.PhysicalNetworkModel;
using System.Collections.Generic;
using System.Linq;

namespace DAX.CIM.PhysicalNetworkModel.Tests
{
    [TestClass]
    public class TestBusbarExtSerialization
    {
        [TestMethod]
        public void TestBusbarExtFields()
        {
            List<IdentifiedObject> cimObjects = new List<IdentifiedObject>();

            BusbarSectionExt bus = new BusbarSectionExt();
            cimObjects.Add(bus);

            bus.powerFactorMax = 11;
            bus.powerFactorMaxSpecified = true;

            bus.powerFactorMin = 12;
            bus.powerFactorMinSpecified = true;

            bus.sspMin = new ApparentPower() { Value = 13 };
            bus.sspMax = new ApparentPower() { Value = 14.5 };

            var acls = new ACLineSegmentExt();
            cimObjects.Add(acls);
            acls.neutral_r = new Resistance() { Value = 17.1 };
            acls.neutral_r0 = new Resistance() { Value = 17.2 };
            acls.neutral_x = new Reactance () { Value = 17.3 };
            acls.neutral_x0 = new Reactance() { Value = 17.4 };


            DAX.Cson.CsonSerializer cson = new Cson.CsonSerializer();

            var stream = cson.SerializeObjects(cimObjects);

            var deserializedCimObjects = cson.DeserializeObjects(stream).ToList();

            var desBus = deserializedCimObjects.Find(o => o is BusbarSectionExt) as BusbarSectionExt;

            Assert.IsTrue(bus.powerFactorMin == 12);
            Assert.IsTrue(bus.powerFactorMax == 11);
            Assert.IsTrue(bus.sspMin.Value == 13);
            Assert.IsTrue(bus.sspMax.Value == 14.5);

            var desAcls = deserializedCimObjects.Find(o => o is ACLineSegmentExt) as ACLineSegmentExt;

            Assert.IsTrue(desAcls.neutral_r.Value == 17.1);
            Assert.IsTrue(desAcls.neutral_r0.Value == 17.2);
            Assert.IsTrue(desAcls.neutral_x.Value == 17.3);
            Assert.IsTrue(desAcls.neutral_x0.Value == 17.4);

        }
    }
}
