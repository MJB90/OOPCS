using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day6.Exceptions
{
    class Triangle
    {
        private double side1, side2, side3;
         public Triangle(double side1,double side2, double side3)
        {
            if(side1+side2<=side3 || side2+side3<=side2 || side1 + side3 <= side2)
            {
                throw new BadTriangleException("Invalid sides");
            }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public double Perimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
