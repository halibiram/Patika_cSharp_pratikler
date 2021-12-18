using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste = new ArrayList();

            /*liste.Add("Ali");
            liste.Add(2);
            liste.Add("Kırmızı");
            liste.Add(true);
            liste.Add('C');

            //İçerisindeki verilere erişme

            Console.WriteLine(liste[2]);

            foreach(var item in liste)
                Console.WriteLine(item);

            Console.WriteLine("******************* AddReange **********");

            string[] renkler = { "kırmızı", "mavi", "Turuncu" };*/
            List<int> sayilar = new List<int>() { 1, 2, 3, 45, 77, 9, 5, 2, 55, 11 };
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            Console.WriteLine("************* Short *********************");
            liste.Sort();
            foreach (var item in liste)
                Console.WriteLine(item);
            Console.WriteLine("****************Binarysearch******************");
            Console.WriteLine(liste.BinarySearch(9));

            Console.WriteLine("************************Reserve*****************");

            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            Console.WriteLine("******************* Clear ******************");
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
