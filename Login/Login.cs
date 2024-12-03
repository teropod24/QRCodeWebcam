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
        private bool startBtn = false;
        private int contador = 60000;
        SerialPort ArduinoPort = new SerialPort();
        private DateTime tiempoInicio;
        string pasword;

        public Login()
        {
            InitializeComponent();
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

        public string GenerarContraseña(int cantidadNums)
        {
            string pass = "";
            int min = 0;
            int max = 9;
            Random rmd = new Random();

            for (int i = 0; i < cantidadNums; i++)
            {
                pass += rmd.Next(min, max);
            }

            return pass;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = DateTime.Now - tiempoInicio;
            int milisegundosTranscurridos = (int)tiempoTranscurrido.TotalMilliseconds;

            contador = Math.Max(60000 - milisegundosTranscurridos, 0);

            int segundos = contador / 1000;
            int milisegundos = (contador % 1000) / 10;

            contadorTimer.Text = $"{segundos:D2}:{milisegundos:D2}";

            if (contador <= 0)
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!startBtn)
            {
                ContecarArduino();

                pasword = GenerarContraseña(6);
                lbl_codigo.Text = pasword;

                EnviarPasswordAlArduino(pasword);

                gbx_verification.Enabled = true;
                startBtn = true;
                ArduinoPort = new SerialPort();
                timer1.Interval = 10;
                tiempoInicio = DateTime.Now;
                timer1.Start();
            }
        }
    }
}
