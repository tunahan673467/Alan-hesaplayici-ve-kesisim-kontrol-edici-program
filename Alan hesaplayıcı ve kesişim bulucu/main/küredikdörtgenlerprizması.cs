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
    public partial class küredikdörtgenlerprizması : Form
    {
        public küredikdörtgenlerprizması()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float prizmaWidth = float.Parse(EN.Text);
            float prizmaHeight = float.Parse(BOY.Text);
            float prizmaDepth = float.Parse(DERİNLİK.Text);

            // Kürenin ölçüleri
            float sphereRadius = float.Parse(YARIÇAP.Text);

            // Kürenin merkez koordinatları
            float sphereX = float.Parse(X1.Text);
            float sphereY = float.Parse(Y1.Text);
            float sphereZ = float.Parse(Z1.Text);

            // Prizmanın merkez koordinatları
            float prizmaX = float.Parse(X2.Text);
            float prizmaY = float.Parse(Y2.Text);
            float prizmaZ = float.Parse(Z2.Text);

            // Prizmanın sınırlarının belirlenmesi
            float xMin = prizmaX - prizmaWidth / 2;
            float xMax = prizmaX + prizmaWidth / 2;
            float yMin = prizmaY - prizmaHeight / 2;
            float yMax = prizmaY + prizmaHeight / 2;
            float zMin = prizmaZ - prizmaDepth / 2;
            float zMax = prizmaZ + prizmaDepth / 2;

            // Kürenin sınırlarının belirlenmesi
            float sphereXMin = sphereX - sphereRadius;
            float sphereXMax = sphereX + sphereRadius;
            float sphereYMin = sphereY - sphereRadius;
            float sphereYMax = sphereY + sphereRadius;
            float sphereZMin = sphereZ - sphereRadius;
            float sphereZMax = sphereZ + sphereRadius;

            // Çarpışma kontrolü
            bool isColliding = (sphereXMin <= xMax && sphereXMax >= xMin) &&
                               (sphereYMin <= yMax && sphereYMax >= yMin) &&
                               (sphereZMin <= zMax && sphereZMax >= zMin);

            if (isColliding)
            {
                MessageBox.Show("Dikdörtgen prizma ve küre çarpışıyor!");
            }
            else
            {
                MessageBox.Show("Dikdörtgen prizma ve küre çarpışmıyor.");
            }

        }
    }
}
