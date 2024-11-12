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
using QrGenerator;
using System.Security.Cryptography;

namespace QRCodeWebcam
{
    public partial class QRCodeWebcam : Form
    {
        int[] codigo;

        private int contador = 0;
        private Timer timer;
        public QRCodeWebcam()
        {
            InitializeComponent();
            codigo = GenerarNumerosAleatorios(6, 0, 9);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;

        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            //string cadena_codi = "";
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbo_Device.Items.Add(filterInfo.Name);
            }
            cbo_Device.SelectedIndex = 0;
            //foreach (int item in codigo)
            //{
            //    cadena_codi += item.ToString();
            //}
            //MessageBox.Show(cadena_codi);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbo_Device.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (pictureBox1.Image != null)
            //{
            //    BarcodeReader barcodeReader = new BarcodeReader();
            //    Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);

            //    if (result != null)
            //    {
            //        txt_QRCode.Text = result.ToString();
            //        timer1.Stop();
            //        if (captureDevice.IsRunning)
            //        {
            //            captureDevice.Stop();
            //        }
            //    }
            //}

            if (!timer.Enabled)
            {
                contador = 0; 
                lab_timer.Text = "0";
                timer.Start();
                lab_timer.Text = "Detener";
            }
            else
            {
                timer.Stop();
                Text = "Iniciar";
            }

            contador++;
            lab_timer.Text = contador.ToString();
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
            QRGeneration qr = new QRGeneration();

            qr.Show();
        }
    }
}