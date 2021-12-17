using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {           /* Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)



                    Negatif ve numeric olmayan girişleri engelleyin.
                    Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                    Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/
        static void Main(string[] args)
        {
            ArrayList Asal = new ArrayList();
            ArrayList AsalDegil = new ArrayList();
            bool kontrol;
            int sayi = 0;
            
            for (int i = 0; i < 20; i++)
            {   basla:
                try
                {
                    Console.Write("Sayı giriniz :");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi <= 0)
                    {
                        Console.WriteLine("Hata! Pozitif sayı giriniz!.");
                        goto basla;
                    }



                }
                catch (Exception)
                {
                    
                    Console.WriteLine("Hatalı giriş yaptınız... Tekrar deneyin");
                    goto basla;

                }
                

                kontrol=AsalKontrol(sayi);
                if (kontrol == true)
                {
                    Asal.Add(sayi);
                    
                }
                else
                    AsalDegil.Add(sayi);

                


            }
            EkranaYazdir(Asal, "Asal sayılar");
            EkranaYazdir(AsalDegil, "Asal olmayan sayılar");
            Ortalamasi(Asal, "asal");
            Ortalamasi(AsalDegil, "asal olmayan");



            Console.ReadLine();
        }

        static bool AsalKontrol(int param)
        {
            int sayac = 0;
            for (int i = 1; i < param; i++)
            {
                if (param % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 1)
            {
                return true;
            }
            else
                return false;
        }

        static void EkranaYazdir(ArrayList a,string b)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine(b);
            a.Sort();
            a.Reverse();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }



        }
        static void Ortalamasi(ArrayList a,string b)
        {
            double toplam = 0;
            double sayac = 0;
            foreach(var item in a)
            {
                double gecici = Convert.ToDouble(item);

                toplam += gecici;
                sayac++;

            }
            Console.WriteLine("***********************************************************");
            Console.WriteLine(sayac +" Elemanlı "+b +" sayıların ortalaması :"+(toplam/sayac));
        }
    }
}
