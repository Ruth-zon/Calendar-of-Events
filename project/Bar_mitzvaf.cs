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
    public partial class Bar_mitzvaf : Eventsf
    {

        public Bar_mitzvaf(DateTime d) : base(d, "בר מצווה")
        {
            InitializeComponent();
        }

        public Bar_mitzvaf(Bar_mitzvah b) : base(b.Date, "בר מצווה", b.Place)
        {
            InitializeComponent();
            Chatan = b.Chatan;
            ev = b;
        }

        public string Chatan
        {
            get { return textBox2.Text; }
            set
            {
                try
                { textBox2.Text = value; }
                catch
                { textBox2.Text = ""; }
            }
        }

    }
}
