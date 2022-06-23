using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample2
{
    internal class TasitKrediManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tasit kredisi hesaplandi.");
        }
    }
}
