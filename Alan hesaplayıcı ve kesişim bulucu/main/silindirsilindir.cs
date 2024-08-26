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
    public partial class silindirsilindir : Form
    {
        public silindirsilindir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Silindir 1
            double x1 = Convert.ToDouble(X1.Text);
            double y1 = Convert.ToDouble(Y1.Text);
            double z1 = Convert.ToDouble(Z1.Text); // Yükseklik
            double r1 = Convert.ToDouble(YARIÇAP.Text);

            // Silindir 2
            double x2 = Convert.ToDouble(X2.Text);
            double y2 = Convert.ToDouble(Y2.Text);
            double z2 = Convert.ToDouble(Z2.Text); // Yükseklik
            double r2 = Convert.ToDouble(YARIÇAP2.Text);

            // İki silindirin merkezleri arasındaki mesafe
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

            // İki silindirin yarıçapları toplamı
            double sumOfRadii = r1 + r2;

            // İki silindir çarpışıyorsa
            if (distance <= sumOfRadii)
            {
                MessageBox.Show("Silindirler birbirine çarpıyor!");
            }
            else
            {
                MessageBox.Show("Silindirler birbirine çarpmıyor!");
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(X1.Text);
            int y1 = int.Parse(Y1.Text);
            int r = int.Parse(YARIÇAP.Text);
            int h = int.Parse(YÜKSEKLİK.Text);

            Graphics g = pictureBox1.CreateGraphics();
            g.DrawEllipse(Pens.Black, x1, y1, 2 * r, 2 * r);
            g.DrawLine(Pens.Black, x1, y1 + r, x1, y1 + r + h);
            g.DrawLine(Pens.Black, x1 + 2 * r, y1 + r, x1 + 2 * r, y1 + r + h);
            g.DrawEllipse(Pens.Black, x1, y1 + h, 2 * r, 2 * r);

            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);
            int r2 = int.Parse(YARIÇAP2.Text);
            int h2 = int.Parse(YÜKSEKLİK2.Text);

            Graphics f = pictureBox1.CreateGraphics();
            g.DrawEllipse(Pens.Blue, x2, y2, 2 * r2, 2 * r2);
            g.DrawLine(Pens.Blue, x2, y2 + r2, x2, y2 + r2 + h2);
            g.DrawLine(Pens.Blue, x2 + 2 * r2, y2 + r2, x1 + 2 * r2, y2 + r2 + h2);
            g.DrawEllipse(Pens.Blue, x2, y2 + h2, 2 * r2, 2 * r2);


        }
    }
}
