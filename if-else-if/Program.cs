using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=8 && time<18)
            {
                Console.WriteLine("Günaydın");
            }
            
            else if(time<= 18)
            {
                Console.WriteLine("iyi günler");
            }

            else
            {
                Console.WriteLine("iyi geceler");
            }

            string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";
            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler" : "iyi geceler";

            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
