using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9.PrototypeConsole
{
    //Класс юнита типа "Серафим", вторая ступень апгрейда юнита "Ангел", следует после апгрейда до юнита типа "Архангел"
    public class Seraph<T> : ArchAngel<T>, ICloneable
    {
        public Seraph(T id, int hp, int dmg, int attLvl, int defLvl) : base(id, hp, dmg, attLvl, defLvl)
        {
            AddAbility("Осушение");
            AddAbility("Колдун");
        }

        public override ICloneable7LevelUnit<T> CloneUnit()
        {
            var cloneBaseUnit = new ArchAngel<T>
    (Id, HealthPoints, Damage, AttackLevel, DefenceLevel);
            var cloneUnit = new Seraph<T>
                (cloneBaseUnit.Id, cloneBaseUnit.HealthPoints, cloneBaseUnit.Damage, cloneBaseUnit.AttackLevel, cloneBaseUnit.DefenceLevel);
            cloneUnit.AbilitiesList = AbilitiesList;
            return cloneUnit;
        }
    }
}
