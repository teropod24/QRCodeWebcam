
namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.gbx_verification = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_otp_code = new System.Windows.Forms.Label();
            this.lbl_authentification = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contadorTimer = new System.Windows.Forms.Label();
            this.iniciarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbx_verification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(228, 133);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(204, 22);
            this.txt_pass.TabIndex = 0;
            // 
            // gbx_verification
            // 
            this.gbx_verification.Controls.Add(this.pictureBox1);
            this.gbx_verification.Controls.Add(this.lbl_codigo);
            this.gbx_verification.Controls.Add(this.lbl_otp_code);
            this.gbx_verification.Controls.Add(this.lbl_authentification);
            this.gbx_verification.Controls.Add(this.txt_pass);
            this.gbx_verification.Enabled = false;
            this.gbx_verification.Location = new System.Drawing.Point(56, 122);
            this.gbx_verification.Name = "gbx_verification";
            this.gbx_verification.Size = new System.Drawing.Size(634, 188);
            this.gbx_verification.TabIndex = 2;
            this.gbx_verification.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(225, 102);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(26, 17);
            this.lbl_codigo.TabIndex = 3;
            this.lbl_codigo.Text = "XX";
            // 
            // lbl_otp_code
            // 
            this.lbl_otp_code.AutoSize = true;
            this.lbl_otp_code.Location = new System.Drawing.Point(92, 133);
            this.lbl_otp_code.Name = "lbl_otp_code";
            this.lbl_otp_code.Size = new System.Drawing.Size(78, 17);
            this.lbl_otp_code.TabIndex = 2;
            this.lbl_otp_code.Text = "OTP Code:";
            // 
            // lbl_authentification
            // 
            this.lbl_authentification.AutoSize = true;
            this.lbl_authentification.Location = new System.Drawing.Point(45, 61);
            this.lbl_authentification.Name = "lbl_authentification";
            this.lbl_authentification.Size = new System.Drawing.Size(137, 17);
            this.lbl_authentification.TabIndex = 1;
            this.lbl_authentification.Text = "Base Authntification:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contadorTimer
            // 
            this.contadorTimer.AutoSize = true;
            this.contadorTimer.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorTimer.Location = new System.Drawing.Point(12, 9);
            this.contadorTimer.Name = "contadorTimer";
            this.contadorTimer.Size = new System.Drawing.Size(100, 35);
            this.contadorTimer.TabIndex = 4;
            this.contadorTimer.Text = "30:00";
            // 
            // iniciarBtn
            // 
            this.iniciarBtn.Location = new System.Drawing.Point(615, 93);
            this.iniciarBtn.Name = "iniciarBtn";
            this.iniciarBtn.Size = new System.Drawing.Size(75, 23);
            this.iniciarBtn.TabIndex = 5;
            this.iniciarBtn.Text = "Iniciar";
            this.iniciarBtn.UseVisualStyleBackColor = true;
            this.iniciarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(56, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(484, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "XX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "OTP Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Base Authntification:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iniciarBtn);
            this.Controls.Add(this.contadorTimer);
            this.Controls.Add(this.gbx_verification);
            this.Name = "Login";
            this.Text = "Form1";
            this.gbx_verification.ResumeLayout(false);
            this.gbx_verification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.GroupBox gbx_verification;
        private System.Windows.Forms.Label lbl_otp_code;
        private System.Windows.Forms.Label lbl_authentification;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label contadorTimer;
        private System.Windows.Forms.Button iniciarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

