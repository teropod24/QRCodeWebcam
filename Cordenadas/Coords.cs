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
            InicializarCoordenadas();
        }

        public void InicializarCoordenadas()
        {
            if (string.IsNullOrEmpty(PosicionCoord) || ValorCoord == 0)
            {
                Coords_Load(this, EventArgs.Empty); // Solo llama a Load si los valores no están inicializados
            }
        }

        private void Coords_Load(object sender, EventArgs e)
        {
            CoordenadasValores.Clear();

            HashSet<int> generatedNumbers = new HashSet<int>();
            Random random = new Random();

            for (int row = 1; row < 5; row++)
            {
                for (int col = 1; col < 6; col++)
                {
                    int number;

                    do
                    {
                        number = random.Next(0, 10000);
                    } while (generatedNumbers.Contains(number));

                    generatedNumbers.Add(number);

                    char letter = (char)('A' + row - 1);
                    string coord = $"{letter}{col}";

                    CoordenadasValores[coord] = number;

                    PosicionCoord = coord;
                    ValorCoord = number;

                    Label lbl = new Label();
                    lbl.ForeColor = Color.White;
                    if (number == ValorCoord)
                    {
                        lbl.BackColor = Color.Red;
                    }
                    lbl.Text = number.ToString();
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Dock = DockStyle.Fill;
                }
            }

            tbl_cordenadas.Show();
        }

        public string GenerarCoordenadas()
        {
            return PosicionCoord;  // Devuelve la coordenada seleccionada
        }

        public int GenerarValorCoordenadas()
        {
            return ValorCoord;  // Devuelve la coordenada seleccionada
        }

        private void btm_backMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

