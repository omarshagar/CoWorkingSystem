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
    public partial class complain_answer : Form
    {
        public complain_answer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("you should fill all data,please!");

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=milestone_project;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("com_ans", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@answer", SqlDbType.NText, 100);
                    cmd.Parameters.Add("@id", SqlDbType.Int, 100);
                    cmd.Parameters["@answer"].Value = richTextBox1.Text;
                    cmd.Parameters["@id"].Value = textBox1.Text;
                    cmd.ExecuteReader();
                    MessageBox.Show("Successful Update");

                }
                catch
                {
                    MessageBox.Show("invalid data");

                }
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Complain_answer_Load(object sender, EventArgs e)
        {
       
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=milestone_project;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("view_c", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;
                con.Close();

            }
            catch
            {
                MessageBox.Show("invalid data");

            }
        }
    }
}
