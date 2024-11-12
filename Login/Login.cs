using System;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;
using QRCodeWebcam;
using System.Text.RegularExpressions;

namespace Login
{
    public partial class Login : Form
    {
        SerialPort ArduinoPort = new SerialPort();
        string pasword;


        public Login()
        {

            InitializeComponent();

            ArduinoPort = new SerialPort();
        }

        private void ContecarArduino()
        {
            if (SerialPort.GetPortNames().Length > 0)
            {
                ArduinoPort.PortName = "COM6";
                ArduinoPort.BaudRate = 9600;

                ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DatosRecibidos);
                ArduinoPort.Open();
                ArduinoPort.WriteLine("S");

            }
            else
            {
                MessageBox.Show("¡No estas conectado!");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            ContecarArduino();

            pasword = GenerarContraseña();
            lbl_codigo.Text = pasword;

            EnviarPasswordAlArduino(pasword);
        }

        private void EnviarPasswordAlArduino(string password)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.WriteLine(password);
            }
        }

        private void DatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            string datosRecibidos = ArduinoPort.ReadLine().Trim();

            string[] partes = datosRecibidos.Split(':');
            if (partes.Length == 2)
            {
                string contrasenaRecibida = partes[0];
                bool passwordValido = partes[1] == "true";

                MessageBox.Show("Contraseña recibida: " + contrasenaRecibida);
                MessageBox.Show("Password válido: " + passwordValido);

                if (txt_pass.InvokeRequired)
                {
                    txt_pass.Invoke(new MethodInvoker(delegate
                    {
                        txt_pass.Text = contrasenaRecibida;
                    }));
                }
                else
                {
                    txt_pass.Text = contrasenaRecibida;
                }

                if (passwordValido)
                {
                    pictureBox1.Image = Image.FromFile("C:/S2AM/Arduino/fotos_validate/icono-check.png");
                    QRCodeWebcam.QRCodeWebcam qRCodeWebcam = new QRCodeWebcam.QRCodeWebcam();
                    qRCodeWebcam.ShowDialog();
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("C:/S2AM/Arduino/fotos_validate/incorrect.png");
                }
            }
        }

        private string GenerarContraseña()
        {
            string pass = "";
            int min = 0;
            int max = 9;
            Random rmd = new Random();

            for (int i = 0; i < 6; i++)
            {
                pass += rmd.Next(min, max);
            }

            return pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContecarArduino();
        }
    }
}
