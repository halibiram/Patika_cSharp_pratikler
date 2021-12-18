using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_paratikler
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion (Bilinçsiz dönüşüm)
            Console.WriteLine("********************implicit conversion (Bilinçsiz dönüşüm)****************");
            byte a = 5;
            sbyte b = 10;
            short c = 30;

            int d = a + b + c;
            Console.WriteLine("d:" +d);

            long h = d;
            Console.WriteLine("h:" +h);

            float i = h;
            Console.WriteLine("i:" +i);

            string e = "Halil";
            char f = 'k';
            object g= e+f + d;
            Console.WriteLine("g:" +g);



            //Explicit Conversion (Bilinçli dönüşüm)


            Console.WriteLine("*****************Explicit Conversion******************");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" +y);

            long z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" +z);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" +v);

            //*** ToString Method***

            Console.WriteLine("*** ToString Method***");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz = 12.5f.ToString();

            //System.Convert

            Console.WriteLine("***********System.Convert***********");

            string s1 = "10", s2 = "20";

            int sayi1, sayi2;

            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            Console.WriteLine("toplam: " +toplam);

            //Parse 
            Console.WriteLine("********Parse method*****");

            parsemethod();




        }
        public static void parsemethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);

            Console.WriteLine("rakam1:" +rakam1);
            Console.WriteLine("double1:" +double1);

        }
    }
}
