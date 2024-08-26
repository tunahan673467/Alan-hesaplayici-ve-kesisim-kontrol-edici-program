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
    public partial class dikdörtgenprizmadikdörtgenprizma : Form
    {
        public dikdörtgenprizmadikdörtgenprizma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x1 = float.Parse(X1.Text);
            float y1 = float.Parse(Y1.Text);
            float z1 = float.Parse(Z1.Text);
            float w1 = float.Parse(EN1.Text);
            float h1 = float.Parse(BOY1.Text);
            float d1 = float.Parse(DERİNLİK1.Text);

            // Dikdörtgen prizma 2 özellikleri
            float x2 = float.Parse(X2.Text);
            float y2 = float.Parse(Y2.Text);
            float z2 = float.Parse(Z2.Text);
            float w2 = float.Parse(EN2.Text);
            float h2 = float.Parse(BOY2.Text);
            float d2 = float.Parse(YÜKSEKLİK2.Text);

            // Dikdörtgen prizma 1'in koordinatları
            float x1Min = x1 - (w1 / 2);
            float x1Max = x1 + (w1 / 2);
            float y1Min = y1 - (h1 / 2);
            float y1Max = y1 + (h1 / 2);
            float z1Min = z1 - (d1 / 2);
            float z1Max = z1 + (d1 / 2);

            // Dikdörtgen prizma 2'in koordinatları
            float x2Min = x2 - (w2 / 2);
            float x2Max = x2 + (w2 / 2);
            float y2Min = y2 - (h2 / 2);
            float y2Max = y2 + (h2 / 2);
            float z2Min = z2 - (d2 / 2);
            float z2Max = z2 + (d2 / 2);

            // Çarpışma kontrolü
            bool isCollision = !(x1Max < x2Min || x2Max < x1Min || y1Max < y2Min || y2Max < y1Min || z1Max < z2Min || z2Max < z1Min);

            if (isCollision)
            {
                MessageBox.Show("Dikdörtgen prizmaları çarpışıyor!");
            }
            else
            {
                MessageBox.Show("Dikdörtgen prizmaları çarpmıyor.");
            }

        }
    }
}
