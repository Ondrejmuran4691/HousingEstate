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
        public List<object> Citizens = new List<object>();

        public Flat(int numberofflat, int area, int numberofrooms)
        {
            NumberOfFlat = numberofflat;
            Area = area;
            NumberOfRooms = numberofrooms;
        }

        public override string ToString()
        {
            return("NumberOfFlat: " + NumberOfFlat + " Area: " + Area + " NumberOfRooms: " + NumberOfRooms);
          
        }
        public void AddHabitant(object name)
        {
            Citizens.Add(name);
            
        }
        public string GetInfoAboutAllHabitants()
        {
            string x = "";
            foreach (object c in Citizens)
            {

                x += c;
            }
            
            return x;
        }



    }
}
