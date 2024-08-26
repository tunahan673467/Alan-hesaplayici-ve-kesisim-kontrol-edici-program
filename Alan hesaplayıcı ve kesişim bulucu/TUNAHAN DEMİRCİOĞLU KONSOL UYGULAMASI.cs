/****************************************************************************
** SAKARYA �N�VERS�TES�
** B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
** B�LG�SAYAR M�HEND�SL��� B�L�M�
** PROGRAMLAMAYA G�R��� DERS�
**
** �DEV NUMARASI�...: PROJE 1
** ��RENC� ADI...............: Tunahan DEM�RC�O�LU
** ��RENC� NUMARASI.: G221210373
** DERS GRUBU����:  A GRUBU
YOUTUBE L�NK݅ �: https://www.youtube.com/watch?v=4Aiu8VuJQYI
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dikd�rtgen prizma s�n�f�
public class DikdortgenPrizma
{
    public double Uzunluk { get; set; }
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}

// �ember s�n�f�
public class Cember
{
    public double Yaricap { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}

// K�re s�n�f�
public class Kure
{
    public double Yaricap { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}

// Kare s�n�f�
public class Kare
{
    public double KenarUzunlugu { get; set; }
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
}

// Y�zey s�n�f�
public class Yuzey
{
    public double BaslangicX { get; set; }
    public double BaslangicY { get; set; }
    public double BaslangicZ { get; set; }
    public double En { get; set; }
    public double Boy { get; set; }
}

// Nokta s�n�f�
public class Nokta
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
}

// Silindir s�n�f�
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
            // Dikd�rtgenlerin boyutlar�n� kullan�c�dan al
            #region dikd�rtgen dikd�rtgen �arp��mas�
            //Console.Write("1. Dikd�rtgenin sol �st k��esinin X koordinat�n� girin: ");
            //int dikdortgen1X = int.Parse(Console.ReadLine());

            //Console.Write("1. Dikd�rtgenin sol �st k��esinin Y koordinat�n� girin: ");
            //int dikdortgen1Y = int.Parse(Console.ReadLine());

            //Console.Write("1. Dikd�rtgenin geni�li�ini girin: ");
            //int dikdortgen1Genislik = int.Parse(Console.ReadLine());

            //Console.Write("1. Dikd�rtgenin y�ksekli�ini girin: ");
            //int dikdortgen1Yukseklik = int.Parse(Console.ReadLine());

            //Console.Write("2. Dikd�rtgenin sol �st k��esinin X koordinat�n� girin: ");
            //int dikdortgen2X = int.Parse(Console.ReadLine());

            //Console.Write("2. Dikd�rtgenin sol �st k��esinin Y koordinat�n� girin: ");
            //int dikdortgen2Y = int.Parse(Console.ReadLine());

            //Console.Write("2. Dikd�rtgenin geni�li�ini girin: ");
            //int dikdortgen2Genislik = int.Parse(Console.ReadLine());

            //Console.Write("2. Dikd�rtgenin y�ksekli�ini girin: ");
            //int dikdortgen2Yukseklik = int.Parse(Console.ReadLine());

            //// Dikd�rtgen nesnelerini olu�tur
            //Dikdortgen dikdortgen1 = new Dikdortgen(dikdortgen1X, dikdortgen1Y, dikdortgen1Genislik, dikdortgen1Yukseklik);
            //Dikdortgen dikdortgen2 = new Dikdortgen(dikdortgen2X, dikdortgen2Y, dikdortgen2Genislik, dikdortgen2Yukseklik);

            //// �arp��ma kontrol� yap
            //if (dikdortgen1.X < dikdortgen2.X + dikdortgen2.Genislik &&
            //    dikdortgen1.X + dikdortgen1.Genislik > dikdortgen2.X &&
            //    dikdortgen1.Y < dikdortgen2.Y + dikdortgen2.Yukseklik &&
            //    dikdortgen1.Y + dikdortgen1.Yukseklik > dikdortgen2.Y)
            //{
            //    Console.WriteLine("�ki dikd�rtgen �arp���yor!");
            //}
            //else
            //{
            //    Console.WriteLine("�ki dikd�rtgen �arp��m�yor.");
            //}

            //Console.ReadLine(); 
            #endregion
            #region silindir silindir �arp��mas�
            //Silindir silindir1 = new Silindir();
            //Console.WriteLine("1. silindirin �zelliklerini girin:");
            //Console.Write("Yar��ap: ");
            //silindir1.Yaricap = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y�kseklik: ");
            //silindir1.Yukseklik = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ba�lang�� X: ");
            //silindir1.BaslangicX = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ba�lang�� Y: ");
            //silindir1.BaslangicY = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ba�lang�� Z: ");
            //silindir1.BaslangicZ = Convert.ToDouble(Console.ReadLine());

            //Silindir silindir2 = new Silindir();
            //Console.WriteLine("\n2. silindirin �zelliklerini girin:");
            //Console.Write("Yar��ap: ");
            //silindir2.Yaricap = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Y�kseklik: ");
            //silindir2.Yukseklik = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ba�lang�� X: ");
            //silindir2.BaslangicX = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ba�lang�� Y: ");
            //silindir2.BaslangicY = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Ba�lang�� Z: ");
            //silindir2.BaslangicZ = Convert.ToDouble(Console.ReadLine());

            //// Silindirlerin �arp���p �arp��mad���n� kontrol et
            //bool carpistiMi = false;
            //double uzaklik = Math.Sqrt(Math.Pow(silindir2.BaslangicX - silindir1.BaslangicX, 2) +
            //                           Math.Pow(silindir2.BaslangicY - silindir1.BaslangicY, 2) +
            //                           Math.Pow(silindir2.BaslangicZ - silindir1.BaslangicZ, 2));
            //if (uzaklik <= silindir1.Yaricap + silindir2.Yaricap)
            //{
            //    carpistiMi = true;
            //}
            #endregion
            #region �ember �ember �arp��mas�
            //// �lk �emberin de�erlerini kullan�c�dan alal�m
            //Console.WriteLine("�lk �emberin de�erlerini giriniz:");
            //Console.Write("Yar��ap: ");
            //double yaricap1 = double.Parse(Console.ReadLine());
            //Console.Write("Ba�lang�� X: ");
            //double baslangicX1 = double.Parse(Console.ReadLine());
            //Console.Write("Ba�lang�� Y: ");
            //double baslangicY1 = double.Parse(Console.ReadLine());
            //Console.Write("Ba�lang�� Z: ");
            //double baslangicZ1 = double.Parse(Console.ReadLine());

            //// �kinci �emberin de�erlerini kullan�c�dan alal�m
            //Console.WriteLine("�kinci �emberin de�erlerini giriniz:");
            //Console.Write("Yar��ap: ");
            //double yaricap2 = double.Parse(Console.ReadLine());
            //Console.Write("Ba�lang�� X: ");
            //double baslangicX2 = double.Parse(Console.ReadLine());
            //Console.Write("Ba�lang�� Y: ");
            //double baslangicY2 = double.Parse(Console.ReadLine());
            //Console.Write("Ba�lang�� Z: ");
            //double baslangicZ2 = double.Parse(Console.ReadLine());

            //// �ki �emberi de olu�tural�m
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

            //// �arp��may� kontrol edelim
            //double mesafe = Math.Sqrt(Math.Pow(cember2.BaslangicX - cember1.BaslangicX, 2) +
            //                          Math.Pow(cember2.BaslangicY - cember1.BaslangicY, 2) +
            //                          Math.Pow(cember2.BaslangicZ - cember1.BaslangicZ, 2));
            //if (mesafe < (cember1.Yaricap + cember2.Yaricap))
            //{
            //    Console.WriteLine("�ki �ember �arp���yor!");
            //}
            //else
            //{
            //    Console.WriteLine("�ki �ember �arpm�yor.");
            //}
            #endregion

        }
    }
}
