using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day1.colorLamp
{
    class ColorLamp
    {
        private Led red, green, blue;
        private Led currLed;

        public ColorLamp(Led red,Led green,Led blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            currLed = null;
        }

        public void turnOff()
        {
            currLed.turnOff();
        }

        public void turnOn()
        {
            if (currLed == null) currLed = red; 
            else if (currLed == red) currLed = green; 
            else if (currLed == green) currLed = blue; 
            else currLed = red; 

            currLed.turnOn();
        }

        public string getCurrColor()
        {
            return currLed.getColor();
        }
    }
}
