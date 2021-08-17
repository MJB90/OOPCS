using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day1.colorLamp
{
    class program
    {
        static void Main()
        {
            Led redLed = new Led("red");
            Led greenLed = new Led("green");
            Led blueLed = new Led("blue");

            ColorLamp lamp = new ColorLamp(redLed, greenLed, blueLed);

            for(int i = 0; i < 10; i++)
            {
                lamp.turnOn();
                Console.Write("Color :" + lamp.getCurrColor());
                Console.WriteLine("\t\tRed :" + redLed.isLedOn() + "\tGreen :" + greenLed.isLedOn() + "\tBlue :" + blueLed.isLedOn());
                lamp.turnOff();
            }
        }
    }
}
