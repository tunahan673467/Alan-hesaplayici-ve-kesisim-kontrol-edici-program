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
    public partial class çemberçember : Form
    {
        public çemberçember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int circle1X = int.Parse(X1.Text);
            int circle1Y = int.Parse(Y1.Text);
            int circle1Radius = int.Parse(YARIÇAP1.Text);

            // İkinci çemberin merkez noktası ve yarıçapını alın
            int circle2X = int.Parse(X2.Text);
            int circle2Y = int.Parse(Y2.Text);
            int circle2Radius = int.Parse(YARIÇAP2.Text);

            // Çarpışmayı kontrol et
            CheckCollision(new Point(circle1X, circle1Y), circle1Radius,
                           new Point(circle2X, circle2Y), circle2Radius);
        }

        private void CheckCollision(Point circle1Center, int circle1Radius, Point circle2Center, int circle2Radius)
        {
            int dx = circle1Center.X - circle2Center.X;
            int dy = circle1Center.Y - circle2Center.Y;
            int distance = (int)Math.Sqrt(dx * dx + dy * dy);

            if (distance <= circle1Radius + circle2Radius)
            {
                // İki çember çarpıştı
                MessageBox.Show("Çemberler çarpıştı!");
            }
            else
            {
                // İki çember çarpışmadı
                MessageBox.Show("Çemberler çarpışmadı.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(X1.Text);
            int y1 = int.Parse(Y1.Text);
            int r1 = int.Parse(YARIÇAP1.Text);

            // İkinci çember
            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);
            int r2 = int.Parse(YARIÇAP2.Text);

            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);

            // İlk çemberi çizdir
            using (Graphics f = pictureBox1.CreateGraphics())
            {
                f.DrawEllipse(pen, x1 - r1, y1 - r1, 2 * r1, 2 * r1);
            }
            // İkinci çemberi çizdir
            using (Graphics b = pictureBox1.CreateGraphics())
            {
                b.DrawEllipse(pen, x2 - r2, y2 - r2, 2 * r2, 2 * r2);
            }
        }
    }
}
