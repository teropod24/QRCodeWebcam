using System;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using QrGenerator;
using ZXing;
using QrGenerator;
using Cordenadas;
using System.Net.Mail;
using System.Net;

namespace Login
{
    public partial class Login : Form
    {
        SerialPort ArduinoPort = new SerialPort();
        string pasword;
        private int passwordcadena = 6;
        private bool startbtn = false;
        Coords coordsForm ;
        private DateTime tiempoIncial;
        private int contador = 60000;

        public Login()
        {
            InitializeComponent();
            ArduinoPort = new SerialPort();
            coordsForm = new Coords();
            coordsForm.Show(); // Asegúrate de mostrar el formulario de coordenadas
            //qRGeneration.Show();

            QRGeneration qRGeneration = new QRGeneration();
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
                            pictureBox1.Image = Image.FromFile("C:/S2AM/Arduino/fotos_validate/icono-check.png");
                            btm_next.Visible = true;
                            MessageBox.Show("Access to QRGeneration accepted!");
                            QRGeneration qrForm = new QRGeneration();
                            qrForm.ShowDialog();
                        }
                        else
                        {
                            pictureBox1.Image = Image.FromFile("C:/S2AM/Arduino/fotos_validate/incorrect.png");
                            MessageBox.Show("Contraseña incorrecta.");
                        }
                    }));
                }
                else
                {
                    MessageBox.Show("Formato de datos incorrecto recibido desde el Arduino.");
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
                pictureBox2.Image = Image.FromFile("C:/S2AM/Arduino/fotos_validate/icono-check.png");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un valor numérico válido.");
                pictureBox2.Image = Image.FromFile("C:/S2AM/Arduino/fotos_validate/incorrect.png");
            }          
        }
        private void btm_iniciar_Click(object sender, EventArgs e)
        {
            if (!startbtn)
            {               
                ContecarArduino();

                pasword = GenerarContraseña(passwordcadena);
                lbl_codigo.Text = pasword;

                EnviarPasswordAlArduino(pasword);

                GenerarCoordenadas();
                startbtn = true;
                txt_coords.Enabled = true;
                txt_pass.Enabled = true;
                btn_validar_coord.Enabled = true;

                timer1.Interval = 10;
                tiempoIncial = DateTime.Now;
                timer1.Start();

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
            }
        }

        private void btm_next_Click(object sender, EventArgs e)
        {
            QRGeneration qRGeneration = new QRGeneration();
            qRGeneration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "smtp.gmail.com";
            string to = "jx.paredes@sarria.salesians.cat";
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
                MessageBox.Show("enviado");
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }
        }
    }
}
