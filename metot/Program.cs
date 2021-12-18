using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteçi geri_dönüş_tipi medotadı(parametreListesi/arguman)
            //{
                ////Komutlar
                //return
            //}



            int a = 3;
            int b = 5;

            Console.WriteLine(a+b);
           int sonuc= Topla(a, b);
            Console.WriteLine(sonuc);

            metotlar ornek = new metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2=ornek.AttirveTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));


            Console.ReadKey();





        }
        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }

        class metotlar
        {
            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public int AttirveTopla(ref int veri1, ref int veri2)
            {
                veri1 += 1;
                veri2 += 1;
                return veri1 + veri2;
            }
        }

    }
}
