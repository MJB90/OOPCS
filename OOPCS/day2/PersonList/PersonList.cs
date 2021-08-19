using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day2.PersonList
{
    class PersonList
    {
        private List<PersonProp.PersonProp> persons;

        public PersonList()
        {
            persons = new List<PersonProp.PersonProp>();
        }

        public bool AddUniqueNamedPerson(PersonProp.PersonProp person)
        {
            if (persons.Find(x => x.firstName == person.firstName && x.lastName == person.lastName) == null)
            {
                persons.Add(person);
                return true;
            }
            else return false;
        }

        public List<PersonProp.PersonProp> GetPersonByLastName(string lastName)
        {
            List<PersonProp.PersonProp> PersonsWithSameLastName = new List<PersonProp.PersonProp>();
            foreach(PersonProp.PersonProp person in persons)
            {
                if (person.lastName == lastName) PersonsWithSameLastName.Add(person);
            }
            return PersonsWithSameLastName;
        }

        public int GetCountWithHeightAtOrAbove(float height)
        {
            int count = 0;
            foreach (PersonProp.PersonProp person in persons)
            {
                if (person.Height >= height ) count++;
            }
            return count;
        }

        public bool UpdatePersonByName(PersonProp.PersonProp person)
        {
            PersonProp.PersonProp oldperson = persons.Find(x => x.firstName == person.firstName && x.lastName == person.lastName);
            if (oldperson != null)
            {
                oldperson.Height = person.Height;
                oldperson.Age = person.Age;
                return true;
            }
            else return false;
        }

        public List<PersonProp.PersonProp> GetAllPersons()
        {
            return persons;
        }

    }
}
