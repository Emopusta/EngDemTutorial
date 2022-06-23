using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample2
{
    internal class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            loggerService.Log();
            krediManager.Calculate();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (IKrediManager kredi in krediler)
            {
                kredi.Calculate(); 
            }
        }

    }
}
