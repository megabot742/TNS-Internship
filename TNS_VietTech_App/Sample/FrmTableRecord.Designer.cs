namespace TNS.VietTech.App
{
    partial class FrmTableRecord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_AutoKey = new System.Windows.Forms.TextBox();
            this.dt_TimeDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_GyroX = new System.Windows.Forms.TextBox();
            this.txt_GyroY = new System.Windows.Forms.TextBox();
            this.txt_GyroZ = new System.Windows.Forms.TextBox();
            this.txt_AccelX = new System.Windows.Forms.TextBox();
            this.txt_AccelY = new System.Windows.Forms.TextBox();
            this.txt_AccelZ = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 60);
            this.panel1.TabIndex = 5;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Update.Location = new System.Drawing.Point(213, 14);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(112, 35);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Delete.Location = new System.Drawing.Point(505, 14);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 35);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_AutoKey
            // 
            this.txt_AutoKey.Enabled = false;
            this.txt_AutoKey.Location = new System.Drawing.Point(131, 30);
            this.txt_AutoKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AutoKey.Name = "txt_AutoKey";
            this.txt_AutoKey.Size = new System.Drawing.Size(257, 26);
            this.txt_AutoKey.TabIndex = 6;
            this.txt_AutoKey.Visible = false;
            // 
            // dt_TimeDate
            // 
            this.dt_TimeDate.Location = new System.Drawing.Point(515, 40);
            this.dt_TimeDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_TimeDate.Name = "dt_TimeDate";
            this.dt_TimeDate.Size = new System.Drawing.Size(257, 26);
            this.dt_TimeDate.TabIndex = 8;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(131, 83);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(257, 26);
            this.txt_Address.TabIndex = 6;
            // 
            // txt_GyroX
            // 
            this.txt_GyroX.Location = new System.Drawing.Point(131, 160);
            this.txt_GyroX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GyroX.Name = "txt_GyroX";
            this.txt_GyroX.Size = new System.Drawing.Size(257, 26);
            this.txt_GyroX.TabIndex = 6;
            // 
            // txt_GyroY
            // 
            this.txt_GyroY.Location = new System.Drawing.Point(131, 211);
            this.txt_GyroY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GyroY.Name = "txt_GyroY";
            this.txt_GyroY.Size = new System.Drawing.Size(257, 26);
            this.txt_GyroY.TabIndex = 6;
            // 
            // txt_GyroZ
            // 
            this.txt_GyroZ.Location = new System.Drawing.Point(131, 269);
            this.txt_GyroZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GyroZ.Name = "txt_GyroZ";
            this.txt_GyroZ.Size = new System.Drawing.Size(257, 26);
            this.txt_GyroZ.TabIndex = 6;
            // 
            // txt_AccelX
            // 
            this.txt_AccelX.Location = new System.Drawing.Point(543, 160);
            this.txt_AccelX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AccelX.Name = "txt_AccelX";
            this.txt_AccelX.Size = new System.Drawing.Size(257, 26);
            this.txt_AccelX.TabIndex = 6;
            // 
            // txt_AccelY
            // 
            this.txt_AccelY.Location = new System.Drawing.Point(543, 211);
            this.txt_AccelY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AccelY.Name = "txt_AccelY";
            this.txt_AccelY.Size = new System.Drawing.Size(257, 26);
            this.txt_AccelY.TabIndex = 6;
            // 
            // txt_AccelZ
            // 
            this.txt_AccelZ.Location = new System.Drawing.Point(543, 269);
            this.txt_AccelZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_AccelZ.Name = "txt_AccelZ";
            this.txt_AccelZ.Size = new System.Drawing.Size(257, 26);
            this.txt_AccelZ.TabIndex = 6;
            // 
            // FrmTableRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 466);
            this.Controls.Add(this.dt_TimeDate);
            this.Controls.Add(this.txt_AccelZ);
            this.Controls.Add(this.txt_AccelY);
            this.Controls.Add(this.txt_AccelX);
            this.Controls.Add(this.txt_GyroZ);
            this.Controls.Add(this.txt_GyroY);
            this.Controls.Add(this.txt_GyroX);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_AutoKey);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTableRecord";
            this.Text = "Frm_Table_Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTableRecord_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_AutoKey;
        private System.Windows.Forms.DateTimePicker dt_TimeDate;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_GyroX;
        private System.Windows.Forms.TextBox txt_GyroY;
        private System.Windows.Forms.TextBox txt_GyroZ;
        private System.Windows.Forms.TextBox txt_AccelX;
        private System.Windows.Forms.TextBox txt_AccelY;
        private System.Windows.Forms.TextBox txt_AccelZ;
    }
}