using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HW9.PrototypeConsole
{
    //Класс юнита типа "Архангел", первая ступень апгрейда юнита "Ангел"
    public class ArchAngel<T>: Angel<T>
    {
        public ArchAngel(T id, int hp, int dmg, int attLvl, int defLvl) : base(id, hp, dmg, attLvl, defLvl)
        {
            AddAbility("Воскрешение союзников");
        }

        public override ICloneable7LevelUnit<T> CloneUnit()
        {
            var cloneBaseUnit = new Angel<T>
                (Id,HealthPoints,Damage,AttackLevel,DefenceLevel);
            var cloneUnit = new ArchAngel<T>
                (cloneBaseUnit.Id, cloneBaseUnit.HealthPoints, cloneBaseUnit.Damage, cloneBaseUnit.AttackLevel, cloneBaseUnit.DefenceLevel);
            cloneUnit.AbilitiesList = AbilitiesList;
            return cloneUnit;
        }
    }
}
