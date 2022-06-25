using EngDemFifthDayHomework.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngDemFifthDayHomework.Entities
{
    public class Offer : IEntity
    {

        public int OfferId { get; set; }

        public string OfferName { get; set; }

    }
}
