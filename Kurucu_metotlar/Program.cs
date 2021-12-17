using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurucu_metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Söz dilimi
            //class SinifAdi
            //{
            //      [Erişim belirleyici] [Veri tipi] ÖzellikAdi;
            //      [Erişim belirleyici] [Geri döüş veri tipi] MetotAdi([Parametrelistesi])
            //      {
            //         Metot Komutları
            //      }
            // }

            //Erişim Belirleyiciler
            // * Public
            // * Private
            // * protected
            // * internal
            Console.WriteLine("**********Calisan 1***********");
            calisanlar calisan1=new calisanlar("Ayşe","Kara",26545445,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("**********Çalışan 2***********");
            calisanlar calisan2 = new calisanlar();
            calisan2.Ad = "Deniz";
            calisan2.Soyadi = "Arda";
            calisan2.No = 26545212;
            calisan2.Departmani = "Satın alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("***********Çalışan 3***********");
            calisanlar calisan3 = new calisanlar("Zikriye", "Ürkmez");
            calisan3.CalisanBilgileri();

            Console.ReadLine();


            


        }
    }

    class calisanlar
    {
        public string Ad;
        public string Soyadi;
        public int No;
        public string Departmani;

        public calisanlar(string ad, string soyadi, int no,string departmani)
        {
            this.Ad = ad;
            this.Soyadi = soyadi;
            this.No = no;
            this.Departmani = departmani;
        }

        public calisanlar(string ad, string soyadi)
        {
            this.Ad = ad;
            this.Soyadi = soyadi;
           
        }
        public calisanlar() { }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın adı: {0}" ,Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", Soyadi);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departmani);
        }
    }
}
