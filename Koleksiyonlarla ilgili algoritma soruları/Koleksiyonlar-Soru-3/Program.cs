using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {           //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
        static void Main(string[] args)
        {
            char[] sesliharf = { 'I', 'ı', 'İ', 'i', 'E', 'e', 'A', 'a', 'Ö', 'ö', 'U', 'u','O','o' };
            

            Console.Write("Bir Yazı giriniz :");
            string yazi = Console.ReadLine();
            char[] ayir = yazi.ToCharArray();
            char[] liste = new char[yazi.Length];
            int say = 0;


            for (int i = 0; i < ayir.Length; i++)
            {
                for (int j = 0; j < sesliharf.Length; j++)
                {
                    if (ayir[i] == sesliharf[j])
                    {
                        liste[say] = ayir[i];
                        say++;
                    }
                }
            }
            Console.WriteLine("Cümlenin içerisindeki sesli harfler");
            foreach (var item in liste)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}
