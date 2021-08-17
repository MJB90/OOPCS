using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day1.lifeSpan
{
    class program
    {
        static void Main()
        {
            LimitedLifeLed led = new LimitedLifeLed("red", 8);
            
            for(int i = 0; i < 10; i++)
            {
                led.turnOn();
                Console.WriteLine("Color : " + led.getColor());
                led.TurnOff();
            }
        }
    }
}
