# csharpqrkodolusturucu
C# İle QR Kod Oluşturucu

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
namespace QrKodOluşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void olustur_Click(object sender, EventArgs e)
        {
            string str = qrtext.Text;
            QRCodeGenerator qrOlusturma = new QRCodeGenerator();
            QRCodeData qrKoduData = qrOlusturma.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrKodu = new QRCode(qrKoduData);
            Bitmap qrCodeImage = qrKodu.GetGraphic(20, "#FF0000", "#FFFFFF");
            qrkod.Image = qrCodeImage;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
