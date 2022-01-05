using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        public int NumberOfFlat { get; private set; }
        public int Area { get; private set; }
        public int NumberOfRooms { get; private set; }
        public List<string> Citizens = new List<string>();

        public Flat(int numberofflat, int area, int numberofrooms)
        {
            NumberOfFlat = numberofflat;
            Area = area;
            NumberOfRooms = numberofrooms;
        }

        public void ToString()
        {
            Console.WriteLine("NumberOfFlat: " + NumberOfFlat);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("NumberOfRooms: " + NumberOfRooms);
        }
        public void AddHabitant(string name)
        {
            Citizens.Add(name);
            
        }
        public string GetInfoAboutAllHabitants()
        {
            string x = "";
            foreach (string c in Citizens)
            {

                x += c;
            }
            
            return x;
        }



    }
}
