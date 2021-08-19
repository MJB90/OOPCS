using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day2.EvenNumber
{
    class program
    {
        static void Main()
        {
            int[] data = { 11, 9, 8, 2, 5, 12 };

            EvenNumber num = new EvenNumber();

            for(int i = 0; i < data.Length; i++)
            {
                if (num.SetEvenNumber(data[i]))
                {
                    Console.WriteLine("Update succeeded.");
                    Console.WriteLine("Value is now " + num.GetValue() + ".");
                }
                else
                {
                    Console.WriteLine("Update failed.");
                    Console.WriteLine(data[i] + " is not Even.");
                }
                Console.WriteLine();
            }
        }
    }
}
