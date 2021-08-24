using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.Inheritance
{
    class Item
    {
        protected string id;

        public Item()
        {
            id = Guid.NewGuid().ToString();
        }
    }
}
