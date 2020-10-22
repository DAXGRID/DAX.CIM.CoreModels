﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.FeederInfo
{
    public class ConductingEquipmentFeederInfo
    {
        public List<Feeder> Feeders = new List<Feeder>();
        public int SubstationHop { get; set; }
    }
}