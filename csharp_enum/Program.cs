using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazartesi);

            Console.WriteLine((int)Gunler.cumartesi);


            int sicaklik = 32;

            if (sicaklik <= (int)Havadurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak içiçn havanın biraz daha ısınmasını bekleyelim.");
            else if(sicaklik >= (int)Havadurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if(sicaklik >= (int)Havadurumu.Normal&& sicaklik<=(int)Havadurumu.Sıcak)
                Console.WriteLine("Hadi dışarıya çıkalım...");



            Console.ReadKey();


        }

        enum Gunler
        {
            pazartesi =1,

            sali,

            çarşamba,

            perşembe,

            cuma=23,

            cumartesi,

            pazar
        }

        enum Havadurumu
        {
            Soguk=5,

            Normal=20,

            Sıcak=25,

            Coksıcak=30
        }
    }
}
