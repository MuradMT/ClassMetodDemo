using ClassMetodDemo.Abstract;
using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Concrete
{
    public class GamerManager : IGamerManager
    {
        public void Add(Gamer manager)
        {
            Console.WriteLine("Gamer Added");
        }

        public void Remove(Gamer manager)
        {
            Console.WriteLine("Gamer Deleted");
        }

        public void Update(Gamer manager)
        {
            Console.WriteLine("Gamer Updated");
        }
    }
}
