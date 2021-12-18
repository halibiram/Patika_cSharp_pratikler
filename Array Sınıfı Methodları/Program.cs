using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sınıfı_Methodları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SORT,Diziler üzerinden sıralama işlemi yapar."); 
            //Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar.
            //Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.
            int[] sayiDizisi = { 1, 2, 3, 4, 5, 6, };
            Array.Sort(sayiDizisi);

            EkranaYazdir(sayiDizisi);
            
            Console.WriteLine("CLEAR,Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.");
            //Örnek: Aşağıdaki örnek sayi dizisinin 2.indexinden başlayarak 2 tane elemanı temizler.
            Array.Clear(sayiDizisi, 2, 2);
            EkranaYazdir(sayiDizisi);
            
            Console.WriteLine("REVERSE,Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir");
            Array.Reverse(sayiDizisi);
            EkranaYazdir(sayiDizisi);
            
            Console.WriteLine("IndexOf,Verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.");
            Console.WriteLine("");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 7));

            Console.WriteLine("RESIZE,Dizileri yeniden boyutlandırmak için kullanılır.");
            int[] sayiDizisi1 = { 1, 3, 4, 9, 8, 7 };
            EkranaYazdir(sayiDizisi1);
            Array.Resize<int>(ref sayiDizisi1, 12);
            EkranaYazdir(sayiDizisi1);
            sayiDizisi1[6] = 10;
            EkranaYazdir(sayiDizisi1);
            Console.ReadLine(); 
        }
        public static void EkranaYazdir(int[] sayiDizisi)
        {
            Console.WriteLine("");
            foreach (var item in sayiDizisi)
            {
                Console.Write(item+" "); 
            }
            Console.WriteLine("");
        }
    }

}
