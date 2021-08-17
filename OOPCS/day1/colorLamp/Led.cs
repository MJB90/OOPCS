using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day1.colorLamp
{
    class Led
    {
        private string color;
        private bool isOn;
        public Led(string color)
        {
            this.isOn = false;
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        public bool isLedOn()
        {
            return isOn;
        }

        public void turnOn()
        {
            if (!isOn) isOn = true;
            
        }

        public void turnOff()
        {
            if (isLedOn()) isOn = false;
        }
    }
}
