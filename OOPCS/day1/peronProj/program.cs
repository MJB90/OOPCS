using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day1.peronProj
{
    class program
    {
        static void Main()
        {
            Person gary = new Person("Gary", "Tan", 35, 1.7f);
            gary.sayHi();
            gary.sayAge();
            gary.sayHeight();

            Console.WriteLine();

            Person jane = new Person("Jane", "Yong", 23, 1.6f);
            jane.sayHi();
            jane.sayAge();
            jane.sayHeight();

        }
    }
}
