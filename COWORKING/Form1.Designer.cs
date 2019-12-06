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
            this.HomePanel = new System.Windows.Forms.Panel();
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
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswdLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswdTextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PhoneNumLapel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowPasswdcheckBox = new System.Windows.Forms.CheckBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HomePanel.SuspendLayout();
            this.LeftUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureHome)).BeginInit();
            this.SignInPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.SignUpButton);
            this.HomePanel.Controls.Add(this.SignInButton);
            this.HomePanel.Controls.Add(this.LeftUserPanel);
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(675, 422);
            this.HomePanel.TabIndex = 0;
            this.HomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePanel_Paint);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignUpButton.Location = new System.Drawing.Point(555, 10);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(112, 34);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignInButton.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SignInButton.Location = new System.Drawing.Point(438, 10);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(112, 34);
            this.SignInButton.TabIndex = 4;
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
            this.LeftUserPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftUserPanel.Name = "LeftUserPanel";
            this.LeftUserPanel.Size = new System.Drawing.Size(150, 422);
            this.LeftUserPanel.TabIndex = 3;
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
            this.SliderButtonHome.Location = new System.Drawing.Point(135, 0);
            this.SliderButtonHome.Margin = new System.Windows.Forms.Padding(2);
            this.SliderButtonHome.Name = "SliderButtonHome";
            this.SliderButtonHome.Size = new System.Drawing.Size(15, 422);
            this.SliderButtonHome.TabIndex = 8;
            this.SliderButtonHome.UseVisualStyleBackColor = false;
            this.SliderButtonHome.Click += new System.EventHandler(this.SliderButtonHome_Click_1);
            // 
            // DeleteRentLabel
            // 
            this.DeleteRentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteRentLabel.AutoSize = true;
            this.DeleteRentLabel.Location = new System.Drawing.Point(46, 365);
            this.DeleteRentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeleteRentLabel.Name = "DeleteRentLabel";
            this.DeleteRentLabel.Size = new System.Drawing.Size(61, 13);
            this.DeleteRentLabel.TabIndex = 7;
            this.DeleteRentLabel.Text = "DeleteRent";
            // 
            // EditRentLabel
            // 
            this.EditRentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditRentLabel.AutoSize = true;
            this.EditRentLabel.Location = new System.Drawing.Point(49, 281);
            this.EditRentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditRentLabel.Name = "EditRentLabel";
            this.EditRentLabel.Size = new System.Drawing.Size(54, 13);
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
            this.EditPictureBox.Location = new System.Drawing.Point(45, 214);
            this.EditPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.EditPictureBox.Name = "EditPictureBox";
            this.EditPictureBox.Size = new System.Drawing.Size(60, 65);
            this.EditPictureBox.TabIndex = 5;
            this.EditPictureBox.TabStop = false;
            // 
            // DeletePictureBox
            // 
            this.DeletePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeletePictureBox.BackgroundImage = global::COWORKING.Properties.Resources.delete_icon;
            this.DeletePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeletePictureBox.Location = new System.Drawing.Point(45, 297);
            this.DeletePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeletePictureBox.Name = "DeletePictureBox";
            this.DeletePictureBox.Size = new System.Drawing.Size(60, 65);
            this.DeletePictureBox.TabIndex = 4;
            this.DeletePictureBox.TabStop = false;
            // 
            // AddRentLabel
            // 
            this.AddRentLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddRentLabel.AutoSize = true;
            this.AddRentLabel.Location = new System.Drawing.Point(54, 197);
            this.AddRentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddRentLabel.Name = "AddRentLabel";
            this.AddRentLabel.Size = new System.Drawing.Size(49, 13);
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
            this.AddPictureBox.Location = new System.Drawing.Point(45, 130);
            this.AddPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(60, 65);
            this.AddPictureBox.TabIndex = 2;
            this.AddPictureBox.TabStop = false;
            // 
            // UserNameHome
            // 
            this.UserNameHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserNameHome.AutoSize = true;
            this.UserNameHome.Location = new System.Drawing.Point(48, 76);
            this.UserNameHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameHome.Name = "UserNameHome";
            this.UserNameHome.Size = new System.Drawing.Size(54, 13);
            this.UserNameHome.TabIndex = 1;
            this.UserNameHome.Text = "username";
            // 
            // UserPictureHome
            // 
            this.UserPictureHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserPictureHome.BackgroundImage = global::COWORKING.Properties.Resources.User_icon_BLACK_01;
            this.UserPictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserPictureHome.Location = new System.Drawing.Point(41, 8);
            this.UserPictureHome.Margin = new System.Windows.Forms.Padding(2);
            this.UserPictureHome.Name = "UserPictureHome";
            this.UserPictureHome.Size = new System.Drawing.Size(60, 65);
            this.UserPictureHome.TabIndex = 0;
            this.UserPictureHome.TabStop = false;
            // 
            // SignInPanel
            // 
            this.SignInPanel.Controls.Add(this.panel1);
            this.SignInPanel.Controls.Add(this.ExitButton);
            this.SignInPanel.Enabled = false;
            this.SignInPanel.Location = new System.Drawing.Point(0, 0);
            this.SignInPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(675, 422);
            this.SignInPanel.TabIndex = 6;
            this.SignInPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PasswdLabel);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.PasswdTextBox);
            this.panel1.Controls.Add(this.EmailtextBox);
            this.panel1.Controls.Add(this.SignInLabel);
            this.panel1.Location = new System.Drawing.Point(182, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(300, 366);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(38, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PasswdLabel
            // 
            this.PasswdLabel.AutoSize = true;
            this.PasswdLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswdLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PasswdLabel.Location = new System.Drawing.Point(33, 195);
            this.PasswdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswdLabel.Name = "PasswdLabel";
            this.PasswdLabel.Size = new System.Drawing.Size(92, 25);
            this.PasswdLabel.TabIndex = 4;
            this.PasswdLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EmailLabel.Location = new System.Drawing.Point(33, 103);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(66, 25);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail";
            // 
            // PasswdTextBox
            // 
            this.PasswdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PasswdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswdTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswdTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PasswdTextBox.HideSelection = false;
            this.PasswdTextBox.Location = new System.Drawing.Point(38, 223);
            this.PasswdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswdTextBox.Name = "PasswdTextBox";
            this.PasswdTextBox.PasswordChar = '*';
            this.PasswdTextBox.Size = new System.Drawing.Size(226, 38);
            this.PasswdTextBox.TabIndex = 2;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EmailtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailtextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailtextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EmailtextBox.Location = new System.Drawing.Point(38, 132);
            this.EmailtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(226, 38);
            this.EmailtextBox.TabIndex = 1;
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SignInLabel.Location = new System.Drawing.Point(90, 0);
            this.SignInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(118, 45);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "Sign In";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.IndianRed;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitButton.Location = new System.Drawing.Point(522, 358);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(112, 37);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.button2);
            this.SignUpPanel.Controls.Add(this.button3);
            this.SignUpPanel.Controls.Add(this.panel2);
            this.SignUpPanel.Enabled = false;
            this.SignUpPanel.Location = new System.Drawing.Point(0, 0);
            this.SignUpPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(675, 422);
            this.SignUpPanel.TabIndex = 4;
            this.SignUpPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(555, 365);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(308, 365);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sign Up";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.PhoneNumLapel);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.ShowPasswdcheckBox);
            this.panel2.Controls.Add(this.LastNameLabel);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(16, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(646, 329);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(407, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Working?";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.Location = new System.Drawing.Point(412, 167);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 38);
            this.textBox4.TabIndex = 14;
            // 
            // PhoneNumLapel
            // 
            this.PhoneNumLapel.AutoSize = true;
            this.PhoneNumLapel.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumLapel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PhoneNumLapel.Location = new System.Drawing.Point(407, 54);
            this.PhoneNumLapel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumLapel.Name = "PhoneNumLapel";
            this.PhoneNumLapel.Size = new System.Drawing.Size(107, 25);
            this.PhoneNumLapel.TabIndex = 13;
            this.PhoneNumLapel.Text = "PhoneNum";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(412, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 38);
            this.textBox1.TabIndex = 12;
            // 
            // ShowPasswdcheckBox
            // 
            this.ShowPasswdcheckBox.AutoSize = true;
            this.ShowPasswdcheckBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ShowPasswdcheckBox.Location = new System.Drawing.Point(412, 296);
            this.ShowPasswdcheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPasswdcheckBox.Name = "ShowPasswdcheckBox";
            this.ShowPasswdcheckBox.Size = new System.Drawing.Size(101, 17);
            this.ShowPasswdcheckBox.TabIndex = 11;
            this.ShowPasswdcheckBox.Text = "Show Password";
            this.ShowPasswdcheckBox.UseVisualStyleBackColor = true;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LastNameLabel.Location = new System.Drawing.Point(14, 225);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(92, 25);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Lastname";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox3.Location = new System.Drawing.Point(19, 254);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 38);
            this.textBox3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "firstname";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Location = new System.Drawing.Point(19, 167);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 38);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(408, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox5.HideSelection = false;
            this.textBox5.Location = new System.Drawing.Point(412, 254);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(226, 38);
            this.textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox6.Location = new System.Drawing.Point(19, 82);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(226, 38);
            this.textBox6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(262, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sign Up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(678, 423);
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.SignInPanel);
            this.Controls.Add(this.HomePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(694, 462);
            this.MinimumSize = new System.Drawing.Size(694, 462);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "coworking";
            this.HomePanel.ResumeLayout(false);
            this.LeftUserPanel.ResumeLayout(false);
            this.LeftUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureHome)).EndInit();
            this.SignInPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Panel LeftUserPanel;
        private System.Windows.Forms.Button SliderButtonHome;
        private System.Windows.Forms.Label DeleteRentLabel;
        private System.Windows.Forms.Label EditRentLabel;
        private System.Windows.Forms.PictureBox EditPictureBox;
        private System.Windows.Forms.PictureBox DeletePictureBox;
        private System.Windows.Forms.Label AddRentLabel;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.Label UserNameHome;
        private System.Windows.Forms.PictureBox UserPictureHome;
        private System.Windows.Forms.Panel SignInPanel;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PasswdLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox PasswdTextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label PhoneNumLapel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ShowPasswdcheckBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

