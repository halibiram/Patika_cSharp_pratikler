using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    public class SmsLogger : Ilogger
    {
        public void Writelog()
        {
            Console.WriteLine("Sms olarak yazar.");
        }
    }
}
