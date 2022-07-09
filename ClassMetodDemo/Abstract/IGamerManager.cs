using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Abstract
{
    public interface  IGamerManager
    {
        void Add(Gamer manager);
        void Remove(Gamer manager);
        void Update(Gamer manager);
    }
}
