using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.FeederInfo
{
    public enum ConnectionPointKind
    {
        Line = 1,
        PowerTranformer = 2,
        ExternalNetworkInjection = 3
    }

    public class ConnectionPoint
    {
        private List<Feeder> _feeders = null;
        public ConnectionPointKind Kind { get; set; }
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

        public override string ToString()
        {
            string result = "";
            if (Substation != null)
                result += " " + Substation.name;
            if (Bay != null && Bay.name != null)
                result += " " + Bay.name;
            if (PowerTransformer != null && PowerTransformer.name != null)
                result += " " + PowerTransformer.name;

            return result;
        }
    }

    
}
