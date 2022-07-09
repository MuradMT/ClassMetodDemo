using ClassMetodDemo.Abstract;
using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Concrete
{
    public class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game Added");
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Game removed");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game updated");
        }
    }
}
