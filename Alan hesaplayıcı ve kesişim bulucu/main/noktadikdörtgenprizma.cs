using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ÖDEV_ASIL
{
    public partial class noktadikdörtgenprizma : Form
    {
        public noktadikdörtgenprizma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Noktanın koordinatlarını al
            int pointX = int.Parse(X1.Text);
            int pointY = int.Parse(Y1.Text);
            int pointZ = int.Parse(Z1.Text);

            // Dikdörtgen prizmanın koordinatlarını ve boyutlarını al
            int prismX = int.Parse(X2.Text);
            int prismY = int.Parse(Y2.Text);
            int prismZ = int.Parse(Z2.Text);
            int prismWidth = int.Parse(EN.Text);
            int prismHeight = int.Parse(BOY.Text);
            int prismDepth = int.Parse(DERİNLİK.Text);

            // Çarpışma kontrolü yap
            if (pointX >= prismX && pointX <= prismX + prismWidth &&
                pointY >= prismY && pointY <= prismY + prismHeight &&
                pointZ >= prismZ && pointZ <= prismZ + prismDepth)
            {
                MessageBox.Show("Nokta dikdörtgen prizma içinde yer alıyor.", "Çarpışma Var", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nokta dikdörtgen prizma içinde yer almıyor.", "Çarpışma Yok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(X1.Text);
            int y = int.Parse(Y1.Text);



            int x3 = int.Parse(X2.Text);
            int y3 = int.Parse(Y2.Text);
            int z3 = int.Parse(Z2.Text);
            int width = int.Parse(EN.Text);
            int height = int.Parse(BOY.Text);
            int depth = int.Parse(DERİNLİK.Text);

            Graphics g = pictureBox1.CreateGraphics();

            // Nokta çizimi
            g.FillEllipse(Brushes.Black, x, y, 5, 5);

            // Dikdörtgen prizma çizimi
            g.DrawRectangle(Pens.Red, x, y, width, height);
            g.DrawLine(Pens.Red, x, y, x - depth / 2, y - depth / 2);
            g.DrawLine(Pens.Red, x + width, y, x + width - depth / 2, y - depth / 2);
            g.DrawLine(Pens.Red, x, y + height, x - depth / 2, y + height - depth / 2);
            g.DrawLine(Pens.Red, x + width, y + height, x + width - depth / 2, y + height - depth / 2);
            g.DrawLine(Pens.Red, x - depth / 2, y - depth / 2, x + width - depth / 2, y - depth / 2);
            g.DrawLine(Pens.Red, x - depth / 2, y - depth / 2, x - depth / 2, y + height - depth / 2);
            g.DrawLine(Pens.Red, x - depth / 2, y + height - depth / 2, x + width - depth / 2, y + height - depth / 2);
            g.DrawLine(Pens.Red, x + width - depth / 2, y - depth / 2, x + width - depth / 2, y + height - depth / 2);


        }
    }
}
