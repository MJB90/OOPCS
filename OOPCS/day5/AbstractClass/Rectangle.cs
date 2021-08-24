using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.AbstractClass
{
    class Rectangle : Shape
    {
        private int width, height;

        public Rectangle(string color,int width,int height) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
