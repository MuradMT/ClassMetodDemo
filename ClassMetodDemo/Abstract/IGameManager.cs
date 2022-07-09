using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Abstract
{
    public  interface IGameManager
    {
        public void Add(Game game);
        public void Remove(Game game);
        public void Update(Game game);
    }
}
