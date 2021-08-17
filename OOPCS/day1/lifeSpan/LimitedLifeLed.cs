using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day1.lifeSpan
{
    class LimitedLifeLed
    {
        private string color;
        private int maxLife, defLife = 20;
        private bool isOn;
        public LimitedLifeLed(string color,int maxLife)
        {
            this.color = color;
            this.maxLife = Math.Min(maxLife,defLife);
            isOn = false;
        }
        public void turnOn()
        {
            if (!isOn && maxLife>0 )
            {
               isOn = true;
                maxLife--;
            }
        }

        public void TurnOff()
        {
            if (isOn) isOn = false;
        }

        public string getColor()
        {
            if (isOn && maxLife >= 0)
                return color;
            else return null;
        }
    }
}
