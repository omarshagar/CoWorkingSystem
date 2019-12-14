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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ADD_button_Click(object sender, EventArgs e)
        {
            bool firstbox = false, secondbox = false, thirdbox = false ;
            bool aircon = checkBox1.Checked;
            bool wifi = checkBox2.Checked;
            bool drinks = checkBox5.Checked;
            try
            {

                SqlConnection con = new SqlConnection("Data source=DESKTOP-CP4LR7C; Initial Catalog=milestone_project; Integrated Security=true");
                con.Open();

                SqlCommand cmd = new SqlCommand("add_room", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add("@value", SqlDbType.Int, 7);
                cmd.Parameters.Add("@@Room_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@value"].Value = Convert.ToInt32(this.txt_add_price.Text);




                cmd.ExecuteNonQuery();
                int contractID = Convert.ToInt32(cmd.Parameters["@@Room_id"].Value);


                //--------------------------------------------------------
                SqlCommand cmd2 = new SqlCommand("add_feature", con);
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add("@Room_id", SqlDbType.Int);
                cmd2.Parameters["@Room_id"].Value = contractID;


                cmd2.Parameters.Add("@Num", SqlDbType.Int);
                cmd2.Parameters["@Num"].Value = Convert.ToInt32(this.numberofchairs_textbox.Text);



                if (checkBox1.Checked)
                {
                    firstbox = true;
                    cmd2.Parameters.Add("@Wifi", SqlDbType.Bit);
                    cmd2.Parameters["@Wifi"].Value = firstbox;

                }
                else if (!checkBox1.Checked)
                {
                    firstbox = false;
                    cmd2.Parameters.Add("@Wifi", SqlDbType.Bit);
                    cmd2.Parameters["@Wifi"].Value = firstbox;

                }

                if (checkBox2.Checked)
                {
                    secondbox = true;
                    cmd2.Parameters.Add("@Air_conditioning", SqlDbType.Bit);
                    cmd2.Parameters["@Air_conditioning"].Value = secondbox;

                }
                else if (!checkBox2.Checked)
                {
                    secondbox = false;
                    cmd2.Parameters.Add("@Air_conditioning", SqlDbType.Bit);
                    cmd2.Parameters["@Air_conditioning"].Value = secondbox;

                }

                if (checkBox5.Checked)
                {
                    thirdbox = true;
                    cmd2.Parameters.Add("@Coffee", SqlDbType.Bit);
                    cmd2.Parameters["@Coffee"].Value = thirdbox;

                }
                else if (!checkBox5.Checked)
                {
                    thirdbox = false;
                    cmd2.Parameters.Add("@Coffee", SqlDbType.Bit);
                    cmd2.Parameters["@Coffee"].Value = thirdbox;

                }
                cmd2.ExecuteNonQuery();

                con.Close();

                
            }
            catch(Exception ee)
            {
                MessageBox.Show("can't get letters in number of chairs");
                Console.WriteLine(ee.Message);
                return;
            }
           
           
            MessageBox.Show("rent saved correct");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
