using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day2.PersonList
{
    class program
    {
        static void Main()
        {
            PersonList persons = new PersonList();

            //add users
            persons.AddUniqueNamedPerson(new PersonProp.PersonProp("Kim", "Tan", 18, 1.9f));
            persons.AddUniqueNamedPerson(new PersonProp.PersonProp("Joe", "Lee", 20, 1.6f));
            persons.AddUniqueNamedPerson(new PersonProp.PersonProp("June", "Yu", 22, 1.65f));
            persons.AddUniqueNamedPerson(new PersonProp.PersonProp("Larry", "Wu", 25, 1.8f));
            persons.AddUniqueNamedPerson(new PersonProp.PersonProp("Jerry", "Tan", 40, 1.7f));

            //duplicate
            persons.AddUniqueNamedPerson(new PersonProp.PersonProp("Jerry", "Tan", 18, 1.9f));

            //get those with certain height
            float height = 1.7f;
            int count = persons.GetCountWithHeightAtOrAbove(height);
            Console.WriteLine($"Folks at {height}m or taller = {count}\n");

            //get those with a certain last name
            string lastName = "Tan";
            Console.WriteLine($"Folks with LastName as {lastName}");
            List<PersonProp.PersonProp> theTans = persons.GetPersonByLastName(lastName);
            foreach(PersonProp.PersonProp tan in theTans)
            {
                Console.WriteLine(tan.firstName + " " + tan.lastName);
            }
            Console.WriteLine();

            //update the details of a person
            PersonProp.PersonProp modKimTan = new PersonProp.PersonProp("Kim", "Tan", 20, 1.92f);
            persons.UpdatePersonByName(modKimTan);

            //print all PersonProp objects
            Console.WriteLine("Listing all PersonProp objects: ");
            List<PersonProp.PersonProp> all = persons.GetAllPersons();
            foreach(PersonProp.PersonProp person in all)
            {
                Console.WriteLine($"{person.firstName} {person.lastName}, age {person.Age} {person.Height}m");
            }
        }
    }
}
