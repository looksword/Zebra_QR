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

namespace GenerateQRCode
{
    public partial class Form1 : Form
    {
        public int[] pixelSize = new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

        public Form1()
        {
            InitializeComponent();
            combo_Level.DataSource = System.Enum.GetNames(typeof(QRCodeGenerator.ECCLevel));
            combo_Pixel.DataSource = pixelSize;
        }

        public static Bitmap GenerateCode(string msg, QRCodeGenerator.ECCLevel mode,int pixel)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(msg, mode);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(pixel);
            return qrCodeImage;
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator.ECCLevel mode = (QRCodeGenerator.ECCLevel)Enum.Parse(typeof(QRCodeGenerator.ECCLevel), combo_Level.Text.ToString());
            int pixel = Convert.ToInt32(combo_Pixel.Text);
            string msg = text_code.Text;
            Bitmap bmp = GenerateCode(msg, mode, pixel);
            picture_qr.Image = bmp;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(picture_qr.Image != null)
            {
                using(SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "(*.png)|*.png|(*.bmp)|*.bmp";
                    if(sfd.ShowDialog() == DialogResult.OK)
                    {
                        picture_qr.Image.Save(sfd.FileName);
                    }
                }
            }
        }
    }
}
