using ClassMetodDemo.Abstract;
using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Concrete
{
    public class SaleManager : ISalesManager
    {
        public void Add(Sale sale)
        {
            Console.WriteLine("sales added");
        }

        public void Remove(Sale sale)
        {
            Console.WriteLine("sales removed");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("sales updated");
        }
    }
}
