using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuz_interface__ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus=new Focus();
            Console.WriteLine(focus.HangiMarkaninAracı().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRenk().ToString());
            Console.WriteLine("*************************");
            
            Civic civic =new Civic();
            Console.WriteLine(civic.HangiMarkaninAracı().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRenk().ToString());


            Console.ReadLine();
        }
    }
}
