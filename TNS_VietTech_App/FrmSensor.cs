using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO.Ports;
using System.Windows.Forms;
using TNS.Sensor.AccelGyro;

namespace TNS.VietTech.App
{
    public partial class FrmSensor : Form
    {
        //Khởi tạo đối tượng form và thực hiện việc cấu hình giao diện
        public FrmSensor()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            Layout_Init();
        }
        //Cài đặt các hình ảnh nền và hình ảnh cho các nút và logo trên giao diện.
        #region [ Layout ]
        private void Layout_Init()
        {

            this.BackgroundImage = Image.FromFile(@"Img\bg_01.png");
            this.btn_Setting.Image = Image.FromFile(@"Img\btn_SerialOff.png");
            this.btn_Exit.Image = Image.FromFile(@"Img\btn_PowerOff.png");
            this.Logo.Image = Image.FromFile(@"Img\TNS_Logo.png");
        }
        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            this.btn_Exit.Image = Image.FromFile(@"Img\btn_PowerOn.png");
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Exit.Image = Image.FromFile(@"Img\btn_PowerOff.png");
        }
        #endregion
        //Xử lý sự kiện khi form được tải lên. Cài đặt kích thước và vị trí của form dựa trên kích thước màn hình chính.
        //Khởi động một định thời để cập nhật dữ liệu trên giao diện.
        private void FrmSensor_Load(object sender, EventArgs e)
        {
            #region [ Window State ]
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = 0;
            this.Top = 0;
            #endregion

            Timer_ShowData.Start();
        }
        //Xử lý sự kiện khi form được vẽ. Vẽ các đối tượng và dữ liệu lên giao diện.
        private void FrmSensor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            Bitmap zDrawing = null;
            zDrawing = new Bitmap(this.Width, this.Height, e.Graphics);
            g = Graphics.FromImage(zDrawing);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            //=========================================================
            #region [ Window Data ]
            Font zData_Font = new System.Drawing.Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
            Font zData_Font_Title = new System.Drawing.Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush zData_Brush = new SolidBrush(Color.White);
            Point zData_Point = new Point(10, 500);
            StringFormat zData_Format = new StringFormat();
            zData_Format.Alignment = StringAlignment.Far;

            //g.DrawString(DateTime.Now.ToString("HH:mm:ss"), zData_Font_Title, zData_Brush, zData_Point);
            zData_Point.X = 100;
            zData_Point.Y += 15;
            // g.DrawString(_MPU6050_Data_Comming.ToString("#,##0"), zData_Font, zData_Brush, zData_Point, zData_Format);
            //g.DrawString(_Log_Data, zData_Font, zData_Brush, zData_Point);
            #endregion

            #region [ Window Log ]
            Font zLog_Font = new System.Drawing.Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            SolidBrush zLog_Brush = new SolidBrush(Color.White);
            Point zLog_Point = new Point(10, this.Height - 100);
            int n = _Log_Buffer.Count;
            if (n > 6)
            {
                _Log_Buffer.RemoveRange(0, n - 6);
                n = 6;
            }
            for (int i = 0; i < n; i++)
            {
                g.DrawString(_Log_Buffer[i], zLog_Font, zLog_Brush, zLog_Point);
                zLog_Point.Y += 15;
            }
            #endregion


            _MPU6050.Chart_UpdateData();
            g.DrawImage(_MPU6050.Chart_Ax("Box"), 10, 5);
            g.DrawImage(_MPU6050.Chart_Ay("Box"), 10, 205);
            g.DrawImage(_MPU6050.Chart_Az("Box"), 10, 405);

            g.DrawImage(_MPU6050.Chart_Gx("Box"), 520, 5);
            g.DrawImage(_MPU6050.Chart_Gy("Box"), 520, 205);
            g.DrawImage(_MPU6050.Chart_Gz("Box"), 520, 405);
            
            //========================================================
            e.Graphics.DrawImageUnscaled(zDrawing, 0, 0);
            g.Dispose();
        }
        //Xử lý sự kiện khi định thời Timer_ShowData kích hoạt. Gọi hàm Invalidate() để yêu cầu vẽ lại form.
        private void Timer_ShowData_Tick(object sender, EventArgs e)
        {
            Timer_ShowData.Stop();

           
            this.Invalidate();
            Timer_ShowData.Start();
        }

        #region [ Log ]
        private List<string> _Log_Buffer = new List<string>(); //Một danh sách lưu trữ các thông điệp log
        private string _Log_Data = ""; //Một biến lưu trữ dữ liệu log
        #endregion

        #region [ Sensor MPU6050 ]
        private TNS.Sensor.AccelGyro.Sensor _MPU6050 = new Sensor.AccelGyro.Sensor(); // Một đối tượng cảm biến MPU6050
        #endregion
        //Xử lý sự kiện khi nút "Setting" được nhấn.
        #region [ UART ]
        //Khai báo cho giao thức UART
        private byte STX = (byte)'{';
        private byte ETX = (byte)'}';
        private volatile List<byte> _UART_Buffer = new List<byte>();
        
        //Hiển thị một cửa sổ điều khiển COM port và cấu hình UART dựa trên thông tin nhập từ cửa sổ đó
        private void btn_Setting_Click(object sender, EventArgs e)
        {
            FrmPort frm = new FrmPort();
            if (UART.IsOpen)
                frm.IsOpen = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (!UART.IsOpen)
                {
                    if (frm.UART.PortName.Contains("COM"))
                    {
                        UART_Init(frm.UART);
                        this.btn_Setting.Image = Image.FromFile(@"Img\btn_SerialOn.png");
                        Timer_ShowData.Start();
                    }
                }
                else
                {
                    UART.Close();
                    this.btn_Setting.Image = Image.FromFile(@"Img\btn_SerialOff.png");
                    _Log_Buffer.Add("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] " + UART.PortName + " status close ");
                }
            }
        }
        //Thiết lập các thông số cho đối tượng UART
        private void UART_Init(Lib.UART_Setting Setting)
        {
            UART.PortName = Setting.PortName; //bao gồm cổng 
            UART.BaudRate = Setting.BaudRate; //tốc độ truyền
            UART.DataBits = Setting.DataBits; //bits dữ liệu
            UART.Parity = (Parity)Setting.Parity; //kiểm tra chẵn/lẻ
            UART.StopBits = (StopBits)Setting.StopBits; ; //bits dừng
            UART.DtrEnable = true;
            UART.RtsEnable = true;

            try
            {
                UART.Open(); //và mở cổng UART.
                _Log_Buffer.Add("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] " + UART.PortName + " opened");
            }
            catch (Exception ex)
            {
                //Log_Show(ex.ToString());
            }

        }
        //Xử lý sự kiện khi dữ liệu được nhận từ cổng UART. 
        private void UART_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Đọc các byte dữ liệu và xử lý gói tin dữ liệu nhận được
            while (UART.BytesToRead > 0)
            {
                byte zByteComming = (byte)UART.ReadByte();
                _UART_Buffer.Add(zByteComming);
                // _Log_Buffer.Add(Convert.ToChar(zByteComming).ToString());
                if (zByteComming == ETX)
                {
                    int zSTX_Index = _UART_Buffer.LastIndexOf(STX);
                    if (zSTX_Index < 0)
                    {
                        _UART_Buffer = new List<byte>();
                    }
                    else
                    {
                        List<byte> zPackData = new List<byte>();
                        for (int i = zSTX_Index + 1; i < _UART_Buffer.Count - 1; i++)
                        {
                            zPackData.Add(_UART_Buffer[i]);
                        }
                        _UART_Buffer = new List<byte>();
                        _MPU6050.PacketComming(zPackData);
                    }
                }

            }
        }
        //Xử lý sự kiện khi nút "Exit" được nhấn.Đóng ứng dụng.
        #endregion
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }

}
