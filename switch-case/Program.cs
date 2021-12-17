using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("ocak ayındasın");
                    break;
                case 2:
                    Console.WriteLine("şubat ayındasın");
                    break;
                case 3:
                    Console.WriteLine("mart ayındasın");
                    break;
                case 4:
                    Console.WriteLine("nisan ayındasın");
                    break;
                case 5:
                    Console.WriteLine("mayıs ayındasın");
                    break;
                case 6:
                    Console.WriteLine("haziran ayındasın");
                    break;
                case 7:
                    Console.WriteLine("temmuz ayındasın");
                    break;
                case 8:
                    Console.WriteLine("ağustos ayındasın");
                    break;
                case 9:
                    Console.WriteLine("eylül ayındasın");
                    break;
                case 10:
                    Console.WriteLine("ekim ayındasın");
                    break;
                case 11:
                    Console.WriteLine("kasım ayındasın");
                    break;
                case 12:
                    Console.WriteLine("aralık ayındasın");
                    break;

                default:
                    break;


            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış mevsimindesin");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar mevsimindesin");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesin");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesin");
                    break;

                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
