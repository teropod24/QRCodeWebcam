
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
            this.components = new System.ComponentModel.Container();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbl_cordenadas.SuspendLayout();
            this.SuspendLayout();

            // Form properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 404);
            this.BackColor = System.Drawing.Color.Black;
            this.Text = "Coordenadas - Matrix Style";
            this.Load += new System.EventHandler(this.Coords_Load);

            // tbl_cordenadas properties
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
            this.tbl_cordenadas.BackColor = System.Drawing.Color.Black;

            // Label properties
            this.lbl_b.AutoSize = true;
            this.lbl_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_b.ForeColor = System.Drawing.Color.Lime;
            this.lbl_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_b.Text = "B";

            this.lbl_c.AutoSize = true;
            this.lbl_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_c.ForeColor = System.Drawing.Color.Lime;
            this.lbl_c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_c.Text = "C";

            this.lbl_d.AutoSize = true;
            this.lbl_d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_d.ForeColor = System.Drawing.Color.Lime;
            this.lbl_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_d.Text = "D";

            this.lbl_a.AutoSize = true;
            this.lbl_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_a.ForeColor = System.Drawing.Color.Lime;
            this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_a.Text = "A";

            this.lbl_uno.AutoSize = true;
            this.lbl_uno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_uno.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_uno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_uno.Text = "1";

            this.lbl_dos.AutoSize = true;
            this.lbl_dos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_dos.ForeColor = System.Drawing.Color.Orange;
            this.lbl_dos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dos.Text = "2";

            this.lbl_tres.AutoSize = true;
            this.lbl_tres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_tres.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_tres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_tres.Text = "3";

            this.lbl_cuatro.AutoSize = true;
            this.lbl_cuatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_cuatro.ForeColor = System.Drawing.Color.Orange;
            this.lbl_cuatro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cuatro.Text = "4";

            this.lbl_cinco.AutoSize = true;
            this.lbl_cinco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold);
            this.lbl_cinco.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_cinco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cinco.Text = "5";

            // Add controls to the form
            this.Controls.Add(this.tbl_cordenadas);
            this.tbl_cordenadas.ResumeLayout(false);
            this.tbl_cordenadas.PerformLayout();
            this.ResumeLayout(false);
        }



        #endregion
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
        private System.Windows.Forms.Timer timer1;
    }
}

