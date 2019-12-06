namespace COWORKING
{
    partial class Form2
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
            this.date_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numberofchairs_textbox = new System.Windows.Forms.TextBox();
            this.numberofchairs_label = new System.Windows.Forms.Label();
            this.Time_label = new System.Windows.Forms.Label();
            this.to_textbox = new System.Windows.Forms.TextBox();
            this.From_label = new System.Windows.Forms.Label();
            this.To_label = new System.Windows.Forms.Label();
            this.from_textbos = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.feathers_label = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.ADD_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.date_label.Location = new System.Drawing.Point(6, 10);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(145, 25);
            this.date_label.TabIndex = 0;
            this.date_label.Text = "Select Date :";
            this.date_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ADD_button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 428);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numberofchairs_textbox);
            this.panel3.Controls.Add(this.numberofchairs_label);
            this.panel3.Controls.Add(this.date_label);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.Time_label);
            this.panel3.Controls.Add(this.to_textbox);
            this.panel3.Controls.Add(this.From_label);
            this.panel3.Controls.Add(this.To_label);
            this.panel3.Controls.Add(this.from_textbos);
            this.panel3.Location = new System.Drawing.Point(12, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 307);
            this.panel3.TabIndex = 3;
            // 
            // numberofchairs_textbox
            // 
            this.numberofchairs_textbox.Location = new System.Drawing.Point(11, 251);
            this.numberofchairs_textbox.MinimumSize = new System.Drawing.Size(80, 10);
            this.numberofchairs_textbox.Name = "numberofchairs_textbox";
            this.numberofchairs_textbox.Size = new System.Drawing.Size(108, 20);
            this.numberofchairs_textbox.TabIndex = 9;
            // 
            // numberofchairs_label
            // 
            this.numberofchairs_label.AutoSize = true;
            this.numberofchairs_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofchairs_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.numberofchairs_label.Location = new System.Drawing.Point(7, 217);
            this.numberofchairs_label.Name = "numberofchairs_label";
            this.numberofchairs_label.Size = new System.Drawing.Size(187, 23);
            this.numberofchairs_label.TabIndex = 8;
            this.numberofchairs_label.Text = "Number of chairs :";
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Time_label.Location = new System.Drawing.Point(6, 103);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(123, 25);
            this.Time_label.TabIndex = 4;
            this.Time_label.Text = "Add Time :";
            // 
            // to_textbox
            // 
            this.to_textbox.Location = new System.Drawing.Point(45, 181);
            this.to_textbox.MinimumSize = new System.Drawing.Size(80, 10);
            this.to_textbox.Name = "to_textbox";
            this.to_textbox.Size = new System.Drawing.Size(128, 20);
            this.to_textbox.TabIndex = 7;
            // 
            // From_label
            // 
            this.From_label.AutoSize = true;
            this.From_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.From_label.Location = new System.Drawing.Point(7, 147);
            this.From_label.Name = "From_label";
            this.From_label.Size = new System.Drawing.Size(57, 19);
            this.From_label.TabIndex = 2;
            this.From_label.Text = "From :";
            // 
            // To_label
            // 
            this.To_label.AutoSize = true;
            this.To_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.To_label.Location = new System.Drawing.Point(7, 180);
            this.To_label.Name = "To_label";
            this.To_label.Size = new System.Drawing.Size(39, 19);
            this.To_label.TabIndex = 6;
            this.To_label.Text = "To :";
            // 
            // from_textbos
            // 
            this.from_textbos.Location = new System.Drawing.Point(65, 149);
            this.from_textbos.MinimumSize = new System.Drawing.Size(80, 10);
            this.from_textbos.Name = "from_textbos";
            this.from_textbos.Size = new System.Drawing.Size(108, 20);
            this.from_textbos.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.feathers_label);
            this.panel2.Controls.Add(this.checkBox6);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Location = new System.Drawing.Point(432, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 307);
            this.panel2.TabIndex = 16;
            // 
            // feathers_label
            // 
            this.feathers_label.AutoSize = true;
            this.feathers_label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feathers_label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.feathers_label.Location = new System.Drawing.Point(3, 10);
            this.feathers_label.Name = "feathers_label";
            this.feathers_label.Size = new System.Drawing.Size(197, 25);
            this.feathers_label.TabIndex = 10;
            this.feathers_label.Text = "Offered feathers :";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBox6.Location = new System.Drawing.Point(8, 240);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(78, 20);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.Text = "Bell bags";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBox1.Location = new System.Drawing.Point(8, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Air conditioning";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBox5.Location = new System.Drawing.Point(8, 202);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(62, 20);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Drinks";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBox2.Location = new System.Drawing.Point(8, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 20);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "WI-FI Service";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBox3.Location = new System.Drawing.Point(8, 167);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(103, 20);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Food delivery";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBox4.Location = new System.Drawing.Point(8, 130);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 20);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Laundy Service";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // ADD_button
            // 
            this.ADD_button.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_button.ForeColor = System.Drawing.Color.CadetBlue;
            this.ADD_button.Location = new System.Drawing.Point(260, 349);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(167, 43);
            this.ADD_button.TabIndex = 8;
            this.ADD_button.Text = "ADD";
            this.ADD_button.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(678, 423);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(694, 462);
            this.MinimumSize = new System.Drawing.Size(694, 462);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD RENT";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Label From_label;
        private System.Windows.Forms.TextBox to_textbox;
        private System.Windows.Forms.Label To_label;
        private System.Windows.Forms.TextBox from_textbos;
        private System.Windows.Forms.Label feathers_label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox numberofchairs_textbox;
        private System.Windows.Forms.Label numberofchairs_label;
    }
}