using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class ApplicationManager
    {
        public void Application(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log(); 
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager>credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate(); 
            }
        }
    }
}
