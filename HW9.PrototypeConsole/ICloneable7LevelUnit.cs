using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW9.PrototypeConsole
{
    //Базовый интерфейс, описывающий сущность самых сильных существ из игры "Герои меча и магии" 
    public interface ICloneable7LevelUnit<T>
    {
        public T Id { get; set; } 
        ICloneable7LevelUnit<T> CloneUnit();
        void PrintUnitInfo();
    }
}
