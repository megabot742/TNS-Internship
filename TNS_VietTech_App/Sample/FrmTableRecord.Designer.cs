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
            this.dt_TimeDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_GyroX = new System.Windows.Forms.TextBox();
            this.txt_GyroY = new System.Windows.Forms.TextBox();
            this.txt_GyroZ = new System.Windows.Forms.TextBox();
            this.txt_AccelX = new System.Windows.Forms.TextBox();
            this.txt_AccelY = new System.Windows.Forms.TextBox();
            this.txt_AccelZ = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_new);
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
            this.btn_Delete.Location = new System.Drawing.Point(408, 14);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 35);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dt_TimeDate
            // 
            this.dt_TimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_TimeDate.Location = new System.Drawing.Point(543, 61);
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
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(22, 83);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 20);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gyro_X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gyro_Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gyro_Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Accel_X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Accel_Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Accel_Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "DateTime";
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.Maroon;
            this.btn_new.Location = new System.Drawing.Point(590, 14);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(112, 35);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "Làm mới";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // FrmTableRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.dt_TimeDate);
            this.Controls.Add(this.txt_AccelZ);
            this.Controls.Add(this.txt_AccelY);
            this.Controls.Add(this.txt_AccelX);
            this.Controls.Add(this.txt_GyroZ);
            this.Controls.Add(this.txt_GyroY);
            this.Controls.Add(this.txt_GyroX);
            this.Controls.Add(this.txt_Address);
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
        private System.Windows.Forms.DateTimePicker dt_TimeDate;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_GyroX;
        private System.Windows.Forms.TextBox txt_GyroY;
        private System.Windows.Forms.TextBox txt_GyroZ;
        private System.Windows.Forms.TextBox txt_AccelX;
        private System.Windows.Forms.TextBox txt_AccelY;
        private System.Windows.Forms.TextBox txt_AccelZ;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_new;
    }
}