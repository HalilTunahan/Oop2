using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DateBaseLoggerService :ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanı Loglandı");
        }
    }
}
