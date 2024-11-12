
namespace QRCodeWebcam
{
    partial class QRCodeWebcam
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lab_camera = new System.Windows.Forms.Label();
            this.cbo_Device = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_QRCode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_timer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(547, 75);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 27);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start:";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lab_camera
            // 
            this.lab_camera.AutoSize = true;
            this.lab_camera.Location = new System.Drawing.Point(42, 30);
            this.lab_camera.Name = "lab_camera";
            this.lab_camera.Size = new System.Drawing.Size(61, 17);
            this.lab_camera.TabIndex = 1;
            this.lab_camera.Text = "Camera:";
            // 
            // cbo_Device
            // 
            this.cbo_Device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Device.FormattingEnabled = true;
            this.cbo_Device.Location = new System.Drawing.Point(109, 27);
            this.cbo_Device.Name = "cbo_Device";
            this.cbo_Device.Size = new System.Drawing.Size(380, 24);
            this.cbo_Device.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 363);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txt_QRCode
            // 
            this.txt_QRCode.Location = new System.Drawing.Point(547, 108);
            this.txt_QRCode.Multiline = true;
            this.txt_QRCode.Name = "txt_QRCode";
            this.txt_QRCode.ReadOnly = true;
            this.txt_QRCode.Size = new System.Drawing.Size(314, 192);
            this.txt_QRCode.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_timer
            // 
            this.lab_timer.AutoSize = true;
            this.lab_timer.Location = new System.Drawing.Point(544, 320);
            this.lab_timer.Name = "lab_timer";
            this.lab_timer.Size = new System.Drawing.Size(68, 17);
            this.lab_timer.TabIndex = 5;
            this.lab_timer.Text = "contador:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "QR Generation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QRCodeWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_timer);
            this.Controls.Add(this.txt_QRCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbo_Device);
            this.Controls.Add(this.lab_camera);
            this.Controls.Add(this.btn_Start);
            this.Name = "QRCodeWebcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lab_camera;
        private System.Windows.Forms.ComboBox cbo_Device;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_QRCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_timer;
        private System.Windows.Forms.Button button1;
    }
}

