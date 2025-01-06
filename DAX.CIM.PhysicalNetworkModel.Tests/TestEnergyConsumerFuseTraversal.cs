using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using DAX.CIM.PhysicalNetworkModel.Tests.Data;
using DAX.CIM.PhysicalNetworkModel.Traversal;
using DAX.CIM.PhysicalNetworkModel.Traversal.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Traversal
{
    [TestClass]
    public class TestEnergyConsumerFuseTraversal : FixtureBase
    {
        CimContext _context;

        protected override void SetUp()
        {
            var reader = new CimJsonFileReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"c:\temp\cim\data-109739.jsonl"));
            var objects = reader.Read();

            _context = CimContext.Create(objects);

            Using(_context);
        }


        [TestMethod]
        public void SubstationInternalTraversalTest()
        {
            var energyConsumers = _context.GetAllObjects().OfType<EnergyConsumer>();


            using (var connection = new SqlConnection("Data Source=vsqlgis;Initial Catalog=Data1;User Id=dataadmin;Password=D@ta1User21"))
            {
                connection.Open();


                foreach (var energyConsumer in energyConsumers)
                {

                   
                    var relatedLowVoltageEquipments = energyConsumer
                                    .Traverse(ce => !ce.IsOpen()
                                                   && ce.BaseVoltage == 400
                                                   && !(ce is Fuse),
                                                cn => !(cn.IsInsideSubstation(_context) && (cn.GetSubstation(true, _context).PSRType == "CableBox" || cn.GetSubstation(true, _context).PSRType == "SecondarySubstation") && cn.GetNeighborConductingEquipments(_context).Count() > 2)
                                                , true
                                              )
                                    .ToList();


                    var fuses = relatedLowVoltageEquipments.OfType<Fuse>();

                    if (fuses.Count() == 0)
                    {

                    }

                    if (energyConsumer.mRID == "68cf0302-1252-446a-b7a4-53bf0c3ec864")
                    {

                    }

                    foreach (var o in fuses)
                    {

                        using (var command = connection.CreateCommand())
                        {
                            string query = @"INSERT INTO dbo.mie_energyconsumer_fuse_trace_result (
	                           EnergyConsumerMRID,FuseMRID)
                                VALUES (
							        @EnergyConsumerMRID,
	                                @FuseMRID)";

                            command.CommandText = query;

                            command.Parameters.AddWithValue("@EnergyConsumerMRID", Guid.Parse(energyConsumer.mRID));
                            command.Parameters.AddWithValue("@FuseMRID", Guid.Parse(o.mRID));

                            command.ExecuteNonQuery();

                        }
                    }
                }
            }
        }

    }
}