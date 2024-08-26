/****************************************************************************
** SAKARYA ÜNÝVERSÝTESÝ
** BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
** BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
** PROGRAMLAMAYA GÝRÝÞÝ DERSÝ
**
** ÖDEV NUMARASI…...: PROJE 1
** ÖÐRENCÝ ADI...............: Tunahan DEMÝRCÝOÐLU
** ÖÐRENCÝ NUMARASI.: G221210373
** DERS GRUBU…………:  A GRUBU
YOUTUBE LÝNKÝ… …: https://www.youtube.com/watch?v=4Aiu8VuJQYI
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dikdörtgen prizma sýnýfý
public class DikdortgenPrizma
{
    public double Uzunluk { get; set; }
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}

// Çember sýnýfý
public class Cember
{
    public double Yaricap { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}

// Küre sýnýfý
public class Kure
{
    public double Yaricap { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}

// Kare sýnýfý
public class Kare
{
    public double KenarUzunlugu { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}

// Yüzey sýnýfý
public class Yuzey
{
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
    public double En { get; set; }
    public double Boy { get; set; }
}

// Nokta sýnýfý
public class Nokta
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
}

// Silindir sýnýfý
public class Silindir
{
    public double Yaricap { get; set; }
    public double Yukseklik { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}
public class Dikdortgen
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }

    public Dikdortgen(int x, int y, int genislik, int yukseklik)
    {
        X = x;
        Y = y;
        Genislik = genislik;
        Yukseklik = yukseklik;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Dikdörtgenlerin boyutlarýný kullanýcýdan al
            #region dikdörtgen dikdörtgen çarpýþmasý
            //Console.Write("1. Dikdörtgenin sol üst köþesinin X koordinatýný girin: ");
            //int dikdortgen1X = int.Parse(Console.ReadLine());

            //Console.Write("1. Dikdörtgenin sol üst köþesinin Y koordinatýný girin: ");
            //int dikdortgen1Y = int.Parse(Console.ReadLine());

            //Console.Write("1. Dikdörtgenin geniþliðini girin: ");
            //int dikdortgen1Genislik = int.Parse(Console.ReadLine());

            //Console.Write("1. Dikdörtgenin yüksekliðini girin: ");
            //int dikdortgen1Yukseklik = int.Parse(Console.ReadLine());

            //Console.Write("2. Dikdörtgenin sol üst köþesinin X koordinatýný girin: ");
            //int dikdortgen2X = int.Parse(Console.ReadLine());

            //Console.Write("2. Dikdörtgenin sol üst köþesinin Y koordinatýný girin: ");
            //int dikdortgen2Y = int.Parse(Console.ReadLine());

            //Console.Write("2. Dikdörtgenin geniþliðini girin: ");
            //int dikdortgen2Genislik = int.Parse(Console.ReadLine());

            //Console.Write("2. Dikdörtgenin yüksekliðini girin: ");
            //int dikdortgen2Yukseklik = int.Parse(Console.ReadLine());

            //// Dikdörtgen nesnelerini oluþtur
            //Dikdortgen dikdortgen1 = new Dikdortgen(dikdortgen1X, dikdortgen1Y, dikdortgen1Genislik, dikdortgen1Yukseklik);
            //Dikdortgen dikdortgen2 = new Dikdortgen(dikdortgen2X, dikdortgen2Y, dikdortgen2Genislik, dikdortgen2Yukseklik);

            //// Çarpýþma kontrolü yap
            //if (dikdortgen1.X < dikdortgen2.X + dikdortgen2.Genislik &&
            //    dikdortgen1.X + dikdortgen1.Genislik > dikdortgen2.X &&
            //    dikdortgen1.Y < dikdortgen2.Y + dikdortgen2.Yukseklik &&
            //    dikdortgen1.Y + dikdortgen1.Yukseklik > dikdortgen2.Y)
            //{
            //    Console.WriteLine("Ýki dikdörtgen çarpýþýyor!");
            //}
            //else
            //{
            //    Console.WriteLine("Ýki dikdörtgen çarpýþmýyor.");
            //}

            //Console.ReadLine(); 
            #endregion
            #region silindir silindir çarpýþmasý
            //Silindir silindir1 = new Silindir();
            //Console.WriteLine("1. silindirin özelliklerini girin:");
            //Console.Write("Yarýçap: ");
            //silindir1.Yaricap = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Yükseklik: ");
            //silindir1.Yukseklik = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Baþlangýç X: ");
            //silindir1.BaslangicX = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Baþlangýç Y: ");
            //silindir1.BaslangicY = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Baþlangýç Z: ");
            //silindir1.BaslangicZ = Convert.ToDouble(Console.ReadLine());

            //Silindir silindir2 = new Silindir();
            //Console.WriteLine("\n2. silindirin özelliklerini girin:");
            //Console.Write("Yarýçap: ");
            //silindir2.Yaricap = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Yükseklik: ");
            //silindir2.Yukseklik = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Baþlangýç X: ");
            //silindir2.BaslangicX = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Baþlangýç Y: ");
            //silindir2.BaslangicY = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Baþlangýç Z: ");
            //silindir2.BaslangicZ = Convert.ToDouble(Console.ReadLine());

            //// Silindirlerin çarpýþýp çarpýþmadýðýný kontrol et
            //bool carpistiMi = false;
            //double uzaklik = Math.Sqrt(Math.Pow(silindir2.BaslangicX - silindir1.BaslangicX, 2) +
            //                           Math.Pow(silindir2.BaslangicY - silindir1.BaslangicY, 2) +
            //                           Math.Pow(silindir2.BaslangicZ - silindir1.BaslangicZ, 2));
            //if (uzaklik <= silindir1.Yaricap + silindir2.Yaricap)
            //{
            //    carpistiMi = true;
            //}
            #endregion
            #region çember çember çarpýþmasý
            //// Ýlk çemberin deðerlerini kullanýcýdan alalým
            //Console.WriteLine("Ýlk çemberin deðerlerini giriniz:");
            //Console.Write("Yarýçap: ");
            //double yaricap1 = double.Parse(Console.ReadLine());
            //Console.Write("Baþlangýç X: ");
            //double baslangicX1 = double.Parse(Console.ReadLine());
            //Console.Write("Baþlangýç Y: ");
            //double baslangicY1 = double.Parse(Console.ReadLine());
            //Console.Write("Baþlangýç Z: ");
            //double baslangicZ1 = double.Parse(Console.ReadLine());

            //// Ýkinci çemberin deðerlerini kullanýcýdan alalým
            //Console.WriteLine("Ýkinci çemberin deðerlerini giriniz:");
            //Console.Write("Yarýçap: ");
            //double yaricap2 = double.Parse(Console.ReadLine());
            //Console.Write("Baþlangýç X: ");
            //double baslangicX2 = double.Parse(Console.ReadLine());
            //Console.Write("Baþlangýç Y: ");
            //double baslangicY2 = double.Parse(Console.ReadLine());
            //Console.Write("Baþlangýç Z: ");
            //double baslangicZ2 = double.Parse(Console.ReadLine());

            //// Ýki çemberi de oluþturalým
            //Cember cember1 = new Cember
            //{
            //    Yaricap = yaricap1,
            //    BaslangicX = baslangicX1,
            //    BaslangicY = baslangicY1,
            //    BaslangicZ = baslangicZ1
            //};
            //Cember cember2 = new Cember
            //{
            //    Yaricap = yaricap2,
            //    BaslangicX = baslangicX2,
            //    BaslangicY = baslangicY2,
            //    BaslangicZ = baslangicZ2
            //};

            //// Çarpýþmayý kontrol edelim
            //double mesafe = Math.Sqrt(Math.Pow(cember2.BaslangicX - cember1.BaslangicX, 2) +
            //                          Math.Pow(cember2.BaslangicY - cember1.BaslangicY, 2) +
            //                          Math.Pow(cember2.BaslangicZ - cember1.BaslangicZ, 2));
            //if (mesafe < (cember1.Yaricap + cember2.Yaricap))
            //{
            //    Console.WriteLine("Ýki çember çarpýþýyor!");
            //}
            //else
            //{
            //    Console.WriteLine("Ýki çember çarpmýyor.");
            //}
            #endregion

        }
    }
}
