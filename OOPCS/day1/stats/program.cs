using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day1.stats
{
    class program
    {
        static void Main()
        {
            int[] data = { 10, 5, 8, 19, -3, 2, 14 };
            Stats stats = new Stats(data);

            Console.WriteLine("Mean: " + stats.Mean());
            Console.WriteLine("Max: " + stats.Max());
            Console.WriteLine("Min: " + stats.Min());
            Console.WriteLine("Standard Deviation: " + stats.stdDeviation(true));

        }
    }
}
