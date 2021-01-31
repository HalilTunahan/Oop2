using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager hcredit = new HousingCredit();
           
            ICreditManager vcredit  = new VehicleCredit();
            ILoggerService databaseLoggerService = new DateBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Application(vcredit,databaseLoggerService);
              
            List<ICreditManager> credits = new List<ICreditManager>() { vcredit,hcredit};
            //applicationManager.KrediOnBilgilendirmesiYap(credits);

           
        }
    }
}
