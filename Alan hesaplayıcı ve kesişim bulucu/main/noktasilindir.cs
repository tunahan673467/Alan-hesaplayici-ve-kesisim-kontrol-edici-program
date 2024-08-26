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
    public partial class noktasilindir : Form
    {
        public class Point3D
        {
            public double x, y, z;

            public Point3D(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        public class Cylinder3D
        {
            public double cx, cy, cz, cradius, cheight;

            public Cylinder3D(double x, double y, double z, double radius, double height)
            {
                this.cx = x;
                this.cy = y;
                this.cz = z;
                this.cradius = radius;
                this.cheight = height;
            }
        }
        public noktasilindir()
        {
            InitializeComponent();
        }

        private void HESAPLA_Click(object sender, EventArgs e)
        {
            double px = double.Parse(X1.Text);
            double py = double.Parse(Y1.Text);
            double pz = double.Parse(Z1.Text);
            double cradius = double.Parse(YARIÇAP.Text);
            double cheight = double.Parse(YÜKSEKLİK.Text);
            double cx = double.Parse(X2.Text);
            double cy = double.Parse(Y2.Text);
            double cz = double.Parse(Z2.Text);

            Point3D point = new Point3D(px, py, pz);
            Cylinder3D cylinder = new Cylinder3D(cx, cy, cz, cradius, cheight);

            // Çarpışma kontrolü için gereken formüller
            double dx = point.x - cylinder.cx;
            double dy = point.y - cylinder.cy;
            double dz = point.z - cylinder.cz;
            double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
            bool isCollision = (distance <= cylinder.cradius) && (point.z >= cylinder.cz) && (point.z <= cylinder.cz + cylinder.cheight);

            if (isCollision)
            {
                MessageBox.Show("Nokta ve silindir çarpışıyor!");
            }
            else
            {
                MessageBox.Show("Nokta ve silindir çarpışmıyor.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Noktanın koordinatlarını al
            double pointX = double.Parse(X1.Text);
            double pointY = double.Parse(Y1.Text);
            double pointZ = double.Parse(Z1.Text);

            // Silindirin koordinatlarını ve boyutlarını al
            double cylinderX = double.Parse(X2.Text);
            double cylinderY = double.Parse(Y2.Text);
            double cylinderZ = double.Parse(Z2.Text);
            double cylinderRadius = double.Parse(YARIÇAP.Text);
            double cylinderHeight = double.Parse(YÜKSEKLİK.Text);

            // Bitmap oluştur
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Graphics objesi oluştur
            Graphics g = Graphics.FromImage(bmp);

            // Noktayı çizdir
            g.FillEllipse(Brushes.Red, (float)pointX - 5, (float)pointY - 5, 5, 5);

            // Silindiri çizdir
            float x = (float)cylinderX;
            float y = (float)cylinderY;
            float z = (float)cylinderZ;
            float r = (float)cylinderRadius;
            float h = (float)cylinderHeight;
            g.DrawEllipse(Pens.Black, x - r, y - r, 2 * r, 2 * r);
            g.DrawEllipse(Pens.Black, x - r, z - r, 2 * r, 2 * r);
            g.DrawEllipse(Pens.Black, z - r, y - r, 2 * r, 2 * r);
            g.DrawLine(Pens.Black, x, y, x, y + h);
            g.DrawLine(Pens.Black, x, y, z, y);
            g.DrawLine(Pens.Black, x, y + h, z, y + h);
            g.DrawLine(Pens.Black, z, y, z, y + h);

            // PictureBox'a bitmap'i ekle
            pictureBox1.Image = bmp;

            // Graphics objesini serbest bırak
            g.Dispose();
        }
    }
}
