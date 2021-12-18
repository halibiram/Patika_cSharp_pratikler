using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Bitkiler:Canlilar
    {
        public void fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
        public override void UyarilaraTepkiVerir()
        {
            //base.UyarilaraTepkiVerir();
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }

    }
    public class TohumluBitkiler:Bitkiler
    {
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çogalır.");
        }
        
    }
    public class TohumsuzBitkiler:Bitkiler
    {
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çogalır.");
        }
    }
}
