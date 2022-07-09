using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Entities
{
    public class Sale
    {
        public Gamer Gamer { get; set; }
        public Game Game{ get; set; }
        public Offer Offer { get; set; }
    }
}
