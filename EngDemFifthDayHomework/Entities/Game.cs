using EngDemFifthDayHomework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDemFifthDayHomework.Entities
{
    public class Game : IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public Offer OfferType { get; set; }


    }
}
