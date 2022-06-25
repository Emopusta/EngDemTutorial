
using EngDemFifthDayHomework.Abstract;
using EngDemFifthDayHomework.Concrete;
using EngDemFifthDayHomework.Entities;
using System;

namespace EngDemFifthDayHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() { FirstName="Emre",LastName ="Duman"};
            Gamer gamer1 = new Gamer() { FirstName = "Emopusta", LastName = "Duman" };
            
            Game game1 = new Game();
            game1.GameName = "Portal 2";
            game1.GamePrice = 18.00;
            IGamerService gamerManager = new GamerManager(new GamerCheckManager());
            ISaleService saleService = new SaleManager(new SummerOfferManager());
            gamerManager.SignUp(gamer);

            saleService.SellGame(gamer1, game1);

        }
    }
}
