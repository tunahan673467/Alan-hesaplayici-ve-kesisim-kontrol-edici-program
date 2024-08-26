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
    public partial class yüzeysilindir : Form
    {
        public yüzeysilindir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float surfaceX = float.Parse(X1.Text);
            float surfaceY = float.Parse(Y1.Text);
            float surfaceZ = float.Parse(Z1.Text);
            float surfaceWidth = float.Parse(EN.Text);
            float surfaceHeight = float.Parse(BOY.Text);

            // Silindirin bilgileri
            float cylinderX = float.Parse(X2.Text);
            float cylinderY = float.Parse(Y2.Text);
            float cylinderZ = float.Parse(Z2.Text);
            float cylinderRadius = float.Parse(YARIÇAP.Text);
            float cylinderHeight = float.Parse(YÜKSEKLİK.Text);

            // Silindirin merkezine göre yüzeyin konumu
            float surfaceCenterX = surfaceX + surfaceWidth / 2f;
            float surfaceCenterY = surfaceY + surfaceHeight / 2f;
            float surfaceCenterZ = surfaceZ;

            // Silindirin merkezine göre mesafe
            float distanceX = Math.Abs(surfaceCenterX - cylinderX);
            float distanceY = Math.Abs(surfaceCenterY - cylinderY);
            float distanceZ = Math.Abs(surfaceCenterZ - cylinderZ);
            float distance = (float)Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);

            // Silindir yüzeye temas ederse
            if (distance <= cylinderRadius)
            {
                MessageBox.Show("Silindir yüzeye temas eder.");
                return;
            }

            // Silindir yüzeyin içine düşerse
            if (distance <= cylinderRadius + surfaceWidth / 2f && distanceY <= surfaceHeight / 2f)
            {
                MessageBox.Show("Silindir yüzeyin içine düşer.");
                return;
            }

            MessageBox.Show("Silindir yüzeyle çarpmaz.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Yüzey değerlerini al
            float yuzeyX = float.Parse(X1.Text);
            float yuzeyY = float.Parse(Y1.Text);
            float yuzeyZ = float.Parse(Z1.Text);
            float yuzeyGenislik = float.Parse(EN.Text);
            float yuzeyYukseklik = float.Parse(BOY.Text);

            // Silindir değerlerini al
            float silindirX = float.Parse(X2.Text);
            float silindirY = float.Parse(Y2.Text);
            float silindirZ = float.Parse(Z2.Text);
            float silindirYaricap = float.Parse(YARIÇAP.Text);
            float silindirYukseklik = float.Parse(YÜKSEKLİK.Text);

            // Picturebox üzerine çizim yapmak için Graphics objesi oluştur
            Graphics gfx = pictureBox1.CreateGraphics();

            // Yüzeyi çiz
            Pen yuzeyKalem = new Pen(Color.Blue, 2);
            gfx.DrawRectangle(yuzeyKalem, yuzeyX, yuzeyY, yuzeyGenislik, yuzeyYukseklik);

            // Silindiri çiz
            Pen silindirKalem = new Pen(Color.Red, 2);
            gfx.DrawEllipse(silindirKalem, silindirX - silindirYaricap, silindirY - silindirYaricap, silindirYaricap * 2, silindirYaricap * 2);
            gfx.DrawLine(silindirKalem, silindirX - silindirYaricap, silindirY, silindirX + silindirYaricap, silindirY);
            gfx.DrawLine(silindirKalem, silindirX, silindirY - silindirYaricap, silindirX, silindirY + silindirYaricap);
            gfx.DrawLine(silindirKalem, silindirX - silindirYaricap, silindirY + silindirYukseklik, silindirX + silindirYaricap, silindirY + silindirYukseklik);
            gfx.DrawArc(silindirKalem, silindirX - silindirYaricap, silindirY + silindirYukseklik - silindirYaricap * 2, silindirYaricap * 2, silindirYaricap * 2, 0, -180);
            gfx.DrawArc(silindirKalem, silindirX - silindirYaricap, silindirY - silindirYaricap * 2, silindirYaricap * 2, silindirYaricap * 2, 0, 180);



        }
    }
}
