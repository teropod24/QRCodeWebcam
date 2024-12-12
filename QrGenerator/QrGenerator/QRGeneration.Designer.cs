
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
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(23, 424);
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
            this.label1.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR CODE";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.DimGray;
            this.pic.Location = new System.Drawing.Point(23, 63);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(428, 272);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // txtQrCode
            // 
            this.txtQrCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtQrCode.ForeColor = System.Drawing.Color.LightGreen;
            this.txtQrCode.Location = new System.Drawing.Point(23, 341);
            this.txtQrCode.Multiline = true;
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(428, 65);
            this.txtQrCode.TabIndex = 3;
            // 
            // btm_next
            // 
            this.btm_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btm_next.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_next.ForeColor = System.Drawing.Color.LightGreen;
            this.btm_next.Location = new System.Drawing.Point(241, 424);
            this.btm_next.Name = "btm_next";
            this.btm_next.Size = new System.Drawing.Size(210, 47);
            this.btm_next.TabIndex = 4;
            this.btm_next.Text = "Validated QR";
            this.btm_next.UseVisualStyleBackColor = false;
            this.btm_next.Click += new System.EventHandler(this.btm_next_Click);
            // 
            // QRGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 483);
            this.Controls.Add(this.btm_next);
            this.Controls.Add(this.txtQrCode);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QRGeneration";
            this.Text = "QR Generation";
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
    }
}

