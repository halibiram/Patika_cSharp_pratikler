using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_odev1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("potizif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " tane daha potizif sayı giriniz");
            

            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ". Pozitif sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if(sayi%2==0)

                {
                    Console.WriteLine("**************");
                    Console.WriteLine(sayi+" Çift sayıdır");
                    Console.WriteLine("**************");
                }


            }

          
                
            Console.ReadKey();
        }
    }
}
