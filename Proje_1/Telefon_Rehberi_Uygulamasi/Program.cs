using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi_Uygulamasi
{

    public class Program
    {
        static void Main(string[] args)
        {

            Rehber rehber = new Rehber();

            int secim;
        basla:
            try
            {

                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("********************************************");

                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
                Console.WriteLine("(6) Çıkış Yapmak");
                secim = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı giriş yaptınız. Tekrar Deneyin.");
                goto basla;

            }

            switch (secim)
            {
                case 1:
                    rehber.KisiEkle();
                    break;
                case 2:
                    rehber.KisiSilme();
                    break;
                case 3:
                    rehber.KisiGuncelleme();
                    break;
                case 4:
                    rehber.KisileriListele();
                    break;
                case 5:
                    rehber.RehberdeAra();
                    break;
                case 6:
                    goto bitir;
                    

                    
                    


            }


            goto basla;

            bitir:
            Console.WriteLine("Çıkış yapılıyor...Devam etmek için herhangi bir tuşa basın...");
            Console.ReadKey();


            



        }

        
       


    }
}
   
       

