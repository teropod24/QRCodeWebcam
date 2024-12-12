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

        private string Coordenadas;
        private DateTime tiempoIncial;
        private int contador = 10000;
        public Dictionary<string, int> CoordenadasValores { get; private set; } = new Dictionary<string, int>();

        public string coordenadas
        {
            get { return Coordenadas; }
            set { Coordenadas = value; }
        }


        public Coords()
        {
            InitializeComponent();
            timer1.Interval = 10;
            tiempoIncial = DateTime.Now;
            timer1.Start();
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

                    Label lbl = new Label();
                    lbl.Text = number.ToString("D4");
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Dock = DockStyle.Fill;

                    tbl_cordenadas.Controls.Add(lbl, col, row);

                    char letter = (char)('A' + row - 1);
                    string coord = $"{letter}{col}";

                    CoordenadasValores[coord] = number;
                }
            }

            tbl_cordenadas.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = DateTime.Now - tiempoIncial;
            int milisegundosRestantes = contador - (int)tiempoTranscurrido.TotalMilliseconds;

            if (milisegundosRestantes <= 0)
            {
                timer1.Stop();
                Close();
            }
        }

    }
}

