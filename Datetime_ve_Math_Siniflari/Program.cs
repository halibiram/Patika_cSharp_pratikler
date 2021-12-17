using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_ve_Math_Siniflari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddMinutes(15));
            Console.WriteLine(DateTime.Now.AddMonths(4));
            Console.WriteLine(DateTime.Now.AddYears(11));
            Console.WriteLine(DateTime.Now.AddMilliseconds(55));

            //Datime format
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("************* Mats Kütüphanesi ********************");
             
            //Mats Kütüphanesi

            Console.WriteLine(Math.Abs(-15)); //Mutlak değer *25
            Console.WriteLine(Math.Sin(60));
            Console.WriteLine(Math.Cos(60));
            Console.WriteLine(Math.Tan(60));

            Console.WriteLine(Math.Ceiling(22.3)); //23
            Console.WriteLine(Math.Round(22.3));   //22
            Console.WriteLine(Math.Round(22.7)); //23
            Console.WriteLine(Math.Floor(23.7));  //22


            Console.WriteLine(Math.Max(2,5));
            Console.WriteLine(Math.Min(2,6));
            

            Console.WriteLine(Math.Pow(3,4)); //3^4 ü verir *81
            Console.WriteLine(Math.Sqrt(9)); //karekök *3
            Console.WriteLine(Math.Log(3)); // 3 'ün e tabanı üzerindeki logaritmşk karşılığının verir 
            Console.WriteLine(Math.Log10(10)); //10 sayısının logaritmik 10 tabanındaki karşılığını verir
            Console.WriteLine(Math.Exp(5)); // e uzeri 5 verir


            Console.ReadLine();








        }
    }
}
