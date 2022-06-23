using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample2
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database.");
        }
    }

    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to File.");
        }
    }
}
