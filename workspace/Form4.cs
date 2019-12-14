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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pay_Click(object sender, EventArgs e)
        {

        }

        private void Pay_Click_1(object sender, EventArgs e)
        {          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void circularButton4_Click(object sender, EventArgs e)
        {

            TimeSpan pay;
            string checkin = textBox1.Text;
            DateTime result;
            DateTime.TryParse(checkin, out result);
            string checkout = textBox2.Text;
            DateTime resultt;
            DateTime.TryParse(checkout, out resultt);
            System.Text.RegularExpressions.Regex rTime = new System.Text.RegularExpressions.Regex(@"[0-2][0-9]\:[0-6][0-9]\:[0-6][0-9]");
            if (textBox1.Text.Length > 0)
            {

                if (!rTime.IsMatch(textBox1.Text) && !rTime.IsMatch(textBox2.Text))
                {

                    MessageBox.Show("Please provide the time in hh:mm:ss format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        pay = (resultt - result);
                        float r = (Convert.ToInt32(pay.Hours.ToString()) * 20) + ((Convert.ToInt32(pay.Minutes.ToString()) * 20) / 60);
                        string myString = r.ToString();
                        MessageBox.Show(" You will pay " + myString + " $ ");
                    }

                    else
                    {
                        pay = (resultt - result);
                        float r1 = (Convert.ToInt32(pay.Hours.ToString()) * 10) + ((Convert.ToInt32(pay.Minutes.ToString()) * 10) / 60);
                        string myString = r1.ToString();
                        MessageBox.Show(" You will pay " + myString + " $ ");
                    }
                }
            }

        }
    }
}
