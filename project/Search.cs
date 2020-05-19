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
    public partial class Search : Form
    {
        List<events> S = new List<events>();
        public Search(List<events> s)
        {
            InitializeComponent();
            S = s;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<events> t=new List<events>();
            t = S;
            
            if (checkBox3.Checked == true)
            {
                t = t.FindAll(d => d.Date >= dateTimePicker1.Value);
            }
            if (checkBox4.Checked == true)
            {
                t = t.FindAll(d => d.Date <= dateTimePicker2.Value);
            }

            if (checkBox5.Checked == true)
            {
                 t = t.FindAll(d => d.Place.Equals(textBox1.Text));
            }
            if (checkBox6.Checked == true)
            {
                t = t.FindAll(d => d.Date.Month <= dateTimePicker1.Value.Month);
            }
            if (checkBox2.Checked == true)
            {

                if (comboBox1.SelectedItem.Equals("חתונה"))
                {
                   var c = t.FindAll(r => r is wedding)
                        .Select(p=>new {סוג= "חתונה" , תאריך=p.Date,מקום=p.Place, חתן=(p as wedding).Chatan,כלה=(p as wedding).Cala });
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = c.ToList();
                }
                else if (comboBox1.SelectedItem.Equals("בר מצווה"))
                {
                    var c = t.FindAll(r => r is Bar_mitzvah)
                        .Select(p => new { סוג = "בר מצווה", תאריך = p.Date, מקום = p.Place, חתן = (p as Bar_mitzvah).Chatan});
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = c.ToList();
                }
                else
                {
                    var c = t.FindAll(r => r is Birthday)
                        .Select(p => new { סוג = "יום הולדת", תאריך = p.Date, מקום = p.Place, שם = (p as Birthday).Name,גיל=(p as Birthday).Age }); ;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = c.ToList();
                }
            }
            else
            {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = t;
            }
            
             
            
        }
    }
}
