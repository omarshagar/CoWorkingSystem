using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workspace
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRoom adr = new AddRoom();
            this.Hide();
            this.Enabled = false;
            adr.ShowDialog();
            this.Show();
            this.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            add_staff adr = new add_staff();
            this.Hide();
            this.Enabled = false;
            adr.ShowDialog();
            this.Show();
            this.Enabled = true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
           
              
                this.Enabled = false;
               complain_answer f1 = new complain_answer();
                f1.ShowDialog();
                this.Enabled = true;
      
        }
    }
}
