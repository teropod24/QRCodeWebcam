
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
            this.gbx_coords = new System.Windows.Forms.GroupBox();
            this.btn_validar_coord = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_generate_Coords = new System.Windows.Forms.Label();
            this.lbl_coords = new System.Windows.Forms.Label();
            this.lbl_central = new System.Windows.Forms.Label();
            this.txt_coords = new System.Windows.Forms.TextBox();
            this.btm_iniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_contador = new System.Windows.Forms.Label();
            this.gbx_verification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_coords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.Enabled = false;
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
            this.gbx_verification.Location = new System.Drawing.Point(226, 68);
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
            this.lbl_authentification.Size = new System.Drawing.Size(145, 17);
            this.lbl_authentification.TabIndex = 1;
            this.lbl_authentification.Text = "Base Authentification:";
            // 
            // gbx_coords
            // 
            this.gbx_coords.Controls.Add(this.btn_validar_coord);
            this.gbx_coords.Controls.Add(this.pictureBox2);
            this.gbx_coords.Controls.Add(this.lbl_generate_Coords);
            this.gbx_coords.Controls.Add(this.lbl_coords);
            this.gbx_coords.Controls.Add(this.lbl_central);
            this.gbx_coords.Controls.Add(this.txt_coords);
            this.gbx_coords.Location = new System.Drawing.Point(226, 288);
            this.gbx_coords.Name = "gbx_coords";
            this.gbx_coords.Size = new System.Drawing.Size(634, 188);
            this.gbx_coords.TabIndex = 3;
            this.gbx_coords.TabStop = false;
            // 
            // btn_validar_coord
            // 
            this.btn_validar_coord.Enabled = false;
            this.btn_validar_coord.Location = new System.Drawing.Point(299, 96);
            this.btn_validar_coord.Name = "btn_validar_coord";
            this.btn_validar_coord.Size = new System.Drawing.Size(75, 23);
            this.btn_validar_coord.TabIndex = 5;
            this.btn_validar_coord.Text = "Validar";
            this.btn_validar_coord.UseVisualStyleBackColor = true;
            this.btn_validar_coord.Click += new System.EventHandler(this.btn_validar_coord_Click);
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
            // lbl_generate_Coords
            // 
            this.lbl_generate_Coords.AutoSize = true;
            this.lbl_generate_Coords.Location = new System.Drawing.Point(225, 102);
            this.lbl_generate_Coords.Name = "lbl_generate_Coords";
            this.lbl_generate_Coords.Size = new System.Drawing.Size(26, 17);
            this.lbl_generate_Coords.TabIndex = 3;
            this.lbl_generate_Coords.Text = "XX";
            // 
            // lbl_coords
            // 
            this.lbl_coords.AutoSize = true;
            this.lbl_coords.Location = new System.Drawing.Point(56, 133);
            this.lbl_coords.Name = "lbl_coords";
            this.lbl_coords.Size = new System.Drawing.Size(134, 17);
            this.lbl_coords.TabIndex = 2;
            this.lbl_coords.Text = "Code Coordenadas:";
            // 
            // lbl_central
            // 
            this.lbl_central.AutoSize = true;
            this.lbl_central.Location = new System.Drawing.Point(45, 61);
            this.lbl_central.Name = "lbl_central";
            this.lbl_central.Size = new System.Drawing.Size(158, 17);
            this.lbl_central.TabIndex = 1;
            this.lbl_central.Text = "Central Authentification:";
            // 
            // txt_coords
            // 
            this.txt_coords.Enabled = false;
            this.txt_coords.Location = new System.Drawing.Point(228, 133);
            this.txt_coords.Name = "txt_coords";
            this.txt_coords.Size = new System.Drawing.Size(204, 22);
            this.txt_coords.TabIndex = 0;
            // 
            // btm_iniciar
            // 
            this.btm_iniciar.Location = new System.Drawing.Point(12, 68);
            this.btm_iniciar.Name = "btm_iniciar";
            this.btm_iniciar.Size = new System.Drawing.Size(91, 40);
            this.btm_iniciar.TabIndex = 4;
            this.btm_iniciar.Text = "Iniciar";
            this.btm_iniciar.UseVisualStyleBackColor = true;
            this.btm_iniciar.Click += new System.EventHandler(this.btm_iniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_contador
            // 
            this.lbl_contador.AutoSize = true;
            this.lbl_contador.Location = new System.Drawing.Point(12, 138);
            this.lbl_contador.Name = "lbl_contador";
            this.lbl_contador.Size = new System.Drawing.Size(70, 17);
            this.lbl_contador.TabIndex = 5;
            this.lbl_contador.Text = "Contador:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 609);
            this.Controls.Add(this.lbl_contador);
            this.Controls.Add(this.btm_iniciar);
            this.Controls.Add(this.gbx_coords);
            this.Controls.Add(this.gbx_verification);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.gbx_verification.ResumeLayout(false);
            this.gbx_verification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_coords.ResumeLayout(false);
            this.gbx_coords.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbx_coords;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_coords;
        private System.Windows.Forms.Label lbl_central;
        private System.Windows.Forms.TextBox txt_coords;
        public System.Windows.Forms.Label lbl_generate_Coords;
        private System.Windows.Forms.Button btn_validar_coord;
        private System.Windows.Forms.Button btm_iniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_contador;
    }
}

