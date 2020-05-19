using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Birthdayf : Eventsf
    {


        public string name { get { return textBox2.Text; } set { textBox2.Text = value; } }
        public int Age
        {
            get
            {
                try
                { return int.Parse(textBox3.Text); }
                catch
                { return 0; }
            }
            set { textBox3.Text = value.ToString(); }
        }
        public Birthdayf(DateTime d) : base(d, "יום הולדת")
        {
            InitializeComponent();
        }

        public Birthdayf(Birthday b) : base(b.Date, "יום הולדת", b.Place)
        {
            InitializeComponent();
            this.Age = b.Age;
            this.name = b.Name;
            ev = b;
        }
    }
}
