using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif/Öz yineleme

            //3^4 = 3*3*3*3
            int sonuc = 1;
            for(int i=1; i<5;i++)
            {
                sonuc *= 3;
            }
            Console.WriteLine(sonuc);
            islemler instance = new islemler();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar
            string ifade = "Halil ibrahim Özdemir";
            bool sonuc1 = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc1)
            
            Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int []dizi = { 3, 5, 6, 4, 8, 3, 0, 5};

           dizi.SortArray();

           dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstChrecter());
                
          

            Console.ReadLine();

        }
    }
    public class islemler
    {
        public int Expo(int sayi,int us)
        {
            if (us < 2)
                return sayi;

            return Expo(sayi, us - 1) * sayi;
        }
        //Expo(3,4);
        //Expo(3,3)*3;
        //Expo(3,3)*3*3;
        //Expo(3,3)*3*3*3;
        //3*3*3*3=3^4;

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
           return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split();
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
             Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int i in param)
            {
                Console.WriteLine(i);
            }
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2==0;
        }
        public static string GetFirstChrecter(this string param)
        {
            return param.Substring(0,1);
        }
    }

}

