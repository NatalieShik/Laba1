using MessagingToolkit.QRCode.Codec;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppDEMOPrepearing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode("https://process-tea.ru/");
            pictureBox1.Image = qrcode as Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
