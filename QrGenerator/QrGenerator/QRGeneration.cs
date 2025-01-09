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
using AccesDBB;


namespace QrGenerator
{
    public partial class QRGeneration : Form
    {
        public string CodeUser { get; set; }
        public QRGeneration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQrCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic.Image = code.GetGraphic(5);            
        }

        private void btm_next_Click(object sender, EventArgs e)
        {
            AccesDBB.AccesData accesData = new AccesData();
            string columnName = "photo";
            object newValue = txtQrCode.Text;

            accesData.Actualitzar("Users", CodeUser, columnName, newValue);
            Close();
        }
    }
}