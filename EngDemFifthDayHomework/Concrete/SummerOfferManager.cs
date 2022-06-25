using EngDemFifthDayHomework.Abstract;
using EngDemFifthDayHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDemFifthDayHomework.Concrete
{
    public class SummerOfferManager : IOfferService
    {
        public double Offer(Game game)
        {
            return game.GamePrice * 0.5;
        }
    }
}
