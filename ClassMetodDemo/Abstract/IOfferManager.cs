using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Abstract
{
    internal interface IOfferManager
    {
        public void Add(Offer offer);
        public void Remove(Offer offer);
        public void Update(Offer offer);    
    }
}
