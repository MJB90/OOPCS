using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day2.PersonProp
{
    class PersonProp
    {
        private int age;
        private float height;
        public PersonProp(string firstName,string lastName,int age, float height)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.height = height;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age {
            get { return age; }
            set
            {
                if (value > 0 && value < 150) age = value;
            }
        }
        public float Height
        {
            get { return height; }
            set
            {
                if (value > 0 && value < 3.0) height = value;
            }
        }
    }
}
