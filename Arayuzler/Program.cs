using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger filelogger = new FileLogger();
            filelogger.Writelog();

            DatabaseLogger databaselogger = new DatabaseLogger();
            databaselogger.Writelog();

            SmsLogger smslogger = new SmsLogger();
            smslogger.Writelog();

           


            LogManager logManager = new LogManager(new FileLogger());
            logManager.Writelog();

            Console.ReadKey();

        }
    }
}
