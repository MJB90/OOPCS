using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day1.stats
{
    class Stats
    {
        private int[] data;

        public Stats(int [] data)
        {
            this.data = data;
        }

        public double Mean()
        {
            return (double)data.Sum() / data.Length;
        }

        public int Max()
        {
            return data.Max();
        }

        public int Min()
        {
            return data.Min();
        }

        public double stdDeviation(bool sample)
        {
            double std = 0, mean = Mean();
            
            for(int i = 0; i < data.Length; i++)
            {
                std += Math.Pow(data[i] - mean, 2);
            }
            if (sample)
            {
                std /= (data.Length - 1);
            }
            else std /= data.Length;            
            return Math.Sqrt(std);
        }
    }
}
