using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day6.Exceptions
{
    class BadTriangleException:Exception
    {
        public BadTriangleException() : base()
        {

        }

        public BadTriangleException(string message) : base(message)
        {

        }
    }
}
