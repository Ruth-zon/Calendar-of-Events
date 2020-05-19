using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Birthday : events
    {
        public Birthday(string Place, DateTime Date, string Name, int Age) : base(Place, Date)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return " יום הולדת ל " + Name;
        }

    }
}
