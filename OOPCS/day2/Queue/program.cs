using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day2.Queue
{
    class program
    {
        static void Main()
        {
            Queue queue = new Queue(1, 2);
            queue.Show();

            queue.Push(3, 4, 5);
            queue.Show();

            queue.Push(6);
            queue.Show();

            queue.Push(7, 8);
            queue.Show();

            queue.Push(9, 10, 11);
            queue.Show();

        }
    }
}
