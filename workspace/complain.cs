using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace workspace
{
    public partial class complain : Form
    {
        public complain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
           


                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("you should fill all data,please!");

                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=milestone_project;Integrated Security=True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("complain", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@complain", SqlDbType.NText, 100);
                        cmd.Parameters.Add("@id", SqlDbType.Int, 100);
                        cmd.Parameters.Add("@@comp_id", SqlDbType.Int, 100).Direction = ParameterDirection.Output;
                        cmd.Parameters["@complain"].Value = richTextBox1.Text;
                        cmd.Parameters["@id"].Value = Program.user.id;
                        cmd.ExecuteReader();
                        string n = cmd.Parameters["@@comp_id"].Value.ToString();
                        MessageBox.Show("Your Complaint ID is "+n);

                    }
                    catch
                    {
                        MessageBox.Show("invalid data");

                    }
            }
        }
    }
}
