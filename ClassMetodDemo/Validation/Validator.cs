using ClassMetodDemo.E_Devlet;
using ClassMetodDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo.Validation
{
    public class Validator
    {
        public  static bool Validate(Gamer game)
        {
            bool result = true;
            foreach (var gamerItem in GamersInfo.some)
            {
                if(gamerItem.Name.Contains(game.Name)&& gamerItem.SurName.Contains(game.SurName) &&
                    gamerItem.TCNO.ToString().Contains(game.TCNO.ToString()))
                {
                    result = false;
                }
                else
                {
                    GamersInfo.some.Add(game);
                }
            }
            return result;
        }
    }
}
