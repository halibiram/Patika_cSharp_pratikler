using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama 
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Ayı" };

            int[] dizi;
            dizi = new int[3];

            //Dizilere değer atama ve erişim

            renkler[0] = "Kırmızı";
            dizi[2] = 5;

            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[2]);
            Console.WriteLine(hayvanlar[3]);
            int toplam = 0;
            //Döngülerde dizi kullanımı
            //Klavyeden girilen n tane sayının ortalaması hesaplayan program

            Console.Write("Lütfen dizinin eleman sayısını giriniz :");
            int dizisayisi = int.Parse(Console.ReadLine());

            int[] sayidizisi = new int[dizisayisi];

            for (int i = 0; i < dizisayisi; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz :", i + 1);
                sayidizisi[i] = int.Parse(Console.ReadLine());


            }
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Girilen sayıların ortalaması :" + toplam / dizisayisi);

            Console.ReadLine();

        }
    }
}
