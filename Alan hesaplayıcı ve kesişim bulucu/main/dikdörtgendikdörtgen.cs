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
    public partial class dikdörtgendikdörtgen : Form
    {
        public dikdörtgendikdörtgen()
        {
            InitializeComponent();
        }

        private Rectangle rectangle1;
        private Rectangle rectangle2;

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(X1.Text);
            int y1 = int.Parse(Y1.Text);
            int width1 = int.Parse(EN.Text);
            int height1 = int.Parse(BOY.Text);

            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);
            int width2 = int.Parse(EN2.Text);
            int height2 = int.Parse(BOY2.Text);

            // İki dikdörtgeni oluşturuyoruz.
            rectangle1 = new Rectangle(x1, y1, width1, height1);
            rectangle2 = new Rectangle(x2, y2, width2, height2);

            // İki dikdörtgenin çarpışıp çarpmadığını kontrol ediyoruz.
            if (rectangle1.IntersectsWith(rectangle2))
            {
                MessageBox.Show("Dikdörtgenler çarpışıyor!");

            }
            else
            {
                MessageBox.Show("Dikdörtgenler çarpışmıyor.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(X1.Text);
            int y1 = int.Parse(Y1.Text);
            int w1 = int.Parse(EN.Text);
            int h1 = int.Parse(BOY.Text);

            // İkinci dikdörtgenin koordinatlarını al
            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);
            int w2 = int.Parse(EN2.Text);
            int h2 = int.Parse(BOY2.Text);

            // PictureBox üzerinde çizim yapmak için bir Graphics nesnesi oluştur
            Graphics g = pictureBox1.CreateGraphics();

            // İlk dikdörtgeni çiz
            g.DrawRectangle(Pens.Black, x1, y1, w1, h1);

            // İkinci dikdörtgeni çiz
            g.DrawRectangle(Pens.Red, x2, y2, w2, h2);
        }
    }
}
