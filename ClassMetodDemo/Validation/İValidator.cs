using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Validation
{
    public interface IValidator
    {
        bool Validate(Gamer gamer);
    }
}
