using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("---------Gamer-------------");

            Gamer gamer = new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumber = 12345 };

            GamerManager gamerMananager = new GamerManager(new UserValidationManager());

            gamerMananager.Add(gamer);

            Console.WriteLine("----------------------");

            Console.WriteLine("---------Game-------------");

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Super Mario";
            game1.GamePrice = 1000;

            Game game2 = new Game { Id = 2, GameName = "Tetris", GamePrice = 500 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game2);

            Console.WriteLine("---------------------------");

            Console.WriteLine("---------Campaign-------------");

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "Kampanya 1";
            campaign1.CampaignDiscount = 50;

            Campaign campaign2 = new Campaign{ Id=2, CampaignName="Kampanya 2", CampaignDiscount= 20 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);

            Console.WriteLine("-----------------------------");

            Console.WriteLine("---------Game Sale-------------");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.SaleGame(game1, gamer, campaign1);

            Console.WriteLine("---------------------------");
        }
    }
}
