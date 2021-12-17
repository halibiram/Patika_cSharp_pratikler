using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_odev_1._4
{
    class Program
    {   //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Bir cümle yazınız...");
            string cumle = Console.ReadLine();
            string harfler = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ"
                      + "qwertyuıopğüasdfghjklşizxcvbnmöç";

            string [] kelime = cumle.Split(' ');
            Console.WriteLine("Toplam Kelime sayısı: " +kelime.Length);

            for (int i = 0; i < cumle.Length; i++)
            {
                if (harfler.Contains(cumle[i]))
                {
                    sayac++;
                }

            }
            Console.WriteLine("Toplam harf sayısı: " +sayac);
            Console.ReadLine();
        }
    }
}
