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
            Hide();
            QRCodeWebcam.QRCodeWebcam qRCodeWebcam = new QRCodeWebcam.QRCodeWebcam();
            qRCodeWebcam.Show();
        }

        private void btm_validarUser_Click(object sender, EventArgs e)
        {
            AccesDBB.AccesData accesData = new AccesDBB.AccesData();
            string codeUser = txt_user.Text.Trim();

            DataSet dts = accesData.PortaTaula("Users");
            DataRow[] rows = dts.Tables[0].Select($"codeUser = '{codeUser}'");

            if (rows.Length > 0)
            {
                DataRow userRow = rows[0];

                txt_Desc.Text = userRow["descUser"].ToString();
                txt_Edad.Text = userRow["edad"].ToString();
                txt_Planeta.Text = userRow["planeta"].ToString();
                txt_fecha.Text = userRow["dataNacimiento"].ToString();
                txt_user.Text = userRow["nom"].ToString();

                txtQrCode.Text = $"{txt_user.Text}, {txt_Edad.Text}, {txt_fecha.Text}";
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
            }

        }
    }
}