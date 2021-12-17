using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();

            Console.WriteLine(focus.HangiMarkaninAracı().ToString());
            Console.WriteLine(focus.KacTekedenOlusur().ToString());
            Console.WriteLine(focus.StandartRenkNe().ToString());
            Console.WriteLine("*********************************");

            Civic civic= new Civic();
            Console.WriteLine(civic.HangiMarkaninAracı().ToString());
            Console.WriteLine(civic.KacTekedenOlusur().ToString());
            Console.WriteLine(civic.StandartRenkNe().ToString());

            Console.ReadLine(); 
        }
    }
}
