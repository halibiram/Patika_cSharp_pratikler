using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
  public class Canlilar
    {
        public virtual void UyarilaraTepkiVerir()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
        public void beslenme()
        {
            Console.WriteLine("Canlılar beslenir");
        }
        public void bosaltım()
        {
            Console.WriteLine("Canlılar boşaltım yapar");
        }
        public void solunum()
        {
            Console.WriteLine("Canlılar solunum yapar");
        }
    }
}
