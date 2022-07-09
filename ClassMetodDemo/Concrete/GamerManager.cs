using ClassMetodDemo.Abstract;
using ClassMetodDemo.Entities;
using ClassMetodDemo.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Concrete
{
    public class GamerManager : IGamerManager
    {
        private IValidator _validator;
        public GamerManager(IValidator validator)
        {
            _validator = validator;
        }

        public void Add(Gamer manager)
        {
            if (_validator.Validate(manager))
            {
                Console.WriteLine("Gamer Added");
            }
            
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
