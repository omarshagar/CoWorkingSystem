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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-CP4LR7C; Initial Catalog=milestone_project; Integrated Security=true");
            try
            {
               
                con.Open();

                SqlCommand cmd = new SqlCommand("feedback", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = Program.user.id;

                cmd.Parameters.Add("@feedback", SqlDbType.NText, 100);
                cmd.Parameters["@feedback"].Value = this.richTextBox1.Text;

                cmd.Parameters.Add("@@feedback_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();


                int feed_id = Convert.ToInt32(cmd.Parameters["@@feedback_id"].Value);

                MessageBox.Show(feed_id.ToString());
               
            }
            catch {
                MessageBox.Show("invalid");

            }
            finally
            {
                con.Close();
            }

        }
    }
}
