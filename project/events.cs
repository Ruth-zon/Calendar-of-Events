using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   public abstract class events
    {

        public string Place  { get; set; }
        public DateTime Date { get; set; }

        public events(string Place,DateTime Date)
        {
            this.Date = Date;
            this.Place = Place;
        }
       
    }


}
