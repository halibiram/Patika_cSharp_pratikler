﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  try
            {
                Console.WriteLine("bir sayı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girmiş oldugunuz sayi :"+sayi);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" +ex.Message.ToString());
               
            }*/
            // finally
            // {
            //     Console.WriteLine("işlem tamamlandı...");
            // }

            try
            {
                // int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-25555545556");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz..");
                Console.WriteLine(ex);
            

                
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);

            }

            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük değer değer girdiniz");
                Console.WriteLine(ex);

            }
            finally
            {
                Console.WriteLine("işlem başarıyla tammalandı...");
            }
            Console.ReadLine();
        }
    }
}
