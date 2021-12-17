using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Sinif_ve_Uyeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayısı : {0}",calisan.CalisanSayisi1);

            calisan calisan1=new calisan("Ayse","Yılmaz","IK");
            Console.WriteLine("Calisan Sayısı : {0}", calisan.CalisanSayisi1);
            calisan calisan2 = new calisan("Deniz", "Arda", "IK");
            calisan calisan3 = new calisan("Zikriye", "Ürkmez", "IK");
            Console.WriteLine("Calisan Sayısı : {0}", calisan.CalisanSayisi1);

            Console.WriteLine("Sayıların Toplamı :"+islemler.Topla(100,200));
            Console.WriteLine("Sayıların Çıkarımı :"+islemler.Cikar(400,50));


            Console.ReadKey();
        }
    }
    class calisan
    {
        private static int CalisanSayisi;

        public static int CalisanSayisi1 { get => CalisanSayisi; set => CalisanSayisi = value; }

        private string Isim;

        private string Soyisim;

        private string Departman;

        static calisan()
        {
            CalisanSayisi = 0;
        }

        public calisan(string isim,string soyisim,string departman)
        {
            this.Isim = isim;
            
            this.Soyisim = soyisim;

            this.Departman = departman;
            CalisanSayisi++;

        

        }
    }
    static class islemler
    {
        public static long Topla(int a,int b)
        {
            return a + b;
        }

        public static long Cikar(int a,int b)
        {
            return a - b;
        }
    }
}
