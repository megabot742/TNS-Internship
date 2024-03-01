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
using TNS_MIC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TNS.VietTech.App
{
    public partial class FrmTableRecord : Form
    {
        private string _Message;
        public bool isUpdate = false;
        public string AutoKey = "";

        public FrmTableRecord()
        {
            InitializeComponent();
            this.Height = 400;
            this.Width = 400;
        }

        private void FrmTableRecord_Load(object sender, EventArgs e)
        {
            if(AutoKey == "")
                ClearForm();
            else
                Load_Info();
            
        }
        
        private void Load_Info()
        {
            SNO_MPU6050_Info info = new SNO_MPU6050_Info(AutoKey);
            //Key = "8fabd893-d574-45e6-ad7e-1392341ff136";
            txt_Address.Text = info.Address;
            txt_GyroX.Text = info.Gyro_X.ToString();
            txt_GyroY.Text = info.Gyro_Y.ToString();
            txt_GyroZ.Text = info.Gyro_Z.ToString();
            txt_AccelX.Text = info.Accel_X.ToString();
            txt_AccelY.Text = info.Accel_Y.ToString();
            txt_AccelZ.Text = info.Accel_Z.ToString();
        }
        //Dọn dẹp form
        private void ClearForm()
        {
            AutoKey = "";
            txt_Address.Text = "";
            txt_GyroX.Text = "";
            txt_GyroY.Text = "";
            txt_GyroZ.Text = "";
            txt_AccelX.Text = "";
            txt_AccelY.Text = "";
            txt_AccelZ.Text = "";
            dt_TimeDate.Value = DateTime.Now;
        }

        //Button delete table
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SNO_MPU6050_Info info = new SNO_MPU6050_Info(AutoKey);
            info.Empty();
            if (info.Message.Substring(0,3) == "200")
            {
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            else
                MessageBox.Show("Lỗi");
        }
        //Button update table
        private string CheckBeforSave()
        {
            string zResult = "";
            if (txt_Address.Text.ToString() == "")
            {
                zResult += "Vui lòng điền mã địa chỉ! \n";
            }
            if (txt_GyroX.Text.ToFloat() == 0)
            {
                zResult += "Vui lòng điền \n";
            }
            if (txt_GyroY.Text.ToFloat() == 0)
            {
                 zResult += "Vui lòng điền \n";
            }
            if (txt_GyroZ.Text.ToFloat() == 0)
            {
                 zResult += "Vui lòng điền \n";
            }
            if (txt_AccelX.Text.ToFloat() == 0)
            {
                    zResult += "Vui lòng điền \n";
            }
            if (txt_AccelY.Text.ToFloat() == 0)
            {
                    zResult += "Vui lòng điền \n";
             }
            if (txt_AccelZ.Text.ToFloat() == 0)
            {
                    zResult += "Vui lòng điền \n";
            }
            return zResult;
        }
        
        private void btn_Update_Click(object sender, EventArgs e)
        {
            SNO_MPU6050_Info info;
            if (AutoKey == "")
                info = new SNO_MPU6050_Info();

            else
                info = new SNO_MPU6050_Info(AutoKey);

            if (CheckBeforSave() == "")
            {
                info.Address = txt_Address.Text.ToString().Trim();
                if (dt_TimeDate.Value != DateTime.MinValue)
                {
                   info.TimeDate = dt_TimeDate.Value;
                }
                float zGyro_X = 0;
                if (float.TryParse(txt_GyroX.Text, out zGyro_X))
                {

                }
                info.Gyro_X = zGyro_X;
                float zGyro_Y = 0;
                if (float.TryParse(txt_GyroY.Text, out zGyro_Y))
                {

                }
                info.Gyro_Y = zGyro_Y;
                float zGyro_Z = 0;
                if (float.TryParse(txt_GyroZ.Text, out zGyro_Z))
                {

                }
                info.Gyro_Z = zGyro_Z;
                float zAccel_X = 0;
                if (float.TryParse(txt_AccelX.Text, out zAccel_X))
                {

                }
                info.Accel_X = zAccel_X;
                float zAccel_Y = 0;
                if (float.TryParse(txt_AccelY.Text, out zAccel_Y))
                {

                }
                info.Accel_Y = zAccel_Y;
                float zAccel_Z = 0;
                if (float.TryParse(txt_AccelZ.Text, out zAccel_Z))
                {

                }
                info.Accel_Z = zAccel_Z;
                info.Save();
                if (info.Message.Substring(0,3) == "200" || info.Message.Substring(0, 3) == "201")
                {
                    MessageBox.Show("Thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi" + info.Message);
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
