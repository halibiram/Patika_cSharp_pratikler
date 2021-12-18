using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Hayvanlar:Canlilar
    {
        public void suruhalinde()
        {
            Console.WriteLine("Hayvanlar sürü halinde hareket eder");
        }
        public override void UyarilaraTepkiVerir()
        {
            base.UyarilaraTepkiVerir();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }

    }
    public class Kuslar : Hayvanlar
    {
        public void ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
    public class Ordek:Hayvanlar
        {
            public void yuzer()
            {
                Console.WriteLine("Ördekler yüzerler");
            }
        }
    
}
