using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS.Sensor.AccelGyro
{
    public class SNO_MPU6050_AccessData
    {
        public static DataTable List()
        {
            DataTable zTable = new DataTable();
            string zSQL = "exec SP_SNPO_MPU6050_Search null,null,null,null";
            string zConnectionString = TNS_DBConnection.Connecting.SQL_MainDatabase;
            try
            {
                SqlConnection zConnect = new SqlConnection(zConnectionString);
                zConnect.Open();
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                SqlDataAdapter zAdapter = new SqlDataAdapter(zCommand);
                zAdapter.Fill(zTable);
                zCommand.Dispose();
                zConnect.Close();
            }
            catch (Exception ex)
            {
                string zstrMessage = ex.ToString();
            }
            return zTable;
        }
    }
}
