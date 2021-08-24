using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.AbstractClass
{
    public abstract class Shape
    {
        private string color;

        public Shape(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }

        public abstract double Area();
    }
}
