using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person David = new Person("David", "Prekop", 22);
            Person Robert = new Person("Robert", "Prekop", 48);
            Person Jana = new Person("Jana", "Prekop", 6);
            Person Hugo = new Person("Hugo", "Prekop", 98);
            Console.WriteLine( David.ToString());
            Flat Zvolensky = new Flat(1, 255, 4);
            Console.WriteLine(Zvolensky.ToString());
            Zvolensky.AddHabitant(David);
            Zvolensky.AddHabitant(Hugo);
            Zvolensky.AddHabitant(Jana);
            Zvolensky.AddHabitant(Robert);
            Console.WriteLine("Citizens:");
            
            Console.WriteLine (Zvolensky.GetInfoAboutAllHabitants());
        }
    }
}
