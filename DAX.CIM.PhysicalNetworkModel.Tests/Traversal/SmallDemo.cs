using System.Linq;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using NUnit.Framework;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Traversal
{
    [TestFixture]
    public class SmallDemo
    {
        [Test]
        public void Demo()
        {
            var identifiedObjects = Enumerable.Empty<IdentifiedObject>();

            using (var context = CimContext.Create(identifiedObjects))
            {
                LoadBreakSwitch loadBreakSwitch = null;


                var yesOrNo = loadBreakSwitch.IsInsideSubstation();
            }
        }
    }
}