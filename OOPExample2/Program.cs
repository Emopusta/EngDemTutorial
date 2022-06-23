using System;
using System.Collections.Generic;

namespace OOPExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IKrediManager ihtiyacKredi = new IhtiyacKrediManager();
            IKrediManager konutKredi = new KonutKrediManager();
            IKrediManager tasitKredi = new TasitKrediManager();
            IKrediManager esnafKredi = new EsnafKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogService = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKredi, databaseLoggerService);



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKredi, konutKredi, esnafKredi};


            basvuruManager.KrediOnBilgilendirmesiYap(krediler);




        }
    }
}
