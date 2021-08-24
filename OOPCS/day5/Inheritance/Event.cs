using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.Inheritance
{
    class Event: Item, ISyncable
    {
        private string title;
        private DateTime date;

        public Event(string title,DateTime date):base()
        {
            this.title = title;
            this.date = date;
        }

        public string GetSyncString()
        {
            return "EV*" + id + "*" + title + "*" + date.ToString() + "*";
        }
    }
}
