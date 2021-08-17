using System;

namespace OOPCS.day1.peronProj
{
    class Person
    {
        private string firstname, lastname;
        private int age;
        private float height;

        public Person (string firstname,string lastname,int age,float height)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.height = height;
        }

        public void sayHi()
        {
            Console.WriteLine($"Hi, I'm {firstname} {lastname}");
        }

        public void sayAge()
        {
            Console.WriteLine($"I'm {age} years old");
        }

        public void sayHeight()
        {
            Console.WriteLine($"My height is {height}m");
        }
    }
}
