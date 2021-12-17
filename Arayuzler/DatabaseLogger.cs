using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    class DatabaseLogger : Ilogger
    {
        public void Writelog()
        {
            Console.WriteLine("Veritabanına log yazar.");
        }
    }
}
