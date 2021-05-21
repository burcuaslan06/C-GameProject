using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameSaleService
    {
        void SaleGame(Game game, Gamer gamer, Campaign campaign);
    }
}
