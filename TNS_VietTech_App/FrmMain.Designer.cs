namespace TNS.VietTech.App
{
    partial class FrmMain
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
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Motor = new System.Windows.Forms.Button();
            this.btn_MPU6050 = new System.Windows.Forms.Button();
            this.btn_Accle_Gyro = new System.Windows.Forms.Button();
            this.btn_Ultrasonic = new System.Windows.Forms.Button();
            this.btn_Lidar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_Motor);
            this.panel1.Controls.Add(this.btn_MPU6050);
            this.panel1.Controls.Add(this.btn_Accle_Gyro);
            this.panel1.Controls.Add(this.btn_Ultrasonic);
            this.panel1.Controls.Add(this.btn_Lidar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(593, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 450);
            this.panel1.TabIndex = 1;
            // 
            // btn_Motor
            // 
            this.btn_Motor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Motor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Motor.ForeColor = System.Drawing.Color.Navy;
            this.btn_Motor.Location = new System.Drawing.Point(0, 152);
            this.btn_Motor.Name = "btn_Motor";
            this.btn_Motor.Size = new System.Drawing.Size(207, 38);
            this.btn_Motor.TabIndex = 4;
            this.btn_Motor.Text = "Motor";
            this.btn_Motor.UseVisualStyleBackColor = true;
            // 
            // btn_MPU6050
            // 
            this.btn_MPU6050.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MPU6050.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MPU6050.ForeColor = System.Drawing.Color.Navy;
            this.btn_MPU6050.Location = new System.Drawing.Point(0, 114);
            this.btn_MPU6050.Name = "btn_MPU6050";
            this.btn_MPU6050.Size = new System.Drawing.Size(207, 38);
            this.btn_MPU6050.TabIndex = 3;
            this.btn_MPU6050.Text = "MPU6050";
            this.btn_MPU6050.UseVisualStyleBackColor = true;
            // 
            // btn_Accle_Gyro
            // 
            this.btn_Accle_Gyro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Accle_Gyro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accle_Gyro.ForeColor = System.Drawing.Color.Navy;
            this.btn_Accle_Gyro.Location = new System.Drawing.Point(0, 76);
            this.btn_Accle_Gyro.Name = "btn_Accle_Gyro";
            this.btn_Accle_Gyro.Size = new System.Drawing.Size(207, 38);
            this.btn_Accle_Gyro.TabIndex = 2;
            this.btn_Accle_Gyro.Text = "Accle Gyro";
            this.btn_Accle_Gyro.UseVisualStyleBackColor = true;
            // 
            // btn_Ultrasonic
            // 
            this.btn_Ultrasonic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ultrasonic.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ultrasonic.ForeColor = System.Drawing.Color.Navy;
            this.btn_Ultrasonic.Location = new System.Drawing.Point(0, 38);
            this.btn_Ultrasonic.Name = "btn_Ultrasonic";
            this.btn_Ultrasonic.Size = new System.Drawing.Size(207, 38);
            this.btn_Ultrasonic.TabIndex = 1;
            this.btn_Ultrasonic.Text = "Ultrasonic";
            this.btn_Ultrasonic.UseVisualStyleBackColor = true;
            // 
            // btn_Lidar
            // 
            this.btn_Lidar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Lidar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lidar.ForeColor = System.Drawing.Color.Navy;
            this.btn_Lidar.Location = new System.Drawing.Point(0, 0);
            this.btn_Lidar.Name = "btn_Lidar";
            this.btn_Lidar.Size = new System.Drawing.Size(207, 38);
            this.btn_Lidar.TabIndex = 0;
            this.btn_Lidar.Text = "Lidar";
            this.btn_Lidar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Lidar;
        private System.Windows.Forms.Button btn_Ultrasonic;
        private System.Windows.Forms.Button btn_Accle_Gyro;
        private System.Windows.Forms.Button btn_MPU6050;
        private System.Windows.Forms.Button btn_Motor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

