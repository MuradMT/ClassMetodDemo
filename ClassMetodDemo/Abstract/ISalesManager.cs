using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Abstract
{
    public interface ISalesManager
    {
        void Add(Sale sale);
        void Remove(Sale sale);
        void Update(Sale sale);
    }
}
