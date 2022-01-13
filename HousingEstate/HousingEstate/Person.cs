using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Person
    {
        public string SecondName { get; private set; }
        public string FirstName { get; private set; }
        public int Age { get;  private set; }
        public Person(string firstname, string secondname, int age)
        {
            Age = age;
            FirstName = firstname;
            SecondName = secondname;
        }
        public override string ToString()
        {
            
            return ("FirstName: " + FirstName + " SecondName: " + SecondName + " Age: " + Age);
        }
       

    }
}
