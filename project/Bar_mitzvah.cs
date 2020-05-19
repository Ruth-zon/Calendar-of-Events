using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   public class Bar_mitzvah:events
    {
        

        public Bar_mitzvah(string Place, DateTime Date, string Chatan) : base(Place, Date)
        {
          
            this.Chatan = Chatan;
        }
        public string Chatan { get; set; }
        public override string ToString()
        {
            return " בר מצווה ל " + Chatan;
        }
    }
}
