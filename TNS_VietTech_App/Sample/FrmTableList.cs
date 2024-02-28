using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNS.VietTech.App
{
    public partial class FrmTableList : Form
    {
        public FrmTableList()
        {
            InitializeComponent();
        }

        private void FrmTableList_Load(object sender, EventArgs e)
        {
            LV_Init();

            DataTable zTable = TNS.Sensor.AccelGyro.SNO_MPU6050_AccessData.List();
            LV_LoadData(zTable);
        }
        private void LV_Init() //Khởi tạo các model cho bảng listview
        {
            ListView LV = LV_Data;
            LV.Items.Clear();
            LV.Columns.Clear();
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "STT";
            colHead.Width = 40;
            colHead.TextAlign = HorizontalAlignment.Center;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Text = "Address";
            colHead.Name = "Address";
            colHead.Width = 120;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);


            colHead = new ColumnHeader();
            colHead.Text = "TimeDate";
            colHead.Name = "TimeDate";
            colHead.Width = 250;
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader(); // Add column for Gyro_X
            colHead.Text = "Gyro_X";
            colHead.Name = "Gyro_X";
            colHead.Width = 100; // Adjust width as needed
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader(); // Add column for Gyro_X
            colHead.Text = "Gyro_Y";
            colHead.Name = "Gyro_Y";
            colHead.Width = 100; // Adjust width as needed
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader(); // Add column for Gyro_X
            colHead.Text = "Gyro_Z";
            colHead.Name = "Gyro_Z";
            colHead.Width = 100; // Adjust width as needed
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader(); // Add column for Gyro_X
            colHead.Text = "Accel_X";
            colHead.Name = "Accel_X";
            colHead.Width = 100; // Adjust width as needed
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader(); // Add column for Gyro_X
            colHead.Text = "Accel_Y";
            colHead.Name = "Accel_Y";
            colHead.Width = 100; // Adjust width as needed
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

            colHead = new ColumnHeader(); // Add column for Gyro_X
            colHead.Text = "Accel_Z";
            colHead.Name = "Accel_Z";
            colHead.Width = 100; // Adjust width as needed
            colHead.TextAlign = HorizontalAlignment.Left;
            LV.Columns.Add(colHead);

        }
        public void LV_LoadData(DataTable In_Table)
        {
            LV_Data.Items.Clear(); // Xóa các mục hiện tại trong ListView
            int stt = 1;
            foreach (DataRow row in In_Table.Rows)
            {
                ListViewItem item = new ListViewItem(stt.ToString()); // Lấy giá trị của cột đầu tiên trong DataRow chạy tự động -> tạo STT
                // Tương tự thay bằng tên cột trong CSDL
                item.Tag = row["AutoKey"].ToString();
                item.SubItems.Add(row["Address"].ToString());
                item.SubItems.Add(row["TimeDate"].ToString());
                item.SubItems.Add(row["Gyro_X"].ToString());
                item.SubItems.Add(row["Gyro_Y"].ToString());
                item.SubItems.Add(row["Gyro_Z"].ToString());
                item.SubItems.Add(row["Accel_X"].ToString());
                item.SubItems.Add(row["Accel_Y"].ToString());
                item.SubItems.Add(row["Accel_Z"].ToString());
                //Phần tử tag, phụ vụ cho việc ItemActivate khi biết nhấn vào phần tử nào trong listview
                LV_Data.Items.Add(item); // Thêm ListViewItem vào ListView
                stt++;
            }

        }

        private void LV_Data_ItemActivate(object sender, EventArgs e)
        {
            if (LV_Data.SelectedItems[0].Tag != null) //Kiểm tra phần tử null hay không
            {
                string zID = LV_Data.SelectedItems[0].Tag.ToString();
                //Test bắt AutoKey
                //string message = "Bạn đã nhấn vào phần tử có AutoKey: " + zID;
                //MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmTableRecord frm = new FrmTableRecord(); 
                frm.AutoKey = zID;
                if (frm.ShowDialog() == DialogResult.OK) 
                {
                    frm.Close();
                    DataTable zTable = TNS.Sensor.AccelGyro.SNO_MPU6050_AccessData.List(); 
                    LV_LoadData(zTable);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        { 
            FrmTableRecord frm = new FrmTableRecord(); //Tạo mới record
            frm.isUpdate = false;
            if (frm.ShowDialog() == DialogResult.OK) //Check kết nối
            {
                frm.Close();
                DataTable zTable = TNS.Sensor.AccelGyro.SNO_MPU6050_AccessData.List(); //Đẩy dữ liệu
                LV_LoadData(zTable);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string input = txt_search.Text.Trim(); // Lấy địa chỉ từ TextBox
            string dateFormat = "dd/MM/yyyy";
            string fromDate = dtp_fromday.Value.ToString(); // Lấy ngày bắt đầu từ DateTimePicker
            string toDate = dtp_today.Value.ToString(); // Lấy ngày kết thúc từ DateTimePicker
            DateTime date;
            DataTable searchResult;
            
            if (!string.IsNullOrEmpty(input) && DateTime.TryParseExact(input, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                // Kiểm tra nếu giá trị của input là ngày tháng hợp lệ
                searchResult = TNS.Sensor.AccelGyro.SNO_MPU6050_Record.Search_By_Day(input);
                // Gán dữ liệu vào ListView
            }
            else if (!string.IsNullOrEmpty(input))
            {
                // Giá trị của input là một địa chỉ
                searchResult = TNS.Sensor.AccelGyro.SNO_MPU6050_Record.Search_By_Address(input);
                // Gán dữ liệu vào ListView
            }
            else if (!string.IsNullOrEmpty(fromDate) && !string.IsNullOrEmpty(toDate))
            {
                // Kiểm tra nếu có giá trị cho cả fromDate và toDate
                searchResult = TNS.Sensor.AccelGyro.SNO_MPU6050_Record.Search_Between_Day(fromDate, toDate);
                // Gán dữ liệu vào ListView
            }
            else
            {
                // Xử lý trường hợp không nhập địa chỉ hoặc ngày
                return;
            }
            // Gán dữ liệu vào ListView
            LV_LoadData(searchResult);
        }
    }
}
