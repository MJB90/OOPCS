using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.AbstractClass
{
    class Circle : Shape
    {
        private int radius;

        public Circle(string color, int radius) : base(color)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
