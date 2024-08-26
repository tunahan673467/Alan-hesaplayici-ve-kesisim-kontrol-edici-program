using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖDEV_ASIL
{
    public partial class küreküre : Form
    {
        public küreküre()
        {
            InitializeComponent();
        }

        private void HESAPLA_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(X1.Text);
            double y1 = double.Parse(Y1.Text);
            double z1 = double.Parse(Z1.Text);
            double r1 = double.Parse(YARIÇAP.Text);

            double x2 = double.Parse(X2.Text);
            double y2 = double.Parse(Y2.Text);
            double z2 = double.Parse(Z2.Text);
            double r2 = double.Parse(YARIÇAP2.Text);

            // Küreler arasındaki mesafeyi hesapla
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

            // Eğer kürelerin merkezleri arasındaki mesafe, yarıçaplarının toplamından küçükse küreler çarpışmaktadır
            if (distance < r1 + r2)
            {
                MessageBox.Show("Küreler çarpışıyor.");
            }
            else
            {
                MessageBox.Show("Küreler çarpışmıyor.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double centerX1 = double.Parse(X1.Text);
            double centerY1 = double.Parse(Y1.Text);
            double centerZ1 = double.Parse(Z1.Text);
            double radius1 = double.Parse(YARIÇAP.Text);

            double centerX2 = double.Parse(X2.Text);
            double centerY2 = double.Parse(Y2.Text);
            double centerZ2 = double.Parse(Z2.Text);
            double radius2 = double.Parse(YARIÇAP2.Text);

            // Küreleri çizmek için yeni bir Bitmap oluşturuyoruz
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);

            // İlk küreyi çiziyoruz
            g.DrawEllipse(Pens.Black, (float)(centerX1 - radius1), (float)(centerY1 - radius1), (float)(2 * radius1), (float)(2 * radius1));

            // İkinci küreyi çiziyoruz
            g.DrawEllipse(Pens.Black, (float)(centerX2 - radius2), (float)(centerY2 - radius2), (float)(2 * radius2), (float)(2 * radius2));

            // PictureBox üzerine Bitmap'i çiziyoruz
            pictureBox1.Image = bmp;
        }
    }
}
