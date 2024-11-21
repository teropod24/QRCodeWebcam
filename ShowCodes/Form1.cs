using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;

namespace ShowCodes
{
    public partial class Form1 : Form
    {
        public string pass;
        public Form1()
        { 
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            HashSet<string> contraseñasGeneradas = new HashSet<string>(); // Almacena contraseñas únicas
            Login.Login login = new Login.Login();
            int colPass = rnd.Next(1,6);
            int rowPass = rnd.Next(1,5);

            for (int row = 1; row < 5; row++)
            {
                for (int col = 1; col < 6; col++)
                {
                    string contraseña;

                    do
                    {
                        contraseña = login.GenerarContraseña(4);
                    } while (contraseñasGeneradas.Contains(contraseña));

                    contraseñasGeneradas.Add(contraseña);

                    if (colPass == col && rowPass == row)
                    {
                        pass = contraseña;
                    }

                    Label label = new Label
                    {
                        
                        Text = $"({contraseña})",
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        BorderStyle = BorderStyle.FixedSingle,
                        Dock = DockStyle.Fill
                    };
                    tbly_Codes.Controls.Add(label, col, row);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pass);
        }
    }
}
