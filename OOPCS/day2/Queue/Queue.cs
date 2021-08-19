using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day2.Queue
{
    class Queue
    {
        private int[] queue = new int[3];
        private int numElements;
        public Queue()
        {
            numElements = 0;
        }

        public Queue(int n)
        {
            queue[0] = n;
            numElements = 1;
        }

        public Queue(int n1,int n2)
        {
            queue[0] = n1;
            queue[1] = n2;
            numElements = 2;
        }

        public Queue(int n1,int n2,int n3)
        {
            queue[0] = n1;
            queue[1] = n2;
            queue[2] = n3;
            numElements = 3;
        }

        public void Push(int n)
        {
            if (numElements == 3)
            {
                queue[0] = queue[1];
                queue[1] = queue[2];
                queue[2] = n;
            }
            else { queue[numElements - 1] = n; numElements++; }
            
        }

        public void Push(int n1,int n2)
        {
            if (numElements == 3)
            {
                queue[0] = queue[2];
                queue[1] = n1;
                queue[2] = n2;
            }
            else if (numElements == 2)
            {
                queue[0] = queue[1];
                queue[1] = n1;
                queue[2] = n2;
                numElements = 3;
            }
            else if (numElements == 1)
            {
                queue[1] = n1;
                queue[2] = n2;
                numElements = 3;
            }
            else
            {
                queue[0] = n1;
                queue[1] = n2;
                numElements = 2;
            }
        }

        public void Push(int n1,int n2,int n3)
        {
            queue[0] = n1;
            queue[1] = n2;
            queue[2] = n3;
            numElements = 3;
        }

        public void Show()
        {
            for(int i = 0; i < numElements; i++)
            {
                Console.Write(queue[i] + ", ");
            }
            Console.WriteLine();
        }

    }
}
