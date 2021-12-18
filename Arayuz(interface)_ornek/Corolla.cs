using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuz_interface__ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninAracı()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
           return 4;
        }

        public Renk StandartRenk()
        {
            return Renk.Gri;
        }
    }
}
