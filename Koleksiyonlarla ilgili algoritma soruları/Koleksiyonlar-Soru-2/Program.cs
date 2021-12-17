using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {       /*Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
             * her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
             * (Array sınıfını kullanarak yazınız.)*/
        static void Main(string[] args)
        {
            int[] liste = new int[5];
            int[] EnBuyuk = new int[3];
            int[] EnKucuk = new int[3];
            double bort = 0;
            double kort = 0;
            int sayi = 0;
            for (int i = 0; i < 5; i++)
            {
            basla:
                try
                {
                    Console.WriteLine("Sayi giriniz");
                    sayi = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı karakter girdiniz...");
                    goto basla;
                }

                liste[i] = sayi;

            }


            liste = Siralama(liste);

            EnKucuk = Uckucuk(liste, EnKucuk, 0);
            EnBuyuk = UcBuyuk(liste, EnBuyuk, liste.Length - 1);

            bort = Ortalama(EnBuyuk, "En büyük");
            kort = Ortalama(EnKucuk, "En küçük");
            
            toplamlari(bort, kort);

            Console.ReadLine();

        }
        static int[] Siralama(int[] a)
        {
            int gecicisayi = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        gecicisayi = a[i];
                        a[i] = a[j];
                        a[j] = gecicisayi;
                    }
                }
            }
            return a;


        }
        static int[] Uckucuk(int[] param, int[] deger, int basla)
        {
            int sayac = 0;
            for (int i = basla; i < 3; i++)
            {
                deger[sayac] = param[i];
                sayac++;
            }
            return deger;
        }
        static int[] UcBuyuk(int[] param, int[] deger, int basla)
        {
            int sayac = 0;
            for (int j = basla; j > basla - 3; j--)
            {
                deger[sayac] = param[j];
                sayac++;
            }
            return deger;
        }

        static double Ortalama(int[] param, string a)
        {
            double toplam = 0;

            foreach (var item in param)
            {

                toplam += item;

            }
            Console.WriteLine("****************************");
            Console.WriteLine(a + " sayıların ortalaması :" + (toplam / 3));
            return toplam / 3;
        }
        static void toplamlari(double a, double b)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Ortalmaların toplamları :" + (a + b));
        }
    }
}
