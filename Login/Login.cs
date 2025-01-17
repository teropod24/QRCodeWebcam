using System;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using QrGenerator;
using ZXing;
using Cordenadas;
using System.Net.Mail;
using System.Net;

//Leo Varas, Enric Martorell & Juan Paredes
namespace Login
{
    public partial class Login : Form
    {
        SerialPort ArduinoPort = new SerialPort();
        string pasword;
        private int passwordcadena = 6;
        private bool startbtn = false;
        Cordenadas.Coords coords = new Coords();
        private DateTime tiempoIncial;
        private string posicionCoords;
        private int valorCoords;
        private int contador = 60000;

        public Login()
        {
            coords.Show();
            this.BringToFront();
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
        private void EnviarPasswordAlArduino(string password)
        {
            if (ArduinoPort.IsOpen)
            {
                ArduinoPort.WriteLine(password);
            }
        }

        private void DatosRecibidos(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string datosRecibidos = ArduinoPort.ReadLine().Trim();
                string[] partes = datosRecibidos.Split(':');

                if (partes.Length == 2)
                {
                    string contrasenaRecibida = partes[0];
                    bool passwordValido = partes[1] == "true";

                    Invoke(new Action(() =>
                    {
                        txt_pass.Text = contrasenaRecibida;

                        if (passwordValido)
                        {
                            pictureBox1.Image = Image.FromFile(@"Resources/icono-check.png");
                            QrGenerator.QRGeneration qRGeneration = new QRGeneration();
                            qRGeneration.Show();
                        }
                        else
                        {
                            pictureBox1.Image = Image.FromFile(@"Resources/incorrect.png");
                            MessageBox.Show("Contraseña incorrecta.");
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar los datos recibidos: {ex.Message}");
            }
        }

        private string GenerarContraseña(int longitud)
        {
            using (RNGCryptoServiceProvider rngCrypto = new RNGCryptoServiceProvider())
            {
                byte[] valor = new byte[4];
                rngCrypto.GetBytes(valor);

                int i = BitConverter.ToInt32(valor, 0);

                i = Math.Abs(i);

                string val = i.ToString();

                val = val.Substring(0, longitud);

                return val;
            }
        }

        private bool ValidarCoordenada(string coordIngresada, int valorIngresado)
        {
            bool validarCoords = false;

            if (posicionCoords == coordIngresada)
            {
                if (valorCoords == valorIngresado)
                {
                    validarCoords = true;
                }
            }

            return validarCoords;
        }
        private void btm_iniciar_Click(object sender, EventArgs e)
        {
            if (!startbtn)
            {
                ContecarArduino();

                pasword = GenerarContraseña(passwordcadena);
                lbl_codigo.Text = pasword;

                EnviarPasswordAlArduino(pasword);

                ActualizarCoordenadas();

                startbtn = true;
                txt_coords.Enabled = true;
                txt_pass.Enabled = true;
                btn_validar_coord.Enabled = true;
                btm_coords.Enabled = true;

                timer1.Interval = 10;
                tiempoIncial = DateTime.Now;
                timer1.Start();
                EnviarCorreo();
            }
        }

        private void EnviarCorreo()
        {
            string server = "smtp.gmail.com";
            string to = "p8171843@gmail.com";
            string from = "p8171843@gmail.com";
            MailMessage message = new MailMessage(from, to);

            message.Subject = "Using the new SMTP client.";
            message.Body = $"First Order StarKiller Section\nWe send you a validation code (OTP - one time password) that has a validity periode of 1 minute\nThe introduction of the code in the system is mandatory so that you can authenticate and activate the weapon\n\nCODE: {lbl_codigo.Text}";

            SmtpClient client = new SmtpClient(server)
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(from, "umtt ctkz fqpz eowd")
            };

            try
            {
                client.Send(message);
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeTranscurido = DateTime.Now - tiempoIncial;
            int miliseg = (int)timeTranscurido.TotalMilliseconds;
            contador -= 10;
            contador = Math.Max(contador, 0);

            int segundos = contador / 1000;
            int milisegundos = (contador % 1000) / 10;

            lbl_contador.Text = $"{segundos:D2}:{milisegundos:D2}";

            if (contador <= 0)
            {
                timer1.Stop();
                coords.Close();
            }
        }
        private void btn_validar_coord_Click_1(object sender, EventArgs e)
        {
            bool validarCoords;
            string coordIngresada = lbl_generate_Coords.Text.ToUpper();
            if (int.TryParse(txt_coords.Text, out int valorIngresado))
            {
                // Validar si la coordenada generada existe y es válida
                validarCoords = ValidarCoordenada(coordIngresada, valorIngresado);
                if (validarCoords)
                {
                    pictureBox2.Image = Image.FromFile(@"Resources/icono-check.png");
                    timer1.Stop();
                }
                else
                {
                    pictureBox2.Image = Image.FromFile(@"Resources/incorrect.png");
                }

            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.");
                pictureBox2.Image = Image.FromFile(@"Resources/incorrect.png");
            }
        }

        private void ActualizarCoordenadas()
        {
            posicionCoords = coords.GenerarCoordenadas();
            valorCoords = coords.GenerarValorCoordenadas();

            if (!string.IsNullOrEmpty(posicionCoords))
            {
                lbl_generate_Coords.Text = posicionCoords; // Muestra la coordenada generada
            }
            else
            {
                lbl_generate_Coords.Text = "XX";
                txt_coords.Text = string.Empty;
            }
        }

        private void btm_coords_Click(object sender, EventArgs e)
        {

            coords.BringToFront();
        }
    }
}