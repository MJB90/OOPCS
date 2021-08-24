using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.Inheritance
{
    class program
    {
        static void Main()
        {
            List<ISyncable> syncables = new List<ISyncable>();

            syncables.Add(new Email("Hi", "jane@gmail.com", "Free for lunch?"));
            syncables.Add(new Contact("Mary", "90111111"));
            syncables.Add(new Contact("Harry", "90111112"));
            syncables.Add(new Event("Lunch with jane", new DateTime(2021,9,15,19,0,0)));

            string serializedSync = "";
            foreach(ISyncable item in syncables)
            {
                serializedSync += item.GetSyncString();
            }

            Console.WriteLine(serializedSync);
        }
    }
}
