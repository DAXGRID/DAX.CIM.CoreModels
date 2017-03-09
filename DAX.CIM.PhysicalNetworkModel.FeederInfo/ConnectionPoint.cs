using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.FeederInfo
{
    public class ConnectionPoint
    {
        private List<Feeder> _feeders = null;
        public ConnectivityNode ConnectivityNode { get; set; }
        public Substation Substation { get; set; }
        public PowerTransformer PowerTransformer { get; set; }
        public Bay Bay { get; set; }

        public IReadOnlyList<Feeder> Feeders
        {
            get
            {
                if (_feeders == null)
                    return new List<Feeder>();
                else
                    return _feeders;
            }
        }

        public void AddFeeder(Feeder feeder)
        {
            if (_feeders == null)
                _feeders = new List<Feeder>();

            _feeders.Add(feeder);
        }
    }
}
