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
    public partial class küresilindir : Form
    {
        public class Cylinder
        {
            public double px, py, pz, radius, height;

            public Cylinder(double x, double y, double z, double r, double h)
            {
                this.px = x;
                this.py = y;
                this.pz = z;
                this.radius = r;
                this.height = h;
            }
        }

        public class Sphere
        {
            public double cx, cy, cz, radius;

            public Sphere(double x, double y, double z, double r)
            {
                this.cx = x;
                this.cy = y;
                this.cz = z;
                this.radius = r;
            }
        }
        public küresilindir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double cylinderX = double.Parse(X2.Text);
            double cylinderY = double.Parse(Y2.Text);
            double cylinderZ = double.Parse(Z2.Text);
            double cylinderRadius = double.Parse(YARIÇAP2.Text);
            double cylinderHeight = double.Parse(YÜKSEKLİK.Text);

            double sphereX = double.Parse(X1.Text);
            double sphereY = double.Parse(Y1.Text);
            double sphereZ = double.Parse(Z1.Text);
            double sphereRadius = double.Parse(YARIÇAP1.Text);

            Cylinder cylinder = new Cylinder(cylinderX, cylinderY, cylinderZ, cylinderRadius, cylinderHeight);
            Sphere sphere = new Sphere(sphereX, sphereY, sphereZ, sphereRadius);

            double dx = sphere.cx - cylinder.px;
            double dy = sphere.cy - cylinder.py;
            double dz = sphere.cz - cylinder.pz;

            double cylinderRadiusSquared = cylinder.radius * cylinder.radius;

            if (dx * dx + dy * dy + dz * dz <= cylinderRadiusSquared)
            {
                MessageBox.Show("Küre ve silindir çarpışıyor!");
            }
            else if (dx * dx + dz * dz <= cylinderRadiusSquared && sphere.cy >= cylinder.py && sphere.cy <= cylinder.py + cylinder.height)
            {
                MessageBox.Show("Küre ve silindir çarpışıyor!");
            }
            else
            {
                MessageBox.Show("Küre ve silindir çarpışmıyor.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kurenin merkez noktası
            double sphereCenterX = double.Parse(X1.Text);
            double sphereCenterY = double.Parse(Y1.Text);
            double sphereCenterZ = double.Parse(Z1.Text);

            // Kurenin yarıçapı
            double sphereRadius = double.Parse(YARIÇAP1.Text);

            // Silindirin merkez noktası
            double cylinderCenterX = double.Parse(X2.Text);
            double cylinderCenterY = double.Parse(Y2.Text);
            double cylinderCenterZ = double.Parse(Z2.Text);

            // Silindirin yarıçapı
            double cylinderRadius = double.Parse(YARIÇAP2.Text);

            // Silindirin yüksekliği
            double cylinderHeight = double.Parse(YÜKSEKLİK.Text);

            // PictureBox'a çizim yapmak için Graphics nesnesi oluşturuyoruz
            Graphics g = pictureBox1.CreateGraphics();

            // Kurenin çizimi
            g.DrawEllipse(Pens.Black, (int)(sphereCenterX - sphereRadius), (int)(sphereCenterY - sphereRadius), (int)(sphereRadius * 2), (int)(sphereRadius * 2));

            // Silindirin çizimi
            g.DrawEllipse(Pens.Black, (int)(cylinderCenterX - cylinderRadius), (int)(cylinderCenterY - cylinderRadius), (int)(cylinderRadius * 2), (int)(cylinderRadius * 2));
            g.DrawEllipse(Pens.Black, (int)(cylinderCenterX - cylinderRadius), (int)(cylinderCenterY + cylinderHeight - cylinderRadius), (int)(cylinderRadius * 2), (int)(cylinderRadius * 2));
            g.DrawLine(Pens.Black, (int)(cylinderCenterX - cylinderRadius), (int)(cylinderCenterY), (int)(cylinderCenterX - cylinderRadius), (int)(cylinderCenterY + cylinderHeight));
            g.DrawLine(Pens.Black, (int)(cylinderCenterX + cylinderRadius), (int)(cylinderCenterY), (int)(cylinderCenterX + cylinderRadius), (int)(cylinderCenterY + cylinderHeight));
            g.DrawLine(Pens.Black, (int)(cylinderCenterX - cylinderRadius), (int)(cylinderCenterY), (int)(cylinderCenterX + cylinderRadius), (int)(cylinderCenterY));
            g.DrawLine(Pens.Black, (int)(cylinderCenterX - cylinderRadius), (int)(cylinderCenterY + cylinderHeight), (int)(cylinderCenterX + cylinderRadius), (int)(cylinderCenterY + cylinderHeight));

            // Graphics nesnesini dispose ediyoruz
            g.Dispose();


        }
    }
}
