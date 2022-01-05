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
            David.ToString();
            Flat Zvolensky = new Flat(1, 255, 4);
            Zvolensky.ToString();
            Zvolensky.AddHabitant(David.FirstName + David.SecondName);
            Zvolensky.AddHabitant(Hugo.FirstName + Hugo.SecondName);
            Zvolensky.AddHabitant(Jana.FirstName + Jana.SecondName);
            Zvolensky.AddHabitant(Robert.FirstName + Robert.SecondName);
            Console.WriteLine("Citizens:");
            
            Console.WriteLine (Zvolensky.GetInfoAboutAllHabitants());
        }
    }
}
