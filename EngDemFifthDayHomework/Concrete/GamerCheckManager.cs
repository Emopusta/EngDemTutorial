using EngDemFifthDayHomework.Abstract;
using EngDemFifthDayHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDemFifthDayHomework.Concrete
{
    internal class GamerCheckManager : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adli oyuncu bulundu.");
            return true;
        }
    }
}
