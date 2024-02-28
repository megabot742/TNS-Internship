namespace  TNS.VietTech.App
{
    partial class FrmPort
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
            this.CoPortName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CoStopBits = new System.Windows.Forms.ComboBox();
            this.CoBaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CoParity = new System.Windows.Forms.ComboBox();
            this.CoDataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CoPortName
            // 
            this.CoPortName.Font = new System.Drawing.Font("Arial", 9F);
            this.CoPortName.FormattingEnabled = true;
            this.CoPortName.Location = new System.Drawing.Point(90, 13);
            this.CoPortName.Name = "CoPortName";
            this.CoPortName.Size = new System.Drawing.Size(118, 23);
            this.CoPortName.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.Location = new System.Drawing.Point(15, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Stop bit";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Connect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.ForeColor = System.Drawing.Color.Navy;
            this.btn_Connect.Location = new System.Drawing.Point(0, 174);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(226, 35);
            this.btn_Connect.TabIndex = 23;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(15, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Port Name ";
            // 
            // CoStopBits
            // 
            this.CoStopBits.Font = new System.Drawing.Font("Arial", 9F);
            this.CoStopBits.FormattingEnabled = true;
            this.CoStopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "1.5"});
            this.CoStopBits.Location = new System.Drawing.Point(90, 132);
            this.CoStopBits.Name = "CoStopBits";
            this.CoStopBits.Size = new System.Drawing.Size(118, 23);
            this.CoStopBits.TabIndex = 32;
            // 
            // CoBaudRate
            // 
            this.CoBaudRate.Font = new System.Drawing.Font("Arial", 9F);
            this.CoBaudRate.FormattingEnabled = true;
            this.CoBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230600"});
            this.CoBaudRate.Location = new System.Drawing.Point(90, 43);
            this.CoBaudRate.Name = "CoBaudRate";
            this.CoBaudRate.Size = new System.Drawing.Size(118, 23);
            this.CoBaudRate.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Parity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(15, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Baud Rate";
            // 
            // CoParity
            // 
            this.CoParity.Font = new System.Drawing.Font("Arial", 9F);
            this.CoParity.FormattingEnabled = true;
            this.CoParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CoParity.Location = new System.Drawing.Point(90, 103);
            this.CoParity.Name = "CoParity";
            this.CoParity.Size = new System.Drawing.Size(118, 23);
            this.CoParity.TabIndex = 30;
            // 
            // CoDataBits
            // 
            this.CoDataBits.Font = new System.Drawing.Font("Arial", 9F);
            this.CoDataBits.FormattingEnabled = true;
            this.CoDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CoDataBits.Location = new System.Drawing.Point(90, 73);
            this.CoDataBits.Name = "CoDataBits";
            this.CoDataBits.Size = new System.Drawing.Size(118, 23);
            this.CoDataBits.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data bits";
            // 
            // FrmPort
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(226, 209);
            this.Controls.Add(this.CoPortName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CoStopBits);
            this.Controls.Add(this.CoBaudRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CoParity);
            this.Controls.Add(this.CoDataBits);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPort";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CoPortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CoStopBits;
        private System.Windows.Forms.ComboBox CoBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CoParity;
        private System.Windows.Forms.ComboBox CoDataBits;
        private System.Windows.Forms.Label label6;
    }
}