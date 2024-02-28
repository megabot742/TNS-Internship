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
        
        public FrmPort()
        {
            InitializeComponent();
        }

        private void FrmPort_Load(object sender, EventArgs e)
        {
            LoadPorts();
            _UART = new Lib.UART_Setting();
            if (CoPortName.Items.Count > 0)
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

            CoBaudRate.Text = _UART.BaudRate.ToString();
            CoDataBits.Text = _UART.DataBits.ToString();
            CoParity.SelectedIndex = _UART.Parity;
            CoStopBits.SelectedIndex = _UART.StopBits;
            if(IsOpen)
            {
                btn_Connect.Text = "Disconnect";
            }
        }
        private void LoadPorts()
        {
            CoPortName.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                CoPortName.Items.Add(s);
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            _UART.PortName = CoPortName.Text;
            _UART.BaudRate = int.Parse(CoBaudRate.Text);
            _UART.DataBits = int.Parse(CoDataBits.Text);
            _UART.Parity = CoParity.SelectedIndex;
            _UART.StopBits = CoStopBits.SelectedIndex;
            _UART.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public Lib.UART_Setting UART
        {
            get { return _UART; }
        }
        public bool IsOpen { set;get; }
       

    }
}
