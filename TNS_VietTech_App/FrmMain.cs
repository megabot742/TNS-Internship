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

namespace TNS.VietTech.App
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void ShowMessage(string Message)
        {
            Invoke(new MethodInvoker(delegate
            {
                //LB_Log.Items.Add(DateTime.Now.ToString("dd-MM-yy hh:mm:ss.fff") + " : " + Message);

            }));
        }

      
    }
}
