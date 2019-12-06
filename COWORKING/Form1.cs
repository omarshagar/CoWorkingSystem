using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COWORKING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        int ChangHomSli = 0;
        private void SliderButtonHome_Click_1(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            if (ChangHomSli % 2 == 0)
            {
                this.LeftUserPanel.Size = new System.Drawing.Size(100, 520);
                this.SliderButtonHome.BackgroundImage = global::COWORKING.Properties.Resources.slider_arrow_png_5___Copy;
                this.UserNameHome.Visible = false;
                this.AddRentLabel.Visible = false;
                this.EditRentLabel.Visible = false;
                this.DeleteRentLabel.Visible = false;
            }
            else
            {
                this.LeftUserPanel.Size = new System.Drawing.Size(200, 520);
                this.SliderButtonHome.BackgroundImage = global::COWORKING.Properties.Resources.slider_arrow_png_5;
                this.UserNameHome.Visible = true;
                this.AddRentLabel.Visible = true;
                this.EditRentLabel.Visible = true;
                this.DeleteRentLabel.Visible = true;
            }
            ChangHomSli++;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.HomePanel.Enabled = false;
            this.HomePanel.Visible = false;
            this.SignInPanel.Enabled = true;
            this.SignInPanel.Visible = true;
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.SignInPanel.Enabled = false;
            this.SignInPanel.Visible = false;
            this.HomePanel.Enabled = true;
            this.HomePanel.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.SignUpPanel.Enabled = false;
            this.SignUpPanel.Visible = false;
            this.HomePanel.Enabled = true;
            this.HomePanel.Visible = true;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.SignUpPanel.Enabled = true;
            this.SignUpPanel.Visible = true;
            this.HomePanel.Enabled = false ;
            this.HomePanel.Visible = false;
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
