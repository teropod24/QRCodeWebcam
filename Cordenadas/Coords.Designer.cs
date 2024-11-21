
namespace Cordenadas
{
    partial class Coords
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.tbl_cordenadas = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_uno = new System.Windows.Forms.Label();
            this.lbl_dos = new System.Windows.Forms.Label();
            this.lbl_tres = new System.Windows.Forms.Label();
            this.lbl_cuatro = new System.Windows.Forms.Label();
            this.lbl_cinco = new System.Windows.Forms.Label();
            this.tbl_cordenadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(186, 46);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(103, 33);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(431, 46);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(103, 33);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // tbl_cordenadas
            // 
            this.tbl_cordenadas.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbl_cordenadas.ColumnCount = 6;
            this.tbl_cordenadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_cordenadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_cordenadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_cordenadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_cordenadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_cordenadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_cordenadas.Controls.Add(this.lbl_b, 0, 2);
            this.tbl_cordenadas.Controls.Add(this.lbl_c, 0, 3);
            this.tbl_cordenadas.Controls.Add(this.lbl_d, 0, 4);
            this.tbl_cordenadas.Controls.Add(this.lbl_a, 0, 1);
            this.tbl_cordenadas.Controls.Add(this.lbl_uno, 1, 0);
            this.tbl_cordenadas.Controls.Add(this.lbl_dos, 2, 0);
            this.tbl_cordenadas.Controls.Add(this.lbl_tres, 3, 0);
            this.tbl_cordenadas.Controls.Add(this.lbl_cuatro, 4, 0);
            this.tbl_cordenadas.Controls.Add(this.lbl_cinco, 5, 0);
            this.tbl_cordenadas.Location = new System.Drawing.Point(12, 99);
            this.tbl_cordenadas.Name = "tbl_cordenadas";
            this.tbl_cordenadas.RowCount = 5;
            this.tbl_cordenadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_cordenadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_cordenadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_cordenadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_cordenadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_cordenadas.Size = new System.Drawing.Size(694, 293);
            this.tbl_cordenadas.TabIndex = 2;
            this.tbl_cordenadas.Visible = false;
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b.Location = new System.Drawing.Point(4, 117);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(108, 57);
            this.lbl_b.TabIndex = 0;
            this.lbl_b.Text = "B";
            this.lbl_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c.Location = new System.Drawing.Point(4, 175);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(108, 57);
            this.lbl_c.TabIndex = 1;
            this.lbl_c.Text = "C";
            this.lbl_c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_d.Location = new System.Drawing.Point(4, 233);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(108, 59);
            this.lbl_d.TabIndex = 2;
            this.lbl_d.Text = "D";
            this.lbl_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.Location = new System.Drawing.Point(4, 59);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(108, 57);
            this.lbl_a.TabIndex = 3;
            this.lbl_a.Text = "A";
            this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_uno
            // 
            this.lbl_uno.AutoSize = true;
            this.lbl_uno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uno.Location = new System.Drawing.Point(119, 1);
            this.lbl_uno.Name = "lbl_uno";
            this.lbl_uno.Size = new System.Drawing.Size(108, 57);
            this.lbl_uno.TabIndex = 4;
            this.lbl_uno.Text = "1";
            this.lbl_uno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dos
            // 
            this.lbl_dos.AutoSize = true;
            this.lbl_dos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dos.Location = new System.Drawing.Point(234, 1);
            this.lbl_dos.Name = "lbl_dos";
            this.lbl_dos.Size = new System.Drawing.Size(108, 57);
            this.lbl_dos.TabIndex = 5;
            this.lbl_dos.Text = "2";
            this.lbl_dos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tres
            // 
            this.lbl_tres.AutoSize = true;
            this.lbl_tres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tres.Location = new System.Drawing.Point(349, 1);
            this.lbl_tres.Name = "lbl_tres";
            this.lbl_tres.Size = new System.Drawing.Size(108, 57);
            this.lbl_tres.TabIndex = 6;
            this.lbl_tres.Text = "3";
            this.lbl_tres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cuatro
            // 
            this.lbl_cuatro.AutoSize = true;
            this.lbl_cuatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuatro.Location = new System.Drawing.Point(464, 1);
            this.lbl_cuatro.Name = "lbl_cuatro";
            this.lbl_cuatro.Size = new System.Drawing.Size(108, 57);
            this.lbl_cuatro.TabIndex = 7;
            this.lbl_cuatro.Text = "4";
            this.lbl_cuatro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cinco
            // 
            this.lbl_cinco.AutoSize = true;
            this.lbl_cinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinco.Location = new System.Drawing.Point(579, 1);
            this.lbl_cinco.Name = "lbl_cinco";
            this.lbl_cinco.Size = new System.Drawing.Size(111, 57);
            this.lbl_cinco.TabIndex = 8;
            this.lbl_cinco.Text = "5";
            this.lbl_cinco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Coords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 404);
            this.Controls.Add(this.tbl_cordenadas);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_generate);
            this.Name = "Coords";
            this.Text = "Coordenadas";
            this.tbl_cordenadas.ResumeLayout(false);
            this.tbl_cordenadas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TableLayoutPanel tbl_cordenadas;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_uno;
        private System.Windows.Forms.Label lbl_dos;
        private System.Windows.Forms.Label lbl_tres;
        private System.Windows.Forms.Label lbl_cuatro;
        private System.Windows.Forms.Label lbl_cinco;
    }
}

