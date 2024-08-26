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
    public partial class noktaküre : Form
    {

        public class Point3D
        {
            public double x, y, z;

            public Point3D(double X, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        public noktaküre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(X1.Text);
            double y = double.Parse(Y1.Text);
            double z = double.Parse(Z1.Text);

            // Kürenin yarıçapını ve merkez noktasını TextBox'lardan alıyoruz.
            double radius = double.Parse(YARIÇAP.Text);
            Point3D center = new Point3D(double.Parse(X2.Text), double.Parse(Y2.Text), double.Parse(Z2.Text));

            // Noktanın koordinatlarını alıyoruz.
            Point3D point = new Point3D(x, y, z);

            // Kürenin ve noktanın çarpışıp çarpmadığını kontrol ediyoruz.
            if (Math.Pow(point.x - center.x, 2) + Math.Pow(point.y - center.y, 2) + Math.Pow(point.z - center.z, 2) <= Math.Pow(radius, 2))
            {
                MessageBox.Show("Nokta ve küre çarpışıyor!");
            }
            else
            {
                MessageBox.Show("Nokta ve küre çarpışmıyor.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int x1 = int.Parse(X1.Text);
            int y1 = int.Parse(Y1.Text);

            // Küre değişkenleri
            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);
            int z2 = int.Parse(Z2.Text);
            int r = int.Parse(YARIÇAP.Text);

            // Bitmap oluştur
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Noktayı çizdir
                g.FillEllipse(Brushes.Black, x1, y1, 3, 3);

                // Küreyi çizdir
                g.DrawEllipse(Pens.Red, x2 - r, y2 - r, r * 2, r * 2);
            }

            // PictureBox'a resmi ata
            pictureBox1.Image = bmp;
        }
    }
}
