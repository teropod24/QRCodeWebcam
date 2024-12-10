using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCodeWebcam;

namespace QrGenerator
{
    public partial class QRGeneration : Form
    {
        public QRGeneration()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQrCode.Text,QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic.Image = code.GetGraphic(5);
        }

        private void btm_next_Click(object sender, EventArgs e)
        {
            Close();
            QRCodeWebcam.QRCodeWebcam qRCodeWebcam = new QRCodeWebcam.QRCodeWebcam();
            qRCodeWebcam.Show();
        }

        private void QRGeneration_Load(object sender, EventArgs e)
        {
        }
    }
}
