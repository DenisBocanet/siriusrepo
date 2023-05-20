using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiriusApi.Models;
using Microsoft.Data.SqlClient;

namespace SiriusApi.Database
{
    public class DBMeasure
    {
        private const string CONNECTIONSTRING = "Server=(localdb)\\MSSQLLocalDB;Database=DBAntigicu;Trusted_Connection=True;MultipleActiveResultSets=true";


        public List<TbMeasure> getMeasureName()
        {
            List<TbMeasure> TbMeasure = new List<TbMeasure>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
                {
                    connection.Open();

                    String sql = "SELECT *  FROM TbMeasure";




                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TbMeasure TbMeasures = new TbMeasure();
                                TbMeasures.DtDate = reader.GetDateTime(0);
                                TbMeasures.NmActivePower = reader.GetInt32(1);
                                TbMeasures.NmAmbientTemp = reader.GetDouble(2);
                                TbMeasures.NmControllerHubTemp = reader.GetInt16(3);
                                TbMeasures.NmControllerTopTemp = reader.GetInt16(4);
                                TbMeasures.NmFrequency = reader.GetInt16(5);
                                TbMeasures.NmGeneratorSpeed = reader.GetFloat(6);
                                TbMeasures.NmRotorSpeed = reader.GetInt64(7);
                                TbMeasures.NmWindSpeed = reader.GetInt32(8);
                                TbMeasures.NmPressure = reader.GetInt32(9);
                                TbMeasures.NmNacelleDir = reader.GetInt32(9);
                                TbMeasures.NmNacelleTemp = reader.GetInt32(9);
                                TbMeasures.NmProduciblePower = reader.GetInt32(9);
                                TbMeasures.NmProduciblePowerVestas = reader.GetInt32(9);
                                TbMeasures.IdDevice = reader.GetInt32(9);
                                TbMeasures.IdPlant = reader.GetInt32(9);


                                TbMeasure.Add(TbMeasures);

                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (SqlException e)
            {

            }


            return TbMeasure;
        }


    }
}
