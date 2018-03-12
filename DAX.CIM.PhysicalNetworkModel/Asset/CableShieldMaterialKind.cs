using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum CableShieldMaterialKind
    {

        /// <remarks/>
        aluminum,

        /// <remarks/>
        copper,

        /// <remarks/>
        lead,

        /// <remarks/>
        other,

        /// <remarks/>
        steel,
    }
}
