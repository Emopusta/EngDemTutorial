using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample2
{
    class EsnafKrediManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("esnaf kredisi hesaplandi.");
        }
    }
}
