using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
   public class LogManager:Ilogger
    {
        public Ilogger _Logger;

        public LogManager(Ilogger logger)
        {
            _Logger = logger;
        }

        public void Writelog()
        {
            _Logger.Writelog();
        }
    }
}
