using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cordenadas
{
    public partial class Coords : Form
    {
        public Dictionary<string, int> CoordenadasValores { get; private set; } = new Dictionary<string, int>();
        public int ValorCoord { get; set; }
        public string PosicionCoord { get; set; }
        public Coords()
        {
            InitializeComponent();
        }

        private void Coords_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PosicionCoord) && ValorCoord != 0)
            {
                return; // Salir para evitar reinicialización
            };
            HashSet<int> generatedNumbers = new HashSet<int>();
            Random random = new Random();
            CoordenadasValores.Clear();
            tbl_cordenadas.Controls.Clear();

            int rows = 5;
            int cols = 6;


            int randomRow = random.Next(1, rows);
            int randomCol = random.Next(1, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Label lbl = new Label
                    {
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                    };

                    if (row == 0 && col > 0)
                    {
                        lbl.Text = col.ToString();
                        lbl.BackColor = Color.Gray;
                    }
                    else if (col == 0 && row > 0)
                    {
                        lbl.Text = ((char)('A' + row - 1)).ToString();
                        lbl.BackColor = Color.Gray;
                    }
                    else if (row > 0 && col > 0)
                    {
                        int number;

                        do
                        {
                            number = random.Next(0, 10000);
                        } while (generatedNumbers.Contains(number));
                        generatedNumbers.Add(number);

                        lbl.Text = number.ToString();

                        string coord = $"{(char)('A' + row - 1)}{col}";
                        CoordenadasValores[coord] = number;

                        if (row == randomRow && col == randomCol)
                        {
                            PosicionCoord = coord;
                            ValorCoord = number;
                            lbl.BackColor = Color.Red;
                        }
                    }

                    tbl_cordenadas.Controls.Add(lbl, col, row);
                }
            }
        }

        public string GenerarCoordenadas()
        {
            return PosicionCoord;
        }

        public int GenerarValorCoordenadas()
        {
            return ValorCoord;
        }

        private void btm_backMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

