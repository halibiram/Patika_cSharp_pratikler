using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {   //while
            //1 den baslayarak konsoleden girilen sayıya(girilen sayı dahil) kadar olan sayıları toplayıp ortalamsını bulan program
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;

            }
            Console.WriteLine(toplam / sayi);

            //a'dan z'ye kadar olan tüm harfleri yazan program
            char character = 'a';

            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("");
            Console.WriteLine("*********** Foreach ***********");

            string[] arabalar = { "Bmw", "Ford", "Nissan", "Toyota", "Renault" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

            Console.ReadLine();

        }
    }
}
