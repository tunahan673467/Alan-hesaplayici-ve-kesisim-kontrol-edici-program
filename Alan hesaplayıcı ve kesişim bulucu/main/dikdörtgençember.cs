
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI…...: PROJE 1
** ÖĞRENCİ ADI...............: Tunahan DEMİRCİOĞLU
** ÖĞRENCİ NUMARASI.: G221210373
** DERS GRUBU…………:  A GRUBU
YOUTUBE LİNKİ… …:
****************************************************************************/






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
    public partial class dikdörtgençember : Form
    {
        public dikdörtgençember()
        {
            InitializeComponent();
        }
        private Rectangle rectangle;
        private int radius;
        private Point center;

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(X1.Text);
            int y = int.Parse(EN1.Text);
            int width = int.Parse(BOY1.Text);
            int height = int.Parse(Y2.Text);

            // Dairenin yarıçapını ve merkez noktasını TextBox'lardan alıyoruz.
            radius = int.Parse(YARIÇAP.Text);
            center = new Point(int.Parse(X2.Text), int.Parse(Y1.Text));

            // Dikdörtgeni ve daireyi oluşturuyoruz.
            rectangle = new Rectangle(x, y, width, height);
            Rectangle circleRect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);

            // İki şeklin çarpışıp çarpmadığını kontrol ediyoruz.
            if (rectangle.IntersectsWith(circleRect))
            {
                MessageBox.Show("Dikdörtgen ve daire çarpışıyor!");

            }
            else
            {
                MessageBox.Show("Dikdörtgen ve daire çarpışmıyor.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(X1.Text);
            int y1 = int.Parse(Y1.Text);
            int width = int.Parse(EN1.Text);
            int height = int.Parse(BOY1.Text);

            // çemberin koordinatlarını ve yarıçapını alın
            int x2 = int.Parse(X2.Text);
            int y2 = int.Parse(Y2.Text);
            int radius = int.Parse(YARIÇAP.Text);

            // Picturebox üzerindeki grafik nesnesini alın
            Graphics g = pictureBox1.CreateGraphics();

            // dikdörtgeni çizdir
            g.DrawRectangle(Pens.Black, x1, y1, width, height);

            // çemberi çizdir
            g.DrawEllipse(Pens.Red, x2 - radius, y2 - radius, radius * 2, radius * 2);
        }



    }
}

