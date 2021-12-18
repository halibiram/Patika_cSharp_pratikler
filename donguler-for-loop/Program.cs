using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekranana girilen sayıya kadar olan tek sayıları bulan program
            Console.Write("Bir sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());


            for (int i = 0; i <= sayi; i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }

            //1-1000 arasında tek ve çift sayıları kendi aralarında toplayan program
            int tektoplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <=1000; i++)
            {
                if (i % 2 == 1)
                {
                    tektoplam += i;     //tektoplam=tektoplam+i;
                }
                else
                    ciftToplam += i;

            }
            Console.WriteLine("Tek sayıların toplamı: "+tektoplam);
            Console.WriteLine("Çift sayıların toplamı:" +ciftToplam);
           
            //break - continue
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {

                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.ReadLine();
        }
        
    }
}
