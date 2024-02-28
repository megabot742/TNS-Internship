namespace  TNS.VietTech.App
{
    partial class FrmSensor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu_Left = new System.Windows.Forms.Panel();
            this.btn_Setting = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            this.Timer_ShowData = new System.Windows.Forms.Timer(this.components);
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Menu_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_Left
            // 
            this.Menu_Left.BackColor = System.Drawing.Color.Transparent;
            this.Menu_Left.Controls.Add(this.Logo);
            this.Menu_Left.Controls.Add(this.btn_Setting);
            this.Menu_Left.Controls.Add(this.btn_Exit);
            this.Menu_Left.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu_Left.Location = new System.Drawing.Point(710, 0);
            this.Menu_Left.Name = "Menu_Left";
            this.Menu_Left.Size = new System.Drawing.Size(90, 450);
            this.Menu_Left.TabIndex = 0;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Setting.Location = new System.Drawing.Point(0, 294);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(90, 78);
            this.btn_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Setting.TabIndex = 0;
            this.btn_Setting.TabStop = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Exit.Location = new System.Drawing.Point(0, 372);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 78);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.MouseLeave += new System.EventHandler(this.btn_Exit_MouseLeave);
            this.btn_Exit.MouseHover += new System.EventHandler(this.btn_Exit_MouseHover);
            // 
            // Timer_ShowData
            // 
            this.Timer_ShowData.Interval = 1;
            this.Timer_ShowData.Tick += new System.EventHandler(this.Timer_ShowData_Tick);
            // 
            // UART
            // 
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_DataReceived);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(90, 78);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // FrmSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Menu_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSensor";
            this.Load += new System.EventHandler(this.FrmSensor_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmSensor_Paint);
            this.Menu_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_Left;
        private System.Windows.Forms.PictureBox btn_Setting;
        private System.Windows.Forms.Timer Timer_ShowData;
        private System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.PictureBox btn_Exit;
        private System.Windows.Forms.PictureBox Logo;
    }
}