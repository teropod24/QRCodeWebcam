using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Security.Cryptography;
using Cordenadas;

namespace QRCodeWebcam
{
    public partial class QRCodeWebcam : Form
    {
        int[] codigo;
        DateTime tiempoIncial;
        int contador = 1000;

        public QRCodeWebcam()
        {
            InitializeComponent();
            codigo = GenerarNumerosAleatorios(6, 0, 9);

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbo_Device.Items.Add(filterInfo.Name);
            }
            cbo_Device.SelectedIndex = 0;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbo_Device.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Interval = 10;
            tiempoIncial = DateTime.Now;
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private int[] GenerarNumerosAleatorios(int cantidad, int min, int max)
        {
            int[] codigo = new int[cantidad];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                for (int i = 0; i < cantidad; i++)
                {
                    codigo[i] = GenerarNumeroAleatorio(rng, min, max);
                }
            }
                return codigo;
        }

        private int GenerarNumeroAleatorio(RandomNumberGenerator rng, int min, int max)
        {
            byte[] aleatorio = new byte[4];

            rng.GetBytes(aleatorio);
            int valor = BitConverter.ToInt32(aleatorio,0);

            return Math.Abs(valor % (max-min +1)) + min;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeSpan timeTranscurido = DateTime.Now - tiempoIncial;
            int miliseg = (int)timeTranscurido.TotalMilliseconds;

            contador = Math.Max(contador - miliseg, 0);

            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);

                if (result != null)
                {
                    txt_QRCode.ForeColor = Color.White;
                    txt_QRCode.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }
    }
}