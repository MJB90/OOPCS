using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.AbstractClass
{
    class program
    {
        public static void Main()
        {
            int width = 5;
            int height = 10;
            int radius = 2;

            Shape rectangle = new Rectangle("blue", width, height);
            Console.WriteLine("Area of rectangle = " + rectangle.Area());

            Shape triangle = new Triangle("green", width, height);
            Console.WriteLine("Area of triangle = " + triangle.Area());

            Shape circle = new Circle("yellow", radius);
            Console.WriteLine("Area of circle = " + circle.Area());
        }
    }
}
