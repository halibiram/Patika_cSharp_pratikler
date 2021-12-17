using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_odev._1._2
{
    class Program
    {   //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        static void Main(string[] args)
        {   n:
            Console.Write("Birinci pozitif sayıyı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<=0)
            {
                Console.WriteLine("Hatalı giriş yaptnız.Lütfen geçerli değer girin... ");
                goto n;
            }
            m:
            Console.Write("İkinci pozitif sayıyı giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m <= 0)
            {
                Console.WriteLine("Hatalı giriş yaptnız.Lütfen geçerli değer girin... ");
                goto m;

            }
            Console.WriteLine(n + " tane daha pozitif sayı giriniz");


            for (int i = 0; i < n; i++)
            {
            nadet:
                
                Console.Write((i + 1) + ". sayıyı giriniz: ");
                int sayilar = Convert.ToInt32(Console.ReadLine());
                if(sayilar<=0)
                {
                    Console.WriteLine("Hatalı giriş yaptnız.Lütfen geçerli değer girin... ");
                    goto nadet;

                }


                if(sayilar==m || sayilar%m==0)
                {
                    Console.WriteLine("***************************************");
                    Console.WriteLine(+sayilar +" sayısı eşit yada tam bölünüyor");
                    Console.WriteLine("***************************************");

                }
                


            }
            Console.ReadKey();
        }
    }
}
