
namespace QrGenerator
{
    partial class QRGeneration
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.txtQrCode = new System.Windows.Forms.TextBox();
            this.btm_next = new System.Windows.Forms.Button();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Planeta = new System.Windows.Forms.TextBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btm_validarUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(772, 861);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Qr";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(777, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR CODE";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.DimGray;
            this.pic.Location = new System.Drawing.Point(772, 500);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(428, 272);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // txtQrCode
            // 
            this.txtQrCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtQrCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQrCode.ForeColor = System.Drawing.Color.LightGreen;
            this.txtQrCode.Location = new System.Drawing.Point(772, 778);
            this.txtQrCode.Multiline = true;
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(428, 65);
            this.txtQrCode.TabIndex = 3;
            // 
            // btm_next
            // 
            this.btm_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btm_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_next.ForeColor = System.Drawing.Color.LightGreen;
            this.btm_next.Location = new System.Drawing.Point(990, 861);
            this.btm_next.Name = "btm_next";
            this.btm_next.Size = new System.Drawing.Size(210, 47);
            this.btm_next.TabIndex = 4;
            this.btm_next.Text = "Validated QR";
            this.btm_next.UseVisualStyleBackColor = false;
            this.btm_next.Click += new System.EventHandler(this.btm_next_Click);
            // 
            // txt_Edad
            // 
            this.txt_Edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Edad.ForeColor = System.Drawing.Color.LightGreen;
            this.txt_Edad.Location = new System.Drawing.Point(772, 206);
            this.txt_Edad.Multiline = true;
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.ReadOnly = true;
            this.txt_Edad.Size = new System.Drawing.Size(428, 34);
            this.txt_Edad.TabIndex = 5;
            this.txt_Edad.TabStop = false;
            // 
            // txt_Planeta
            // 
            this.txt_Planeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_Planeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Planeta.ForeColor = System.Drawing.Color.LightGreen;
            this.txt_Planeta.Location = new System.Drawing.Point(772, 246);
            this.txt_Planeta.Multiline = true;
            this.txt_Planeta.Name = "txt_Planeta";
            this.txt_Planeta.ReadOnly = true;
            this.txt_Planeta.Size = new System.Drawing.Size(428, 34);
            this.txt_Planeta.TabIndex = 6;
            this.txt_Planeta.TabStop = false;
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.ForeColor = System.Drawing.Color.LightGreen;
            this.txt_fecha.Location = new System.Drawing.Point(772, 286);
            this.txt_fecha.Multiline = true;
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(428, 34);
            this.txt_fecha.TabIndex = 7;
            this.txt_fecha.TabStop = false;
            // 
            // txt_Desc
            // 
            this.txt_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Desc.ForeColor = System.Drawing.Color.LightGreen;
            this.txt_Desc.Location = new System.Drawing.Point(772, 326);
            this.txt_Desc.Multiline = true;
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.ReadOnly = true;
            this.txt_Desc.Size = new System.Drawing.Size(428, 34);
            this.txt_Desc.TabIndex = 8;
            this.txt_Desc.TabStop = false;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.LightGreen;
            this.txt_user.Location = new System.Drawing.Point(772, 166);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(428, 34);
            this.txt_user.TabIndex = 9;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Orange;
            this.lbl_user.Location = new System.Drawing.Point(702, 166);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(70, 29);
            this.lbl_user.TabIndex = 11;
            this.lbl_user.Text = "User:";
            // 
            // btm_validarUser
            // 
            this.btm_validarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btm_validarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_validarUser.ForeColor = System.Drawing.Color.LightGreen;
            this.btm_validarUser.Location = new System.Drawing.Point(990, 377);
            this.btm_validarUser.Name = "btm_validarUser";
            this.btm_validarUser.Size = new System.Drawing.Size(210, 47);
            this.btm_validarUser.TabIndex = 12;
            this.btm_validarUser.Text = "Validated User";
            this.btm_validarUser.UseVisualStyleBackColor = false;
            this.btm_validarUser.Click += new System.EventHandler(this.btm_validarUser_Click);
            // 
            // QRGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1940, 1080);
            this.Controls.Add(this.btm_validarUser);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_Planeta);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.btm_next);
            this.Controls.Add(this.txtQrCode);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QRGeneration";
            this.Text = "QR Generation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox txtQrCode;
        private System.Windows.Forms.Button btm_next;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Planeta;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btm_validarUser;
    }
}

