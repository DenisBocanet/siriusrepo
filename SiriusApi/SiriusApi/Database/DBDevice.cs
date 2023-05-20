using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SiriusApi.Models;

namespace SiriusApi.Database
{
    public class DBDevice
    {
        private const string CONNECTIONSTRING = "Server=(localdb)\\MSSQLLocalDB;Database=DBAntigicu;Trusted_Connection=True;MultipleActiveResultSets=true";


        public List<TbDevice> getDevicesName() {
            List<TbDevice> tbDevices = new List<TbDevice>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTIONSTRING))
                {
                    connection.Open();

                    String sql = "SELECT *  FROM tbDevices";
                  



                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TbDevice tbDevice = new TbDevice();
                                tbDevice.TxName = reader.GetName(0);
                                tbDevice.NmAltitude = reader.GetInt16(1);
                                tbDevice.NmLatitude = reader.GetString(2);
                                tbDevice.NmLongitude = reader.GetString(3);
                                tbDevice.NmSerial = reader.GetString(4);
                                tbDevice.NmYear = reader.GetInt16(5);
                                tbDevice.TxModel = reader.GetString(6);
                                tbDevice.TxTypeSection = reader.GetString(7);
                                tbDevice.TxNote = reader.GetString(8);
                                tbDevice.IdPlant = reader.GetInt32(9);


                                tbDevices.Add(tbDevice);

                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (SqlException e)
            {
               
            }
            

            return tbDevices;
        }


    }
}
