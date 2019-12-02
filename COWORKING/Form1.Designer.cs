namespace COWORKING
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.LeftUserPanel = new System.Windows.Forms.Panel();
            this.SliderButtonHome = new System.Windows.Forms.Button();
            this.DeleteRentLabel = new System.Windows.Forms.Label();
            this.EditRentLabel = new System.Windows.Forms.Label();
            this.EditPictureBox = new System.Windows.Forms.PictureBox();
            this.DeletePictureBox = new System.Windows.Forms.PictureBox();
            this.AddRentLabel = new System.Windows.Forms.Label();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.UserNameHome = new System.Windows.Forms.Label();
            this.UserPictureHome = new System.Windows.Forms.PictureBox();
            this.HomeLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.LeftUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignUpButton.Location = new System.Drawing.Point(740, 12);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(150, 42);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInButton.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignInButton.Location = new System.Drawing.Point(568, 12);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(150, 42);
            this.SignInButton.TabIndex = 1;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // LeftUserPanel
            // 
            this.LeftUserPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftUserPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.LeftUserPanel.Controls.Add(this.SliderButtonHome);
            this.LeftUserPanel.Controls.Add(this.DeleteRentLabel);
            this.LeftUserPanel.Controls.Add(this.EditRentLabel);
            this.LeftUserPanel.Controls.Add(this.EditPictureBox);
            this.LeftUserPanel.Controls.Add(this.DeletePictureBox);
            this.LeftUserPanel.Controls.Add(this.AddRentLabel);
            this.LeftUserPanel.Controls.Add(this.AddPictureBox);
            this.LeftUserPanel.Controls.Add(this.UserNameHome);
            this.LeftUserPanel.Controls.Add(this.UserPictureHome);
            this.LeftUserPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftUserPanel.Name = "LeftUserPanel";
            this.LeftUserPanel.Size = new System.Drawing.Size(200, 520);
            this.LeftUserPanel.TabIndex = 2;
            // 
            // SliderButtonHome
            // 
            this.SliderButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SliderButtonHome.AutoEllipsis = true;
            this.SliderButtonHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.SliderButtonHome.BackgroundImage = global::COWORKING.Properties.Resources.slider_arrow_png_5;
            this.SliderButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SliderButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SliderButtonHome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SliderButtonHome.Location = new System.Drawing.Point(180, 0);
            this.SliderButtonHome.Name = "SliderButtonHome";
            this.SliderButtonHome.Size = new System.Drawing.Size(20, 520);
            this.SliderButtonHome.TabIndex = 8;
            this.SliderButtonHome.UseVisualStyleBackColor = false;
            this.SliderButtonHome.Click += new System.EventHandler(this.SliderButtonHome_Click);
            // 
            // DeleteRentLabel
            // 
            this.DeleteRentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteRentLabel.AutoSize = true;
            this.DeleteRentLabel.Location = new System.Drawing.Point(61, 449);
            this.DeleteRentLabel.Name = "DeleteRentLabel";
            this.DeleteRentLabel.Size = new System.Drawing.Size(79, 17);
            this.DeleteRentLabel.TabIndex = 7;
            this.DeleteRentLabel.Text = "DeleteRent";
            // 
            // EditRentLabel
            // 
            this.EditRentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditRentLabel.AutoSize = true;
            this.EditRentLabel.Location = new System.Drawing.Point(65, 346);
            this.EditRentLabel.Name = "EditRentLabel";
            this.EditRentLabel.Size = new System.Drawing.Size(70, 17);
            this.EditRentLabel.TabIndex = 6;
            this.EditRentLabel.Text = "EdintRent";
            this.EditRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditPictureBox
            // 
            this.EditPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditPictureBox.BackgroundImage = global::COWORKING.Properties.Resources.free_edit_icon_1;
            this.EditPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("EditPictureBox.InitialImage")));
            this.EditPictureBox.Location = new System.Drawing.Point(60, 263);
            this.EditPictureBox.Name = "EditPictureBox";
            this.EditPictureBox.Size = new System.Drawing.Size(80, 80);
            this.EditPictureBox.TabIndex = 5;
            this.EditPictureBox.TabStop = false;
            // 
            // DeletePictureBox
            // 
            this.DeletePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeletePictureBox.BackgroundImage = global::COWORKING.Properties.Resources.delete_icon;
            this.DeletePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeletePictureBox.Location = new System.Drawing.Point(60, 366);
            this.DeletePictureBox.Name = "DeletePictureBox";
            this.DeletePictureBox.Size = new System.Drawing.Size(80, 80);
            this.DeletePictureBox.TabIndex = 4;
            this.DeletePictureBox.TabStop = false;
            this.DeletePictureBox.Click += new System.EventHandler(this.PictureBox3_Click);
            // 
            // AddRentLabel
            // 
            this.AddRentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddRentLabel.AutoSize = true;
            this.AddRentLabel.Location = new System.Drawing.Point(72, 243);
            this.AddRentLabel.Name = "AddRentLabel";
            this.AddRentLabel.Size = new System.Drawing.Size(63, 17);
            this.AddRentLabel.TabIndex = 3;
            this.AddRentLabel.Text = "AddRent";
            this.AddRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddPictureBox.BackgroundImage = global::COWORKING.Properties.Resources.add_button_pngrepo_com;
            this.AddPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("AddPictureBox.InitialImage")));
            this.AddPictureBox.Location = new System.Drawing.Point(60, 160);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(80, 80);
            this.AddPictureBox.TabIndex = 2;
            this.AddPictureBox.TabStop = false;
            // 
            // UserNameHome
            // 
            this.UserNameHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserNameHome.AutoSize = true;
            this.UserNameHome.Location = new System.Drawing.Point(64, 93);
            this.UserNameHome.Name = "UserNameHome";
            this.UserNameHome.Size = new System.Drawing.Size(71, 17);
            this.UserNameHome.TabIndex = 1;
            this.UserNameHome.Text = "username";
            // 
            // UserPictureHome
            // 
            this.UserPictureHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserPictureHome.BackgroundImage = global::COWORKING.Properties.Resources.User_icon_BLACK_01;
            this.UserPictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserPictureHome.Location = new System.Drawing.Point(55, 10);
            this.UserPictureHome.Name = "UserPictureHome";
            this.UserPictureHome.Size = new System.Drawing.Size(80, 80);
            this.UserPictureHome.TabIndex = 0;
            this.UserPictureHome.TabStop = false;
            // 
            // HomeLayout
            // 
            this.HomeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeLayout.Location = new System.Drawing.Point(0, 0);
            this.HomeLayout.Name = "HomeLayout";
            this.HomeLayout.Size = new System.Drawing.Size(902, 513);
            this.HomeLayout.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(902, 513);
            this.Controls.Add(this.LeftUserPanel);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.HomeLayout);
            this.MaximumSize = new System.Drawing.Size(920, 560);
            this.MinimumSize = new System.Drawing.Size(920, 560);
            this.Name = "Form1";
            this.Text = "coworking";
            this.LeftUserPanel.ResumeLayout(false);
            this.LeftUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Panel LeftUserPanel;
        private System.Windows.Forms.PictureBox UserPictureHome;
        private System.Windows.Forms.Button SliderButtonHome;
        private System.Windows.Forms.Label DeleteRentLabel;
        private System.Windows.Forms.Label EditRentLabel;
        private System.Windows.Forms.PictureBox EditPictureBox;
        private System.Windows.Forms.PictureBox DeletePictureBox;
        private System.Windows.Forms.Label AddRentLabel;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.Label UserNameHome;
        private System.Windows.Forms.FlowLayoutPanel HomeLayout;
    }
}

