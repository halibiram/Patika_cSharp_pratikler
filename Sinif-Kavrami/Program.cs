using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif__Kavrami
{
    class Program
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
            //Public
            //Private
            //protected
            //internal

            calisanlar calisanlar1 = new calisanlar();
            calisanlar1.adi = "Ayşe";
            calisanlar1.soyadi = "Kara";
            calisanlar1.No = 25674521;
            calisanlar1.departmani = "İnsan Kaynakları";
            calisanlar1.CalisanBilgileri();
            Console.WriteLine("***************************");

            calisanlar calisanlar2= new calisanlar();
            calisanlar2.adi = "Ahmet";
            calisanlar2.soyadi = "Çalışkan";
            calisanlar2.No = 25644523;
            calisanlar2.departmani = "Satın Alma";
            calisanlar2.CalisanBilgileri();


            Console.ReadKey();



            


        }
    }
    class calisanlar
    {
        public string adi;

        public string soyadi;

        public int No;

        public string departmani;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalısanın Adi: {0}" ,adi);
            Console.WriteLine("Çalısanın Soyadi: {0}", soyadi);
            Console.WriteLine("Çalısanın Numarası: {0}", No);
            Console.WriteLine("Çalısanın Departmanı: {0}", departmani);
        }


    }
}
