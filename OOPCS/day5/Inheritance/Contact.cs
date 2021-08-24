using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.Inheritance
{
    class Contact : Item, ISyncable
    {
        private string name, mobile;
        public Contact(string name,string mobile):base()
        {
            this.name = name;
            this.mobile = mobile;
        }

        public string GetSyncString()
        {
            return "CO*" + id + "*" + name + "*" + mobile + "*";
        }
    }
}
