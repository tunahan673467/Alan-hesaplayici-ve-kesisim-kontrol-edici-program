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
    public partial class yüzeyküre : Form
    {
        public class Surface3D
        {
            public double px, py, pz, pwidth, pheight;

            public Surface3D(double x, double y, double z, double t, double u)
            {
                this.px = x;
                this.py = y;
                this.pz = z;
                this.pwidth = t;
                this.pheight = u;
            }
        }

        public class Sphere3D
        {
            public double cx, cy, cz, radius;

            public Sphere3D(double x, double y, double z, double r)
            {
                this.cx = x;
                this.cy = y;
                this.cz = z;
                this.radius = r;
            }
        }
            public yüzeyküre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double sx = double.Parse(X2.Text);
                double sy = double.Parse(Y2.Text);
                double sz = double.Parse(Z2.Text);
                double sradius = double.Parse(YARIÇAP.Text);
                Sphere3D sphere = new Sphere3D(sx, sy, sz, sradius);

                double px = double.Parse(X1.Text);
                double py = double.Parse(Y1.Text);
                double pz = double.Parse(Z1.Text);
                double pwidth = double.Parse(EN.Text);
                double pheight = double.Parse(BOY.Text);
                Surface3D surface = new Surface3D(px, py, pz, pwidth, pheight);

                double distance = Math.Sqrt(
                    (sphere.cx - surface.px) * (sphere.cx - surface.px) +
                    (sphere.cy - surface.py) * (sphere.cy - surface.py) +
                    (sphere.cz - surface.pz) * (sphere.cz - surface.pz)
                );

                if (distance <= sphere.radius)
                {
                    MessageBox.Show("Yüzey ve küre çarpışıyor!");
                }
                else
                {
                    MessageBox.Show("Yüzey ve küre çarpışmıyor.");
                }



            }

        private void button2_Click(object sender, EventArgs e)
        {

            // Yüzeyin başlangıç noktalarını text box'lardan al
            float startX = float.Parse(X2.Text);
            float startY = float.Parse(Y2.Text);
            float startZ = float.Parse(Z2.Text);

            // Yüzeyin eni ve boyunu text box'lardan al
            float width = float.Parse(EN.Text);
            float height = float.Parse(BOY.Text);

            // Kürenin merkez noktasını ve yarıçapını text box'lardan al
            float centerX = float.Parse(X1.Text);
            float centerY = float.Parse(Y1.Text);
            float centerZ = float.Parse(Z1.Text);
            float radius = float.Parse(YARIÇAP.Text);

            // Picture box'ı temizle
            pictureBox1.Image = null;

            // Bitmap oluştur
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Graphics objesi oluştur
            Graphics g = Graphics.FromImage(bmp);

            // Yüzeyi çiz
            Pen surfacePen = new Pen(Color.Red, 2);
            g.DrawRectangle(surfacePen, startX, startY, width, height);

            // Küreyi çiz
            Pen spherePen = new Pen(Color.Blue, 2);
            g.DrawEllipse(spherePen, centerX - radius, centerY - radius, radius * 2, radius * 2);

            // Picture box'a bitmap'i ekle
            pictureBox1.Image = bmp;

            // Graphics ve Pen objelerini serbest bırak
            g.Dispose();
            surfacePen.Dispose();
            spherePen.Dispose();

        }
    }
}
