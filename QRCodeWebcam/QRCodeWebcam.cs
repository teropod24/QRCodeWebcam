﻿using System;
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

        private int contador = 60000;

        public QRCodeWebcam()
        {
            InitializeComponent();
            codigo = GenerarNumerosAleatorios(6, 0, 9);
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
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
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);

                if (result != null)
                {
                    txt_QRCode.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }

            if (contador <= 0)
            {
                lab_timer.Text = "00:000"; 
                timer1.Stop();
            }
            else
            {
                contador -= 10;

                int segundos = contador / 1000;
                int milisegundos = (contador % 1000) / 10;

                lab_timer.Text = $"{segundos:D2}:{milisegundos:D2}";
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
            QRGeneration qr = new QRGeneration();

            qr.Show();
        }
    }
}