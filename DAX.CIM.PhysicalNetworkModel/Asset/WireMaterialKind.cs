using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum WireMaterialKind
    {

        /// <remarks/>
        acsr,

        /// <remarks/>
        aluminum,

        /// <remarks/>
        aluminumAlloy,

        /// <remarks/>
        aluminumAlloySteel,

        /// <remarks/>
        aluminumSteel,

        /// <remarks/>
        copper,

        /// <remarks/>
        other,

        /// <remarks/>
        steel,

        /// <remarks/>
        aaac,
    }
}
