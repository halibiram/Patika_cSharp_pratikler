using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Koleksiyonlar_ve_List
{
    class Program
    {
        static void Main(string[] args)
        {

            //list<T> class
            //System.Collections.Generic
            //T-> object türünde

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(5);
            sayiListesi.Add(8);
            sayiListesi.Add(13);
            sayiListesi.Add(2);
            sayiListesi.Add(12);
            sayiListesi.Add(27);

            List<string> RenkListesi = new List<string>();

            RenkListesi.Add("Kırmızı");
            RenkListesi.Add("Mavi");
            RenkListesi.Add("Sarı");
            RenkListesi.Add("Siyah");
            RenkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(RenkListesi.Count());
            Console.WriteLine(sayiListesi.Count());


            //foreach ve list.foreach 
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in RenkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            RenkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(12);
            RenkListesi.Remove("Siyah");
            sayiListesi.RemoveAt(0);
            RenkListesi.RemoveAt(2);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            RenkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinden arama
            if (sayiListesi.Contains(5))
            {
                Console.WriteLine("5 liste içerisinde bulundu.");
            }

            //Eleman ile index numarasına erişme
            Console.WriteLine(RenkListesi.BinarySearch("Sari"));
            //Diziyi listeye çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };

            List<String> HayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz..

            HayvanListesi.Clear();

            //List içerisinde nesne tutma
            List<kullanicilar> KullaniListesi = new List<kullanicilar>();
            kullanicilar kullanici1 = new kullanicilar();

            kullanici1.Isim = "Ali";
            kullanici1.Soyisim = "Ata";
            kullanici1.Yas = 32;

            kullanicilar kullanici2 = new kullanicilar();

            kullanici2.Isim = "Ayşe";
            kullanici2.Soyisim = "Yılmaz";
            kullanici2.Yas = 26;

            KullaniListesi.Add(kullanici1);
            KullaniListesi.Add(kullanici2);

            List<kullanicilar> Yeniliste = new List<kullanicilar>();

            Yeniliste.Add(new kullanicilar() {

                Isim = "Murat",
                Soyisim = "Kaya",
                Yas = 28
            });

            foreach (var kullanici in KullaniListesi)
            {
                Console.WriteLine( "Kullanici isim :"+kullanici.Isim);
                Console.WriteLine("Kullanici Soyisim :" + kullanici.Soyisim);
                Console.WriteLine("Kullanici Yas :" + kullanici.Yas);
            }




            Console.ReadLine();

        }

        public class kullanicilar
        {
            private string isim;

            private string soyisim;

            private int yas;


            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }

            public int Yas { get => yas; set => yas = value; }

        }
    }
}
