using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day2.EvenNumber
{
    class EvenNumber
    {
        private int evenNumber;
        public EvenNumber()
        {

        }

        public bool SetEvenNumber(int n)
        {
            if (IsEven(n))
            {
                evenNumber = n;
                return true;
            }
            else return false;
        }

        public int GetValue()
        {
            return evenNumber;
        }

        private bool IsEven(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }
    }
}
