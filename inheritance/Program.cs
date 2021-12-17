using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {   //                      Canlılar
            //                          |
            //          Bitkiler                 Hayvanlar
            //         |        |               |          |
            //     Tohumlu   Tohumsuz       Surungunler    Kuşlar
            //

            TohumsuzBitkiler tohumsuz = new TohumsuzBitkiler();
            tohumsuz.beslenme();
            tohumsuz.bosaltım();
            tohumsuz.solunum();
            tohumsuz.SporlaCogalma();
            tohumsuz.fotosentez();
            tohumsuz.UyarilaraTepkiVerir();
            Console.WriteLine("*********************");
            Ordek ordek = new Ordek();
            ordek.solunum();
            ordek.beslenme();
            ordek.bosaltım();
            ordek.suruhalinde();
            ordek.yuzer();
            ordek.UyarilaraTepkiVerir();

            Console.ReadKey();
            

        }
    }
}
