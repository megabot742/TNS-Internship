using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  TNS.VietTech.App
{
    public partial class FrmPort : Form
    {
        private Lib.UART_Setting _UART;
        //Đây là constructor của lớp FrmPort.
        //Nó khởi tạo một đối tượng FrmPort và gọi phương thức InitializeComponent() để khởi tạo các thành phần giao diện của form.
        public FrmPort()
        {
            InitializeComponent();
        }
        //private void FrmPort_Load(object sender, EventArgs e):
        //Đây là sự kiện Load của form. Trong sự kiện này, các thao tác cấu hình cổng COM được thực hiện:
        private void FrmPort_Load(object sender, EventArgs e)
        {
            //Phương thức này được gọi để tải danh sách các cổng COM khả dụng và đưa chúng vào combobox CoPortName
            LoadPorts();
            _UART = new Lib.UART_Setting(); //Khởi tạo đối tượng _UART từ lớp UART_Setting.
            //Thiết lập các giá trị của comboboxes
            if (CoPortName.Items.Count > 0) //CoPortName
            {
                if (_UART.PortName.Length > 0)
                {
                    CoPortName.Text = _UART.PortName;
                }
                else
                {
                    CoPortName.SelectedIndex = 0;
                }

            }

            CoBaudRate.Text = _UART.BaudRate.ToString(); //CoBaudRate
            CoDataBits.Text = _UART.DataBits.ToString(); //CoDataBits
            CoParity.SelectedIndex = _UART.Parity; //CoParity
            CoStopBits.SelectedIndex = _UART.StopBits; //CoStopBits
            //Kiểm tra trạng thái kết nối UART (biến IsOpen) và thay đổi nội dung của nút btn_Connect tương ứng.
            if (IsOpen)
            {
                btn_Connect.Text = "Disconnect";
            }
        }
        //LoadPorts()
        //Phương thức này xóa danh sách các cổng COM hiện có trong combobox CoPortName 
        private void LoadPorts()
        {
            CoPortName.Items.Clear();
            //Sau đó thêm các cổng COM khả dụng vào combobox đó bằng cách sử dụng phương thức SerialPort.GetPortNames().
            foreach (string s in SerialPort.GetPortNames())
            {
                CoPortName.Items.Add(s);
            }
        }
        //Đây là sự kiện xảy ra khi người dùng nhấp vào nút "Connect".
        //Trong sự kiện này, thông tin cấu hình UART được lấy từ các comboboxes và lưu vào đối tượng _UART.
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            _UART.PortName = CoPortName.Text;
            _UART.BaudRate = int.Parse(CoBaudRate.Text);
            _UART.DataBits = int.Parse(CoDataBits.Text);
            _UART.Parity = CoParity.SelectedIndex;
            _UART.StopBits = CoStopBits.SelectedIndex;
            //Phương thức _UART.Save() được gọi để lưu các thông số cấu hình vào cấu hình lưu trữ
            _UART.Save();
            //Đặt giá trị kết quả trả về của form là DialogResult.OK để chỉ ra rằng người dùng đã kết nối thành công.
            this.DialogResult = DialogResult.OK;
            //this.Close() được gọi để đóng form.
            this.Close();
        }
        //Đây là một thuộc tính chỉ đọc (getter) trả về đối tượng _UART.
        //Cho phép các lớp khác có thể truy cập vào thông số cấu hình UART sau khi form được đóng.
        public Lib.UART_Setting UART
        {
            get { return _UART; }
        }
        //public bool IsOpen { set;get; }: Đây là một thuộc tính cho phép gán (setter) và lấy giá trị (getter).
        //Nó được sử dụng để kiểm tra và thiết lập trạng thái kết nối UART
        public bool IsOpen { set;get; }
       

    }
}
