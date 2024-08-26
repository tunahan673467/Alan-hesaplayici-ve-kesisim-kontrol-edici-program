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
    public partial class yüzeydikdörtgenprizma : Form
    {
        public yüzeydikdörtgenprizma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double surfaceX = Convert.ToDouble(X1.Text);
            double surfaceY = Convert.ToDouble(Y1.Text);
            double surfaceZ = Convert.ToDouble(Z1.Text);
            double surfaceWidth = Convert.ToDouble(EN.Text);
            double surfaceHeight = Convert.ToDouble(BOY.Text);

            // Dikdörtgen prizmanın koordinatları ve boyutları
            double rectX = Convert.ToDouble(X2.Text);
            double rectY = Convert.ToDouble(Y2.Text);
            double rectZ = Convert.ToDouble(Z2.Text);
            double rectWidth = Convert.ToDouble(EN2.Text);
            double rectHeight = Convert.ToDouble(BOY2.Text);
            double rectDepth = Convert.ToDouble(YÜKSEKLİK.Text);

            // Dikdörtgen prizmanın merkez noktası
            double rectCenterX = rectX + rectWidth / 2;
            double rectCenterY = rectY + rectHeight / 2;
            double rectCenterZ = rectZ + rectDepth / 2;

            // Dikdörtgen prizmanın yarısı
            double rectHalfWidth = rectWidth / 2;
            double rectHalfHeight = rectHeight / 2;
            double rectHalfDepth = rectDepth / 2;

            // Kürenin merkez noktası ve yarıçapı
            double sphereX = rectCenterX;
            double sphereY = rectCenterY;
            double sphereZ = rectCenterZ;
            double sphereRadius = Math.Sqrt(rectHalfWidth * rectHalfWidth + rectHalfHeight * rectHalfHeight + rectHalfDepth * rectHalfDepth);

            // İki cisim arasındaki mesafe
            double distance = Math.Sqrt((sphereX - surfaceX) * (sphereX - surfaceX) +
                                        (sphereY - surfaceY) * (sphereY - surfaceY) +
                                        (sphereZ - surfaceZ) * (sphereZ - surfaceZ));

            // Çarpışma kontrolü
            bool isCollision = distance <= sphereRadius + Math.Sqrt(surfaceWidth * surfaceWidth + surfaceHeight * surfaceHeight);

            if (isCollision)
            {
                MessageBox.Show("Yüzey ve dikdörtgen prizma çarpıştı!");
            }
            else
            {
                MessageBox.Show("Yüzey ve dikdörtgen prizma çarpışmadı!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float surfaceStartX = float.Parse(X1.Text);
            float surfaceStartY = float.Parse(Y1.Text);
            float surfaceStartZ = float.Parse(Z1.Text);
            float surfaceWidth = float.Parse(EN.Text);
            float surfaceHeight = float.Parse(BOY.Text);

            // dikdörtgen prizmanın başlangıç noktaları ve boyutları
            float cubeStartX = float.Parse(X2.Text);
            float cubeStartY = float.Parse(Y2.Text);
            float cubeStartZ = float.Parse(Z2.Text);
            float cubeWidth = float.Parse(EN2.Text);
            float cubeHeight = float.Parse(BOY2.Text);
            float cubeDepth = float.Parse(YÜKSEKLİK.Text);

            // Picturebox'ta çizimi yap
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);

            // yüzeyi çiz
            Point[] surfacePoints =
            {
                new Point((int)surfaceStartX, (int)surfaceStartY),
                new Point((int)(surfaceStartX + surfaceWidth), (int)surfaceStartY),
                new Point((int)(surfaceStartX + surfaceWidth), (int)(surfaceStartY + surfaceHeight)),
                new Point((int)surfaceStartX, (int)(surfaceStartY + surfaceHeight)),
            };
            g.FillPolygon(Brushes.Red, surfacePoints);

            // dikdörtgen prizmayı çiz
            Point[] cubePoints =
            {
                new Point((int)cubeStartX, (int)cubeStartY),
                new Point((int)(cubeStartX + cubeWidth), (int)cubeStartY),
                new Point((int)(cubeStartX + cubeWidth), (int)(cubeStartY + cubeHeight)),
                new Point((int)cubeStartX, (int)(cubeStartY + cubeHeight)),
                new Point((int)cubeStartX, (int)cubeStartY),
                new Point((int)cubeStartX, (int)(cubeStartY + cubeHeight)),
                new Point((int)(cubeStartX + cubeWidth), (int)(cubeStartY + cubeHeight)),
                new Point((int)(cubeStartX + cubeWidth), (int)cubeStartY),
                new Point((int)cubeStartX, (int)cubeStartY)
            };
            g.FillPolygon(Brushes.Blue, cubePoints);

            pictureBox1.Image = bmp;
        }
    }
}
