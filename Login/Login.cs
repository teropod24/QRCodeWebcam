using System;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;
using QRCodeWebcam;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Cordenadas;

namespace Login
{
    public partial class Login : Form
    {
        SerialPort ArduinoPort = new SerialPort();
        string pasword;
        private int passwordcadena = 6;

        private Coords coordsForm;

        public Login()
        {

            InitializeComponent();

            ArduinoPort = new SerialPort();
            coordsForm = new Coords();
            coordsForm.Show(); // Asegúrate de mostrar el formulario de coordenadas
        }

        private void ContecarArduino()
        {
            //if (SerialPort.GetPortNames().Length > 0)
            //{
            //    ArduinoPort.PortName = "COM6";
            //    ArduinoPort.BaudRate = 9600;

            //    ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DatosRecibidos);
            //    ArduinoPort.Open();
            //    ArduinoPort.WriteLine("S");

            //}
            //else
            //{
            //    MessageBox.Show("¡No estas conectado!");
            //}
        }
        private void Login_Load(object sender, EventArgs e)
        {
            ContecarArduino();

            pasword = GenerarContraseña(passwordcadena);
            lbl_codigo.Text = pasword;

            EnviarPasswordAlArduino(pasword);

            GenerarCoordenadas();
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

        private string GenerarContraseña(int longitud)
        {
            using (RNGCryptoServiceProvider rngCrypto = new RNGCryptoServiceProvider())
            {
                byte[] valor = new byte[4];
                rngCrypto.GetBytes(valor);

                int i = BitConverter.ToInt32(valor,0);

                i = Math.Abs(i);

                string val = i.ToString();

                val = val.Substring(0, longitud);

                return val;
            }
        }

        public string GenerarCoordenadas()
        {
            string coords;

            Random random = new Random();

            char letter = (char)random.Next('A', 'D' + 1);
            int number = random.Next(1, 5);
            coords = $"{letter}{number}";

            lbl_generate_Coords.Text = coords;

            return coords;
        }

        private void ValidarCoordenada(string coordIngresada, int valorIngresado)
        {
            if (coordsForm.CoordenadasValores.Count == 0)
            {
                MessageBox.Show("No se han generado coordenadas. Por favor, genera las coordenadas primero.");
                return;
            }

            if (coordsForm.CoordenadasValores.TryGetValue(coordIngresada, out int valorEsperado))
            {
                if (valorEsperado == valorIngresado)
                {
                    MessageBox.Show($"¡Coordenada válida! Valor esperado: {valorEsperado}");
                }
                else
                {
                    MessageBox.Show($"El valor ingresado ({valorIngresado}) no coincide con la coordenada. Valor esperado: {valorEsperado}");
                }
            }
            else
            {
                MessageBox.Show($"Coordenada no encontrada: {coordIngresada}");
            }
        }



        private void btn_validar_coord_Click(object sender, EventArgs e)
        {
            string coordIngresada = lbl_generate_Coords.Text.ToUpper(); // Coordenada generada
            if (int.TryParse(txt_coords.Text, out int valorIngresado)) // Valor ingresado
            {
                // Validar si la coordenada generada existe y es válida
                ValidarCoordenada(coordIngresada, valorIngresado);
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.");
            }
        }
    }
}
