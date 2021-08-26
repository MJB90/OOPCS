﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day6.ExcepPropagate
{
    class ExcPropagation
    {
        public void M1()
        {
            try
            {
                Console.WriteLine("Enter try block of M1.");
                M2();
                Console.WriteLine("Exit try block of M1.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Enter catch block of M1.");
                Console.WriteLine("Exception from: {0}", e.TargetSite);
                Console.WriteLine("Exit catch block of M1.");
            }
            finally
            {
                Console.WriteLine("Finally M1.");
            }
            Console.WriteLine("Exit M1.");
        }
        public void M2()
        {
            Console.WriteLine("Enter M2.");
            int y = 0;
            int x = 10 / y;
            Console.WriteLine("Exit M2.");
        }

    }
}
