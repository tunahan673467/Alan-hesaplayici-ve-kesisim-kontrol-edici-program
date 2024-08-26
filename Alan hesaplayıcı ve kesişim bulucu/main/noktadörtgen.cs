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
    public partial class noktadörtgen : Form
    {
        public noktadörtgen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pointX = int.Parse(X1.Text);
            int pointY = int.Parse(Y1.Text);

            // Dörtgenin koordinatlarını ve boyutunu alın
            int rectX = int.Parse(X2.Text);
            int rectY = int.Parse(Y2.Text);
            int rectWidth = int.Parse(EN.Text);
            int rectHeight = int.Parse(BOY.Text);

            // Çarpışmayı kontrol et
            CheckCollision(new Point(pointX, pointY),
                           new Rectangle(rectX, rectY, rectWidth, rectHeight));
        }

        private void CheckCollision(Point point, Rectangle rect)
        {
            if (rect.Contains(point))
            {
                // Nokta dörtgenin içinde
                MessageBox.Show("Nokta dörtgenin içinde!");
            }
            else
            {
                // Nokta dörtgenin dışında
                MessageBox.Show("Nokta dörtgenin dışında.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Nokta
            int x1 = int.Parse(X1.Text);
            int y1 = int.Parse(Y1.Text);
            pictureBox1.CreateGraphics().FillEllipse(Brushes.Black, x1, y1, 2, 2);

            // Dikdörtgen
            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);
            int w2 = int.Parse(EN.Text);
            int h2 = int.Parse(BOY.Text);
            pictureBox1.CreateGraphics().DrawRectangle(Pens.Red, x2, y2, w2, h2);
        }
    }
}
