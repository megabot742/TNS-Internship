using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TNS.Sensor.AccelGyro
{
    public class SNO_MPU6050_Record
    {
        #region [ Field Name ]
        public string _AutoKey = "";
        public string _Address = "";
        public readonly DateTime? _TimeDate = null;
        public float _GyroX = 0;
        public float _GyroY= 0;
        public float _GyroZ = 0;
        public float _AccelX = 0;
        public float _AccelY = 0;
        public float _AccelZ = 0;
        private string _Message = "";   
        #endregion

        public SNO_MPU6050_Record(string AutoKey)
        {
            string zSQL = "SELECT * FROM [dbo].[SNO_MPU6050] WHERE AutoKey = @Autokey";
            string zConnectionString = TNS_DBConnection.Connecting.SQL_MainDatabase;
            SqlConnection zConnect = new SqlConnection(zConnectionString);
            zConnect.Open();
            try
            {
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.CommandType = CommandType.Text;
                zCommand.Parameters.Add("@AutoKey", SqlDbType.UniqueIdentifier).Value = new Guid(AutoKey);
                SqlDataReader zReader = zCommand.ExecuteReader();
                if (zReader.HasRows)
                {
                    zReader.Read();
                    _AutoKey = zReader["AutoKey"].ToString();
                    _Address = zReader["Address"].ToString();

                    
                    _GyroX = float.Parse(zReader["Gyro_X"].ToString());
                    _GyroY = float.Parse(zReader["Gyro_Y"].ToString());
                    _GyroZ = float.Parse(zReader["Gyro_Z"].ToString());
                    
                    _AccelX = float.Parse(zReader["Accel_X"].ToString());
                    _AccelY = float.Parse(zReader["Accel_Y"].ToString());
                    _AccelZ = float.Parse(zReader["Accel_Z"].ToString());
                    
                    if (zReader["TimeDate"] != DBNull.Value)
                        _TimeDate = (DateTime)zReader["TimeDate"];
                    else
                        _Message = "OK";
                }
                else
                {
                    _Message = "404 Not Found";
                }

                zReader.Close();
                zCommand.Dispose();
            }
            catch (Exception Err)
            {
                _Message = "501 " + Err.ToString();
            }
            finally
            {
                zConnect.Close();
            }
        }
        public static DataTable Search_By_Address(string address)
        {
            DataTable resultTable = new DataTable();
            string query = "SELECT * FROM [TNS_VietTech].[dbo].[SNO_MPU6050] WHERE Address LIKE @Address";
            string connectionString = TNS_DBConnection.Connecting.SQL_MainDatabase;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Address", SqlDbType.VarChar).Value = address + "%"; // Thêm dấu % để chỉ phần khớp đầu tiên

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(resultTable);
                }
            }
            catch (Exception)
            {
                // Xử lý ngoại lệ
            }

            return resultTable;
        }
        public static DataTable Search_Between_Day(string fromDate, string toDate)
        {
            DataTable zTable = new DataTable();
            string zSQL = "SELECT* FROM [TNS_VietTech].[dbo].[SNO_MPU6050] WHERE TimeDate BETWEEN @TuNgay AND @DenNgay";
            string zConnectionString = TNS_DBConnection.Connecting.SQL_MainDatabase;
            try
            {
                using (SqlConnection zConnect = new SqlConnection(zConnectionString))
                {
                    zConnect.Open();
                    SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                    zCommand.CommandType = CommandType.Text;
                    zCommand.Parameters.Add("@TuNgay", SqlDbType.DateTime).Value = DateTime.Parse(fromDate);
                    zCommand.Parameters.Add("@DenNgay", SqlDbType.DateTime).Value = DateTime.Parse(toDate);
                    SqlDataAdapter adapter = new SqlDataAdapter(zCommand);
                    adapter.Fill(zTable);
                }
            }
            catch (Exception)
            {
                // Handle exception
            }

            return zTable;
        }
        public static DataTable Search_By_Day(string Date)
        {
            DataTable zTable = new DataTable();
            string zSQL = "SELECT * FROM [TNS_VietTech].[dbo].[SNO_MPU6050] WHERE CONVERT(DATE, TimeDate) = @TimeDate";
            string zConnectionString = TNS_DBConnection.Connecting.SQL_MainDatabase;
            try
            {
                using (SqlConnection zConnect = new SqlConnection(zConnectionString))
                {
                    zConnect.Open();
                    SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                    zCommand.CommandType = CommandType.Text;
                    zCommand.Parameters.Add("@TimeDate", SqlDbType.DateTime).Value = DateTime.ParseExact(Date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    SqlDataAdapter adapter = new SqlDataAdapter(zCommand);
                    adapter.Fill(zTable);
                }
            }
            catch (Exception)
            {
                // Xử lý ngoại lệ
            }

            return zTable;
        }
        public static DataTable Find_By_AutoKey(string pAutoKey)
        {
            if (string.IsNullOrEmpty(pAutoKey))
                return null;
            DataTable zTable = new DataTable();
            string zSQL = "SELECT * FROM [TNS_VietTech].[dbo].[SNO_MPU6050] WHERE AutoKey = @AutoKey";
            string zConnectionString = TNS_DBConnection.Connecting.SQL_MainDatabase;
            try
            {
                SqlConnection zConnect = new SqlConnection(zConnectionString);
                zConnect.Open();
                SqlCommand zCommand = new SqlCommand(zSQL, zConnect);
                zCommand.Parameters.AddWithValue("@AutoKey", pAutoKey);
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
        public static void Delete_By_AutoKey(string AutoKey)
        {
            if (string.IsNullOrEmpty(AutoKey))
            {
                throw new InvalidOperationException("AutoKey is required for DELETE operation.");
            }

            string zSQL = "DELETE FROM [dbo].[SNO_MPU6050] WHERE AutoKey = @AutoKey";
            string zConnectionString = TNS_DBConnection.Connecting.SQL_MainDatabase;

            try
            {
                using (SqlConnection zConnect = new SqlConnection(zConnectionString))
                {
                    zConnect.Open();
                    using (SqlCommand zCommand = new SqlCommand(zSQL, zConnect))
                    {
                        zCommand.Parameters.AddWithValue("@AutoKey", AutoKey);
                        zCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string zstrMessage = ex.ToString();
                // Xử lý lỗi tại đây
            }

        }
    }
}
