using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void SaleGame(Game game, Gamer gamer, Campaign campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " isimli oyunu "+ gamer.FirstName + " isimli oyuncu " + 
                "% " +campaign.CampaignDiscount + " kampanya oranıyla " + newPrice + " TL ye satın aldı.");
        }
    }
}
