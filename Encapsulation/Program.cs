using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1 = new ogrenci();
            ogrenci1.Isim = "Ayşe";
            ogrenci1.Soyisim = "Yılmaz";
            ogrenci1.Ogrenino = 256;
            ogrenci1.Sinif = 3;

            ogrenci1.OgrenciBilgileriniGöster();
            ogrenci1.SinifArtır();
            ogrenci1.OgrenciBilgileriniGöster();

            ogrenci ogrenci2 = new ogrenci("Murat", "Kaya", 235, 1);
            ogrenci2.SinifAzalt();
            ogrenci2.SinifAzalt();
            ogrenci2.OgrenciBilgileriniGöster();
            

            Console.ReadLine();


        }
    }
    class ogrenci
    {
        private string isim;

        private string soyisim;

        private int ogrenino;

        private int sinif;

        public string Isim {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Ogrenino { get => ogrenino; set => ogrenino = value; }
        public int Sinif {
            get => sinif;

            set {
                if (value <1)
                {
                    Console.WriteLine("En az 1. sınıf olmak zorunda!");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public ogrenci(string ısim, string soyisim, int ogrenino, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            Ogrenino = ogrenino;
            Sinif = sinif;
        }
        public ogrenci() { }

        public void OgrenciBilgileriniGöster()
        {
            Console.WriteLine("**********Öğrenci Bilgileri***********");
            Console.WriteLine("Öğrenci Adi          : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadi       : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci Numarası     : {0}", this.Ogrenino);
            Console.WriteLine("Öğrenci Sınıfı       : {0}", this.Sinif);
        }
        public void SinifArtır()
        {
            Sinif += 1;

        }
        public void SinifAzalt()
        {
            Sinif -= 1;
        }

    }
}
