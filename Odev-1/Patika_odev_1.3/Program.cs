using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_odev_1._3
{
    class Program
    {   //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        static void Main(string[] args)
        {
            Console.Write("Potizif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string [] dizi = new string[n];
            Console.WriteLine(n+ "  tane kelime giriniz");

            for(int i =0; i<dizi.Length; i++)
            {
                Console.Write((i+1) +". Kelime giriniz.: ");
                dizi[i] = Console.ReadLine();

            }
            Console.WriteLine("Girilen kelimeler sondan başa doğru sıralı şekilde...");
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(dizi[i]);

            }
            Console.ReadLine();
        }
    }
}
