namespace DAX.CIM.PhysicalNetworkModel
{
    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://daxgrid.net/PhysicalNetworkModel_0_1")]
    public enum SynchronousMachineKind
    {

        /// <remarks/>
        condenser,

        /// <remarks/>
        generator,

        /// <remarks/>
        generatorOrCondenser,

        /// <remarks/>
        generatorOrCondenserOrMotor,

        /// <remarks/>
        generatorOrMotor,

        /// <remarks/>
        motor,

        /// <remarks/>
        motorOrCondenser,
    }
}
