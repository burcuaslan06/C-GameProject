using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName +" isimli oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun güncellendi.");
        }
    }
}
