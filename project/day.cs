using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public delegate void del2(string a, DateTime d);
    public delegate void del3(events ev);
    public partial class day : UserControl
    {
        public event del2 OpenForm;
       public event del3 Update;
        public DateTime valueLabel { get; set; }
        public day()
        {
            InitializeComponent();
            
           
        }
        public day(DateTime val, List<events> x)
        {
            InitializeComponent();
            valueLabel = val;
            string a=val.Day+" ";
            label1.Text = val.Day+" ";
           
            foreach (var item in x)
            {
                  listBox1.Items.Add(item);
            }
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contextMenuStrip1.Show();
            contextMenuStrip1.Left = MousePosition.X;
            contextMenuStrip1.Top = MousePosition.Y;
        }

        private void חתונהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm?.Invoke("חתונה", valueLabel);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ברמצווהToolStripMenuItem_Click(object sender, EventArgs e)
        {


            OpenForm?.Invoke("בר מצוה", valueLabel);

        }

        private void יוםהולדתToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenForm?.Invoke("יום הולדת",valueLabel);
        }
       
        public void list(events e)
        {
            listBox1.Items.Add(e);
        }
        public void remove(events e)
        {
            listBox1.Items.Remove(e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update?.Invoke(listBox1.SelectedItem as events);
           
        }
    }
}
