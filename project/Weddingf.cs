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
    public partial class Weddingf :Eventsf
    {
        
       

        public string Chatan { get {return textBox2.Text ;}  set{ textBox2.Text=value;}}
        public string Calah { get { return textBox3.Text; } set { textBox3.Text=value;} }
       
        public Weddingf(DateTime d):base(d,"חתונה")
        {
            InitializeComponent();
        }



        //public Weddingf(wedding w) : base(w.Date, "חתונה", w.Place)
        //{
        //    InitializeComponent();
        //    label4.Text = Chatan;
        //    label5.Text = Calah;
        //}

        public Weddingf(wedding w) : base(w.Date, "חתונה", w.Place)
        {
            InitializeComponent();
            this.Calah = w.Cala;
            this.Chatan = w.Chatan;
            ev =w;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
