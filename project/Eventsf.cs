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
    public delegate void del(events e);
    public partial class Eventsf : Form
    {
    
        protected events ev { get; set; }
        public event del AddEvent;
        public event del Remove;
        public Eventsf(DateTime d, string nm)
        {
            InitializeComponent();
            label3.Text = nm;
            dateTimePicker1.Value = d;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
        }

        public Eventsf(DateTime d, string nm, string place) : this(d, nm)
        {
            textBox1.Text= place;
            button2.Visible = false;
            button1.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            events eventN;
            
            if(this is Weddingf)
            {
                eventN = new wedding(textBox1.Text,dateTimePicker1.Value,(this as Weddingf).Chatan, (this as Weddingf).Calah);
                AddEvent?.Invoke(eventN);
            }
            else if (this is Bar_mitzvaf)
            {
                eventN = new Bar_mitzvah(textBox1.Text,dateTimePicker1.Value,(this as Bar_mitzvaf).Chatan);
                AddEvent?.Invoke(eventN);
            }
            else
            {
                eventN = new Birthday(textBox1.Text,dateTimePicker1.Value,(this as Birthdayf).name,(this as Birthdayf).Age);
                AddEvent?.Invoke(eventN);
            }
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Remove?.Invoke(ev);
            events eventN;

            if (this is Weddingf)
            {
                eventN = new wedding(textBox1.Text, dateTimePicker1.Value, (this as Weddingf).Chatan, (this as Weddingf).Calah);
                
                AddEvent?.Invoke(eventN);

            }
            else if (this is Bar_mitzvaf)
            {
                eventN = new Bar_mitzvah(textBox1.Text, dateTimePicker1.Value, (this as Bar_mitzvaf).Chatan);
                AddEvent?.Invoke(eventN);

            }
            else
            {
                eventN = new Birthday(textBox1.Text, dateTimePicker1.Value, (this as Birthdayf).name, (this as Birthdayf).Age);
                AddEvent?.Invoke(eventN);

            }

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove?.Invoke(ev);
            Close();
       }
    }
}
