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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(Program.user.name==null)
            {
                MessageBox.Show("you are not logged in please log in first");
                Form1 login = new Form1();
                login.ShowDialog();
            }
            if (Program.user.name != null)
            {

                
                this.button1.Visible = false;
                this.button5.Visible = false;
                this.button1.Enabled = false;
                this.button5.Enabled = false;
                this.labeluserya3amr.Text = Program.user.name;
                this.labeluserya3amr.Visible = true;
            feedback f = new feedback();
            f.Show();

            }
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           
          Form1 f1=  new Form1();
            f1.ShowDialog();
           // MessageBox.Show("check");

           if(Program.user.name!=null)
            {
               
                if(Program.user.role.Contains("admin"))
                {
                    MessageBox.Show(Program.user.role);
                    Form5 f5 = new Form5();
                    this.Hide();
                    f5.Show();
                    this.Enabled = false;
                }
                this.button1.Visible = false;
                this.button5.Visible = false;
                this.button1.Enabled = false;
                this.button5.Enabled = false;
                this.labeluserya3amr.Text = Program.user.name;
                this.labeluserya3amr.Visible = true;

            }
            
          
     
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {   
            if (Program.user.name == null)
            {
                MessageBox.Show("you are not logged in please log in first");
                Form1 login = new Form1();
                login.ShowDialog();
            }
            else
            {
                this.Enabled = false;
                complain f1 = new complain();
                f1.ShowDialog();
                this.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Reservation R = new Reservation();
            this.Hide();
            this.Enabled = false;
            R.ShowDialog();
            this.Show();
            this.Enabled = true;
        }
    }
}
