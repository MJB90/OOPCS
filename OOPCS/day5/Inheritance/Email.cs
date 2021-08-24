using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS.day5.Inheritance
{
    class Email : Item, ISyncable
    {
        private string title, from, content;
        public Email(string title,string from,string content):base()
        {
            this.title = title;
            this.from = from;
            this.content = content;
        }

        public string GetSyncString()
        {
            return "EM*" + id + "*" + title + "*" + from + "*" + content + "*";
        }
    }
}
