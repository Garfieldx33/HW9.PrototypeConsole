
// See https://aka.ms/new-console-template for more information
using HW9.PrototypeConsole;
Angel<Guid> angel = new Angel<Guid>(Guid.NewGuid(), 180, 45, 27, 27);
ArchAngel<Guid> archAngel = new ArchAngel<Guid>(Guid.NewGuid(), 220, 75, 32, 33);
Seraph<Guid> seraph = new Seraph<Guid>(Guid.NewGuid(), 240, 65, 35, 31);

Angel<Guid> angelCloneCustom = (Angel<Guid>)angel.CloneUnit();
ArchAngel<Guid> archAngelCloneCustom = (ArchAngel<Guid>)archAngel.CloneUnit();
Seraph<Guid> seraphCloneCustom = (Seraph<Guid>)seraph.CloneUnit();

Angel<Guid> angelCloneIClone = (Angel<Guid>)angel.Clone();
ArchAngel<Guid> archAngelCloneIClone = (ArchAngel<Guid>)archAngel.Clone();
Seraph<Guid> seraphCloneIClone = (Seraph<Guid>)seraph.Clone();

Console.WriteLine("=====Оригиналы==========================");
angel.PrintUnitInfo();
archAngel.PrintUnitInfo();
seraph.PrintUnitInfo();

Console.WriteLine("=====Клоны (кастом интерфейс)===========");
angelCloneCustom.PrintUnitInfo();
archAngelCloneCustom.PrintUnitInfo();
seraphCloneCustom.PrintUnitInfo();

Console.WriteLine("=====Клоны (IClone интерфейс)===========");
angelCloneIClone.PrintUnitInfo();
archAngelCloneIClone.PrintUnitInfo();
seraphCloneIClone.PrintUnitInfo();

Console.ReadKey();

