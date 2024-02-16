using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.PrototypeConsole
{
    // Класс юнита типа "Ангел", первая итерация сильнейших существ 
    public class Angel<T> : StrongestUnit<T>
    {
        public Angel(T id, int hp, int dmg, int attLvl, int defLvl) : base(id, hp, dmg, attLvl, defLvl)
        {
            AddAbility("Летающее существо");
        }
    }
}
