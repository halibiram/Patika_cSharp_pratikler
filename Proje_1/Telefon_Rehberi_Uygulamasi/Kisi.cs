using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi_Uygulamasi
{
    class Kisi
    {
        private string Ad;

       

        private string Soyad;

        private int Numara;

        

        public Kisi(string ad, string soyad, int numara)
        {
            Ad = ad;
            Soyad = soyad;
            Numara = numara;
            
        }

      public string Ad1 { get => Ad; set => Ad = value; }
      public string Soyad1 { get => Soyad; set => Soyad = value; }
      public int Numara1 { get => Numara; set => Numara = value; }
      

        


        
    }
}
