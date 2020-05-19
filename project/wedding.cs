using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   public class wedding:events
    {
        public wedding(string Place, DateTime Date,string Chatan,string Cala) : base(Place, Date)
        {
            this.Cala = Cala;
            this.Chatan = Chatan;
        }

        public string Chatan{ get; set; }
        public string Cala { get; set; }
        public override string ToString()
        {
            return " חתונה ל " + Chatan + " ו " +Cala;
        }
    }
}
