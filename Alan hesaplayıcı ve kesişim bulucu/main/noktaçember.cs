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
    public partial class noktaçember : Form
    {
        public noktaçember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pointX = int.Parse(X1.Text);
            int pointY = int.Parse(Y1.Text);

            // Çemberin koordinatlarını ve yarıçapını alın
            int circleX = int.Parse(X2.Text);
            int circleY = int.Parse(Y2.Text);
            int circleRadius = int.Parse(YARIÇAP.Text);

            // Çarpışmayı kontrol et
            CheckCollision(new Point(pointX, pointY),
                           new Point(circleX, circleY),
                           circleRadius);
        }

        private void CheckCollision(Point point, Point circleCenter, int circleRadius)
        {
            int dx = point.X - circleCenter.X;
            int dy = point.Y - circleCenter.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance <= circleRadius)
            {
                // Nokta çemberin içinde
                MessageBox.Show("Nokta çemberin içinde!");
            }
            else
            {
                // Nokta çemberin dışında
                MessageBox.Show("Nokta çemberin dışında.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(X1.Text);
            int y = int.Parse(Y1.Text);

            using (Graphics g = pictureBox1.CreateGraphics())
            {
                g.FillEllipse(Brushes.Black, x, y, 2, 2);
            }
            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);
            int r2 = int.Parse(YARIÇAP.Text);

            using (Graphics g = pictureBox1.CreateGraphics())
            {
                g.DrawEllipse(Pens.Black, x2 - r2, y2 - r2, r2 * 2, r2 * 2);
            }
        }
    }
}
