using EngDemFifthDayHomework.Abstract;
using EngDemFifthDayHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDemFifthDayHomework.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOfferService _offerService;

        public OrderManager(IOfferService offerService)
        {
            _offerService = offerService;
        }
        public void SellGame(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName + " adli oyun " + _offerService.Offer(game) + " fiyatina " + gamer.FirstName + " adli oyuncuya satilmistir.");

        }

    
    }
}
