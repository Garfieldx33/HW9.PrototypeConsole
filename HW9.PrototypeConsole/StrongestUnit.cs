using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HW9.PrototypeConsole
{
    //Абстрактный класс самых сильных юнитов всех фраций
    public abstract class StrongestUnit<T> : ICloneable7LevelUnit<T>, ICloneable
    {
        public T Id { get; set; }
        public int HealthPoints;
        public int Damage;
        public int AttackLevel;
        public int DefenceLevel;
        public List<string> AbilitiesList;

        public StrongestUnit(T id, int hp, int dmg, int attLvl, int defLvl)
        {
            Id = id; 
            HealthPoints = hp;
            Damage = dmg;
            AttackLevel = attLvl;
            DefenceLevel = defLvl;
            AbilitiesList = new List<string> { "Большое существо" };
        }
        public virtual ICloneable7LevelUnit<T> CloneUnit()
        {
            return (ICloneable7LevelUnit<T>)MemberwiseClone();
        }

        public void PrintUnitInfo()
        {
            Console.WriteLine($"Экземпляр класса: {this.GetType().Name}");
            Console.WriteLine($"Идентификатор: {Id.ToString()}");
            Console.WriteLine($"Очки жизни: {HealthPoints}");
            Console.WriteLine($"Урон: {Damage}");
            Console.WriteLine($"Уровень защиты: {DefenceLevel}");
            Console.WriteLine($"Уровень нападения: {AttackLevel}");

            foreach (string ability in AbilitiesList)
            {
                Console.WriteLine($"особая способность : {ability}");
            }
            Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++");
        }
        public void AddAbility(string newAbility)
        {
            AbilitiesList.Add(newAbility);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
