using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day6.Exceptions
{
    class Program
    {
        static void Main()
        {
            Triangle triangle, invalidTriangle;
            try
            {
                //Valid Triangle
                triangle = new Triangle(5, 4, 3);
                Console.WriteLine("The area of valid triangle is :" + triangle.Area());
                Console.WriteLine("The perimeter of valid triangle is :" + triangle.Perimeter());

                //Invalid Triangle
                invalidTriangle = new Triangle(1, 2, 3);
            }
            catch (BadTriangleException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
