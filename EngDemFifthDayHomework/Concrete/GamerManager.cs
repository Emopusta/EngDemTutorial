using EngDemFifthDayHomework.Abstract;
using EngDemFifthDayHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDemFifthDayHomework.Concrete
{
    internal class GamerManager : IGamerService
    {

        private IGamerCheckService _gamerCheckService;

      
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
      

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "adli oyuncu silindi.");
        }

        public void SignUp(Gamer gamer)
        {
            if (_gamerCheckService.CheckPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " adli oyuncu kaydedildi.");
            }
        }
    }
}
