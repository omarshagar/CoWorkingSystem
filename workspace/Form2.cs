using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace workspace
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.MediumAquamarine;
           
            textBox5.ForeColor = Color.Azure;
            textBox6.ForeColor = Color.Azure;
            textBox7.ForeColor = Color.Azure;
            textBox8.ForeColor = Color.Azure;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            textBox3.ForeColor = Color.Azure;
            textBox5.ForeColor = Color.Azure;
            textBox6.ForeColor = Color.Azure;
            textBox7.ForeColor = Color.Azure;
            textBox8.ForeColor = Color.Azure;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.MediumAquamarine;
           
            textBox3.ForeColor = Color.Azure;
            textBox6.ForeColor = Color.Azure;
            textBox7.ForeColor = Color.Azure;
            textBox8.ForeColor = Color.Azure;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.MediumAquamarine;
           
            textBox5.ForeColor = Color.Azure;
            textBox6.ForeColor = Color.Azure;
            textBox7.ForeColor = Color.Azure;
            textBox3.ForeColor = Color.Azure;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.MediumAquamarine;
           
            textBox5.ForeColor = Color.Azure;
            textBox3.ForeColor = Color.Azure;
            textBox7.ForeColor = Color.Azure;
            textBox8.ForeColor = Color.Azure;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.MediumAquamarine;
           
            textBox5.ForeColor = Color.Azure;
            textBox6.ForeColor = Color.Azure;
            textBox3.ForeColor = Color.Azure;
            textBox8.ForeColor = Color.Azure;
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "E-mail required!");
            }
            else if (!Regex.IsMatch(textBox5.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                errorProvider1.SetError(textBox5, "please enter a valid E-mail adress ");
            }
            else
            {
                errorProvider1.SetError(textBox5, null);
            }
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                errorProvider2.SetError(textBox6, "password required!");
            }
            else if (!Regex.IsMatch(textBox6.Text, @"[A-Za-z][A-Za-z0-9]{6,30}"))
            {
                errorProvider2.SetError(textBox6, "password invalid !");
            }
            else
            {
                errorProvider2.SetError(textBox6, null);
            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                errorProvider2.SetError(textBox7, "password required!");
            }
            else if (!Regex.IsMatch(textBox7.Text, textBox6.Text))
            {
                errorProvider3.SetError(textBox7, " Don't match ");
            }
            else
            {
                errorProvider3.SetError(textBox7, null);
            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox8.Text))
            {
                errorProvider4.SetError(textBox8, "phone required!");
            }
            else if (!Regex.IsMatch(textBox8.Text, @"^01[0-2]{1}[0-9]{8}"))
            {
                errorProvider4.SetError(textBox8, "please enter a valid phone number ");
            }
            else
            {
                errorProvider4.SetError(textBox8, null);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider5.SetError(textBox3, "first name required!");
            }
            else if (!Regex.IsMatch(textBox3.Text, @"^([A-Z][a-z]+)(/s[A-Z][a-z]+)*$"))
            {
                errorProvider5.SetError(textBox3, "what's your name ? ");
            }
            else
            {
                errorProvider5.SetError(textBox3, null);
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            
                System.Diagnostics.Process.Start("https://www.facebook.com");
            }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /////
            ///

            if (textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "") 
                {
                    MessageBox.Show("you should fill all data,please!");
                }
                else
                {
                    try
                    {
                        var addr = new System.Net.Mail.MailAddress(textBox5.Text);
                        if (addr.Address == textBox5.Text)
                        {

                        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=milestone_project;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("register", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100);
                            cmd.Parameters.Add("@number", SqlDbType.Int);
                            cmd.Parameters.Add("@@id", SqlDbType.Int, 100).Direction = ParameterDirection.Output;
                            cmd.Parameters["@name"].Value = textBox3.Text;
                            cmd.Parameters["@pass"].Value = textBox6.Text; 
                            cmd.Parameters["@email"].Value = textBox5.Text; 
                            cmd.Parameters["@number"].Value = int.Parse(textBox8.Text);
                            cmd.ExecuteReader();
                            string n = cmd.Parameters["@@id"].Value.ToString();
                            MessageBox.Show(n);






                            con.Close();
                        }
                    }
                    catch(Exception ee)
                    {
                 //   MessageBox.Show(ee.Message);
                        MessageBox.Show("invalid data");
                    }
                }
            


            //////

        }
    }
}

