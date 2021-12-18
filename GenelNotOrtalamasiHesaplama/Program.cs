using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genelnotortalamasihesaplama
{
    class Program
    {

       

        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba genel ortalama hesaplama uygulamasına hoşgeldiniz..");
            Console.Write("Ders sayısını giriniz: ");
            int topders = Convert.ToInt32(Console.ReadLine());
            int[] vizenotlar = new int[topders];
            int[] finalnotlar = new int[topders];
            int[] krediler = new int[topders];
            int[] vizeyuzdeleri = new int[topders];
            int[] finalyuzdeleri = new int[topders];
            int[] vizekatki = new int[topders];
            int[] finalkatki = new int[topders];
            
            int carp = 0, toplam = 0, gtoplam = 0, yuzdelik = 0, finalyuzde = 0, vkatki = 0, fkatki = 0, topkredi = 0;
            
            for (int i = 0; i < vizenotlar.Length; i++)
            {
                Console.Write((i + 1) + ". dersin arasınav notunu giriniz: ");
                int vize = Convert.ToInt32(Console.ReadLine());
                vizenotlar[i] = vize;

                Console.Write((i + 1) + ". dersin final notunu giriniz: ");
                int final = Convert.ToInt32(Console.ReadLine());
                finalnotlar[i] = final;

                Console.Write((i + 1) + ". dersin kredini giriniz: ");
                int kredi = Convert.ToInt32(Console.ReadLine());
                krediler[i] = kredi;

                Console.Write((i + 1) + ". dersin arasınav yüzdesini giriniz: %");
                int vizeyuzde = Convert.ToInt32(Console.ReadLine());
                vizeyuzdeleri[i] = vizeyuzde;

                finalyuzde = islemler.yuzdehesap(vizeyuzde, yuzdelik);
                Console.WriteLine((i + 1) + ". dersin final yüzdesi= %" + finalyuzde);
                finalyuzdeleri[i] = finalyuzde;
                Console.WriteLine("*************************************************************");


                topkredi = islemler.toplamaislm(topkredi, krediler[i]);

                vkatki = islemler.katki(vize, vizeyuzde, vkatki);
                vizekatki[i] = vkatki;


                fkatki = islemler.katki(final, finalyuzde, fkatki);
                finalkatki[i] = fkatki;

                toplam = islemler.toplamaislm(vkatki, fkatki);


                carp = islemler.carpislm(toplam, kredi);
                gtoplam = islemler.toplamaislm(gtoplam, carp);




            }

        kontrol:
            Console.WriteLine("Girilen değerleri kontrol etmek için 'k', ortalamayı görmek için 'o', Çıkış 'q' basın ");
            string secim = Console.ReadLine();

            if(secim == "k")
            {
                for (int i = 0; i < topders; i++)
                {

                    Console.WriteLine("***********************************************************************");
                    Console.WriteLine((i + 1) + ". dersin arasınav notu: " + vizenotlar[i] + " ,katkı yüzdesi %" + vizeyuzdeleri[i] + " ,katkısı: " + vizekatki[i]);
                    Console.WriteLine((i + 1) + ". dersin final notu: " + finalnotlar[i] + " ,katkı yüzdesi %" + finalyuzdeleri[i] + " ,katkısı: " + finalkatki[i]);
                    Console.WriteLine((i + 1) + ". dersin kredisi: " + krediler[i]);
                    
                }
            }

          else if (secim == "o") 
            {

                sonuc(topders, gtoplam, topkredi);
                
            }
            else if(secim== "q")
            {
                goto bitir;
                
                    
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama yaptınız...Tekrar deneyin");
            }
            goto kontrol;

        bitir:
            Console.WriteLine("Çıkış yapılıyor...Herhangi bir tuşa basın.");
            Console.ReadKey();
        }
       
       

        static void sonuc(int a, int b, int c)
        {
            Console.WriteLine("**********************************************************************");
            Console.WriteLine(a + " Dersin notların ve kredilerin çarpımının toplamı: " + b);
            Console.WriteLine(a + " Dersin toplam kredi sayısı: " + c);
            Console.WriteLine("**********************************************************************");
            int ort = islemler.bolmeislm(b, c);
            Console.WriteLine("Genel not ortamalaması: " + ort);
            Console.WriteLine("***********************************************************************");
            return;
           
        }
        
       
        
       



    }
}
