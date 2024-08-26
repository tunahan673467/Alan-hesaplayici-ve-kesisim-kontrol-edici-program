
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
YOUTUBE LİNKİ… …:https://www.youtube.com/watch?v=4Aiu8VuJQYI
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

namespace ÖDEV_ASIL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            noktadörtgen noktadörtgen = new noktadörtgen();
            noktadörtgen.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            noktaçember noktaçember = new noktaçember();
            noktaçember.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dikdörtgendikdörtgen dikdörtgendikdörtgen = new dikdörtgendikdörtgen();
            dikdörtgendikdörtgen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dikdörtgençember dikdörtgençember = new dikdörtgençember();
            dikdörtgençember.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            çemberçember çemberçember = new çemberçember();
            çemberçember.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            noktaküre noktaküre = new noktaküre();
            noktaküre.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            noktadikdörtgenprizma noktadikdörtgenprizma = new noktadikdörtgenprizma();
            noktadikdörtgenprizma.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            noktasilindir noktasilindir = new noktasilindir();
            noktasilindir.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            silindirsilindir silindirsilindir = new silindirsilindir();
            silindirsilindir.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            küreküre küreküre = new küreküre();
            küreküre.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            yüzeyküre yüzeyküre = new yüzeyküre();
            yüzeyküre.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            yüzeydikdörtgenprizma yüzeydikdörtgenprizma = new yüzeydikdörtgenprizma();
            yüzeydikdörtgenprizma.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            yüzeysilindir yüzeysilindiir = new yüzeysilindir();
            yüzeysilindiir.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            küredikdörtgenlerprizması küredikdörtgenlerprizması = new küredikdörtgenlerprizması();
            küredikdörtgenlerprizması.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            dikdörtgenprizmadikdörtgenprizma dikdörtgenprizmadikdörtgenprizma = new dikdörtgenprizmadikdörtgenprizma();
            dikdörtgenprizmadikdörtgenprizma.Show();
            this.Hide();
        }   
    }
}
