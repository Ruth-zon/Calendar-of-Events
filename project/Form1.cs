using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project
{
    public partial class Form1 : Form
    {

        const string FilePath = "..//..//Events.xml";

        XDocument doc;
        List<events> le = new List<events>();

        public int Day { get; set; }
        public Form1()
        {

            InitializeComponent();
        
            //label1.Text = DateTime.Today.
            //   FileStream fs;
            if (!File.Exists(FilePath))
            {
                // fs = File.Create(FilePath);
                doc = new XDocument
               (new XComment("קובץ זה שומר נתוני ארועים"),
                new XElement("Events"));
                doc.Save(FilePath);
                //    fs.Close();
            }
            else
                doc = XDocument.Load(FilePath);
            FromXml();

            calendar(DateTime.Today.Year, DateTime.Today.Month);
            year = DateTime.Today.Year;
            month = DateTime.Today.Month;
            dateTimePicker1.Value = DateTime.Today;

        }



        public int year { get; set; }
        public int month { get; set; }
        public void calendar(int year, int month)
        {
            int first = Convert.ToInt32(new DateTime(year, month, 01).DayOfWeek);
            int l = first;
            int t = 0;
            panel1.Controls.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
            {
                var x = le.FindAll(v => v.Date == new DateTime(year, month, i)).ToList();
                day d = new day(new DateTime(year, month, i), x);
                d.OpenForm += Open;
                d.Update += update;
                d.Left = ((i - 1) % 7 + first) % 7 * d.Width - 1;
                d.Top = t;
                if ((i + first) % 7 == 0)
                    t += d.Height;
                panel1.Controls.Add(d);


                //wf.AddEvent += addEvent;
                //wf.Show();

            }


            CultureInfo ci = new CultureInfo("he-IL");
            label1.Text = dateTimePicker1.Value.ToString("MMMM", ci);
            label1.Text += " " + year;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (month > 1)
                month--;
            else
            {
                year--;
                month = 12;

            }
            dateTimePicker1.Value = new DateTime(year, month, 01);
            calendar(year, month);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (month < 12)
                month++;
            else
            {
                year++;
                month = 1;
            }
            calendar(year, month);
            dateTimePicker1.Value = new DateTime(year, month, 01);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            year = dateTimePicker1.Value.Year;
            month = dateTimePicker1.Value.Month;
            calendar(year, month);
        }

        public void addToList(events ev)
        {
            le.Add(ev);
            if (ev.Date.Month==month&&ev.Date.Year==year)
            {
               (panel1.Controls[ev.Date.Day - 1] as day).list(ev);
            }
        }
        public void removeFromList(events ev)
        {//le.Remove(r=>r.find(o=>o.))
         // var w =le.Find(e=>e.Equals(ev));
            le.Remove(ev);
            (panel1.Controls[ev.Date.Day - 1] as day).remove(ev);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Open(string s, DateTime d)
        {
            Eventsf t;
            if (s.Equals("חתונה"))
            {
                t = new Weddingf(d);
                t.AddEvent += addToList;
                t.Show();
            }
            else if (s.Equals("בר מצוה"))
            {
                t = new Bar_mitzvaf(d);
                t.Show();
                t.AddEvent += addToList;
            }
            else
            {
                t = new Birthdayf(d);
                t.Show();
                t.AddEvent += addToList;
            }

        }
        public void update(events e)
        {
            if (e != null)
            {
                Eventsf t;
                if (e is wedding)
                {
                    t = new Weddingf(e as wedding);
                    t.AddEvent += addToList;
                    t.Remove += removeFromList;
                    t.Show();
                }
                else if (e is Bar_mitzvah)
                {
                    t = new Bar_mitzvaf(e as Bar_mitzvah);
                    t.Show();
                    t.AddEvent += addToList;
                    t.Remove += removeFromList;
                }
                else
                {
                    t = new Birthdayf(e as Birthday);
                    t.Show();
                    t.AddEvent += addToList;
                    t.Remove += removeFromList;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s = new Search(le);
            s.Show();
        }

        private void FromXml()
        {
            doc.Descendants("wedding").ToList().ForEach(
                p => { le.Add(new wedding(p.Attribute("place").Value, Convert.ToDateTime(p.Attribute("date").Value), p.Attribute("chatan").Value, p.Attribute("cala").Value)); });
            doc.Descendants("Bar_mitzvah").ToList().ForEach(
               p => { le.Add(new Bar_mitzvah(p.Attribute("place").Value, Convert.ToDateTime(p.Attribute("date").Value), p.Attribute("chatan").Value)); });
            doc.Descendants("birthday").ToList().ForEach(
                          p => { le.Add(new Birthday(p.Attribute("place").Value, Convert.ToDateTime(p.Attribute("date").Value), p.Attribute("name").Value, int.Parse(p.Attribute("age").Value))); });
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            doc = null;
            doc = new XDocument
              (new XComment("קובץ זה שומר נתוני ארועים"),
               new XElement("Events"));
            doc.Save(FilePath);


            foreach (var item in le)
            {
                if (item is wedding)
                {
                    doc.Root.Add(new XElement("wedding", new XAttribute("date", item.Date),
                                                        new XAttribute("place", item.Place),
                                                        new XAttribute("chatan", (item as wedding).Chatan),
                                                        new XAttribute("cala", (item as wedding).Chatan)));
                }
                else if (item is Bar_mitzvah)
                {
                    doc.Root.Add(new XElement("Bar_mitzvah", new XAttribute("date", item.Date),
                                                        new XAttribute("place", item.Place),
                                                        new XAttribute("chatan", (item as Bar_mitzvah).Chatan)));
                }
                else
                {
                    doc.Root.Add(new XElement("birthday", new XAttribute("date", item.Date),
                                                        new XAttribute("place", item.Place),
                                                        new XAttribute("name", (item as Birthday).Name),
                                                        new XAttribute("age", (item as Birthday).Age)));
                }
            }
            doc.Save(FilePath);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
