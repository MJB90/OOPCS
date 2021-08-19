using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day2.PersonProp
{
    class program
    {
        static void Main()
        {
            PersonProp gary = new PersonProp("Gary", "Tan", 35, 1.7f);
            gary.lastName = "Wong";
            gary.Age = 36;
            gary.Height = -1.71f;

            Console.WriteLine("Name: " + gary.firstName + " " + gary.lastName);
            Console.WriteLine("Age: " + gary.Age);
            Console.WriteLine("Height:" + gary.Height + "m");
        }
    }
}
