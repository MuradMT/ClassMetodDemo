using ClassMetodDemo.Abstract;
using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Concrete
{
    public class OfferManager : IOfferManager
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("offer added");
        }

        public void Remove(Offer offer)
        {
            Console.WriteLine("offer removed");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("offer updated");
        }
    }
}
