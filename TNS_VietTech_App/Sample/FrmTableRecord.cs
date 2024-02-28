using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TNS.Sensor.AccelGyro;

namespace TNS.VietTech.App
{
    public partial class FrmTableRecord : Form
    {
        private string _Message;
        public bool isUpdate = false;
        //public string STT { get; set; }
        public string AutoKey { get; set; }

        public FrmTableRecord()
        {
            InitializeComponent();
            this.Height = 400;
            this.Width = 400;
        }

        private void FrmTableRecord_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (!string.IsNullOrEmpty(AutoKey))
            {
                dt = SNO_MPU6050_Record.Find_By_AutoKey(AutoKey); // Gọi xử lý kiểm tra FindIDByAutoKey
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow zRow = dt.Rows[0];
                    AutoKey = zRow["AutoKey"].ToString();
                    Load_Info(zRow);
                }
                else
                {
                    AutoKey = null;
                }
            }
        }
        
        private void Load_Info(DataRow zRow)

        {
            //Key = "8fabd893-d574-45e6-ad7e-1392341ff136";
            if (zRow != null)
            {
                string autoKey = zRow["AutoKey"].ToString();
                string address = zRow["Address"].ToString();
                float gyroX = float.Parse(zRow["Gyro_X"].ToString());
                float gyroY = float.Parse(zRow["Gyro_Y"].ToString());
                float gyroZ = float.Parse(zRow["Gyro_Z"].ToString());
                float accelX = float.Parse(zRow["Accel_X"].ToString());
                float accelY = float.Parse(zRow["Accel_Y"].ToString());
                float accelZ = float.Parse(zRow["Accel_Z"].ToString());
                DateTime? timeDate = zRow["TimeDate"] != DBNull.Value ? (DateTime?)zRow["TimeDate"] : null;

                New_Record record = new New_Record(autoKey, address, gyroX, gyroY, gyroZ, accelX, accelY, accelZ, timeDate);

                // Load dữ liệu từ record lên form
                txt_AutoKey.Text = record.AutoKey;
                txt_Address.Text = record.Address;
                txt_GyroX.Text = record.GyroX.ToString();
                txt_GyroY.Text = record.GyroY.ToString();
                txt_GyroZ.Text = record.GyroZ.ToString();
                txt_AccelX.Text = record.AccelX.ToString();
                txt_AccelY.Text = record.AccelY.ToString();
                txt_AccelZ.Text = record.AccelZ.ToString();
                if (record.TimeDate.HasValue)
                {
                    dt_TimeDate.Value = record.TimeDate.Value;
                }
                else
                {
                    dt_TimeDate.Value = DateTime.Now;
                }
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu
                MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }
        //Dọn dẹp form
        private void ClearForm()
        {
            txt_AutoKey.Text = "";
            txt_Address.Text = "";
            txt_GyroX.Text = "";
            txt_GyroY.Text = "";
            txt_GyroZ.Text = "";
            txt_AccelX.Text = "";
            txt_AccelY.Text = "";
            txt_AccelZ.Text = "";
            dt_TimeDate.Value = DateTime.Now;
        }
        //Tạo new record
        public class New_Record
        {
            public string AutoKey { get; set; }
            public string Address { get; set; }
            public float GyroX { get; set; }
            public float GyroY { get; set; }
            public float GyroZ { get; set; }
            public float AccelX { get; set; }
            public float AccelY { get; set; }
            public float AccelZ { get; set; }
            public DateTime? TimeDate { get; set; }

            public New_Record(string autoKey, string address, float gyroX, float gyroY, float gyroZ, float accelX, float accelY, float accelZ, DateTime? timeDate)
            {
                AutoKey = autoKey;
                Address = address;
                GyroX = gyroX;
                GyroY = gyroY;
                GyroZ = gyroZ;
                AccelX = accelX;
                AccelY = accelY;
                AccelZ = accelZ;
                TimeDate = timeDate;
            }
        }

        //Function update
        public int Update_Info(string AutoKey)
        {
            string zSQL = string.Empty;

            if (string.IsNullOrEmpty(AutoKey))
            {
               zSQL = "INSERT INTO [dbo].[SNO_MPU6050] " +
               "(Address,TimeDate, Gyro_X, Gyro_Y, Gyro_Z, Accel_X, Accel_Y, Accel_Z) " +
               "VALUES " +
               "(@Address,@TimeDate, @Gyro_X, @Gyro_Y, @Gyro_Z, @Accel_X, @Accel_Y, @Accel_Z)";
            }
            else
            {
                zSQL = "UPDATE [dbo].[SNO_MPU6050] SET " +
                              "Address = @Address," +
                              "Gyro_X = @Gyro_X," +
                              "Gyro_Y = @Gyro_Y," +
                              "Gyro_Z = @Gyro_Z," +
                              "Accel_X = @Accel_X," +
                              "Accel_Y = @Accel_Y," +
                              "Accel_Z = @Accel_Z " +
                              "WHERE AutoKey = @AutoKey";
            }
            int zResult =0;
            string zConnectionString = TNS_DBConnection.Connecting.SQL_MainDatabase;
            SqlConnection zConnect = new SqlConnection(zConnectionString);
            zConnect.Open();
            try
            {
                decimal? GyroX = TryParseDecimal(txt_GyroX.Text);
                decimal? GyroY = TryParseDecimal(txt_GyroY.Text);
                decimal? GyroZ = TryParseDecimal(txt_GyroZ.Text);
                decimal? AccelX = TryParseDecimal(txt_AccelX.Text);
                decimal? AccelY = TryParseDecimal(txt_AccelY.Text);
                decimal? AccelZ = TryParseDecimal(txt_AccelZ.Text);
                DateTime? timedate = dt_TimeDate.Value;

                decimal? TryParseDecimal(string value)
                {
                    return decimal.TryParse(value, out decimal result) ? result : (decimal?)null;
                }

                using (SqlCommand zCommand = new SqlCommand(zSQL, zConnect))
                {
                    zCommand.CommandType = CommandType.Text;
                    if (!string.IsNullOrEmpty(AutoKey))
                    {
                        zCommand.Parameters.Add("@AutoKey", SqlDbType.UniqueIdentifier).Value = new Guid(AutoKey);
                    }
                    if (timedate.HasValue)
                    {
                        zCommand.Parameters.Add("@TimeDate", SqlDbType.DateTime).Value = timedate.Value;
                    }
                    else
                    {
                        zCommand.Parameters.Add("@TimeDate", SqlDbType.DateTime).Value = DBNull.Value;
                    }
                    zCommand.Parameters.AddWithValue("@Address", txt_Address.Text);
                    zCommand.Parameters.AddWithValue("@Gyro_X", GyroX);
                    zCommand.Parameters.AddWithValue("@Gyro_Y", GyroY);
                    zCommand.Parameters.AddWithValue("@Gyro_Z", GyroZ);
                    zCommand.Parameters.AddWithValue("@Accel_X", AccelX);
                    zCommand.Parameters.AddWithValue("@Accel_Y", AccelY);
                    zCommand.Parameters.AddWithValue("@Accel_Z", AccelZ);
                    zResult = zCommand.ExecuteNonQuery();
                }
                _Message = "200 OK";
            }
            catch (Exception ex)
            {
                _Message = "501 " + ex.Message;
            }
            finally
            {
                zConnect.Close();
            }
            return zResult;
        }
        //Function Check
        private bool Check_AutoKey(string AutoKey)
        {
            DataTable dt = SNO_MPU6050_Record.Find_By_AutoKey(AutoKey);
            return dt != null && dt.Rows.Count > 0;
        }

        //Button delete table
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Check_AutoKey(AutoKey))
            {
                SNO_MPU6050_Record.Delete_By_AutoKey(AutoKey);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Record with AutoKey has been deleted.");
            }
            else
            {
                MessageBox.Show("Invalid AutoKey. Record not found.");
            }
        }
        //Button update table
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (Update_Info(AutoKey) == 1)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show(_Message);
        }
    }
}
