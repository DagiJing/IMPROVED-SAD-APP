namespace SAD_APP
{
    partial class Receptionist
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
            this.pfname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.plname = new System.Windows.Forms.TextBox();
            this.pcity = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pphonenumber = new System.Windows.Forms.TextBox();
            this.page = new System.Windows.Forms.NumericUpDown();
            this.pgender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.page)).BeginInit();
            this.pgender.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pfname
            // 
            this.pfname.Location = new System.Drawing.Point(252, 121);
            this.pfname.Margin = new System.Windows.Forms.Padding(4);
            this.pfname.Name = "pfname";
            this.pfname.Size = new System.Drawing.Size(257, 30);
            this.pfname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "City/Region:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Age ";
            // 
            // plname
            // 
            this.plname.Location = new System.Drawing.Point(252, 167);
            this.plname.Margin = new System.Windows.Forms.Padding(4);
            this.plname.Name = "plname";
            this.plname.Size = new System.Drawing.Size(257, 30);
            this.plname.TabIndex = 0;
            // 
            // pcity
            // 
            this.pcity.FormattingEnabled = true;
            this.pcity.Items.AddRange(new object[] {
            "Addis Ketema ",
            "Akaky Kaliti ",
            "Arada ",
            "Bole ",
            "Gullele ",
            "Kirkos ",
            "Kolfe Keranio ",
            "Lideta ",
            "Nifas Silk",
            "Yeka"});
            this.pcity.Location = new System.Drawing.Point(252, 282);
            this.pcity.Margin = new System.Windows.Forms.Padding(4);
            this.pcity.Name = "pcity";
            this.pcity.Size = new System.Drawing.Size(257, 31);
            this.pcity.TabIndex = 2;
            this.pcity.SelectedIndexChanged += new System.EventHandler(this.pcity_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(685, 121);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(60, 30);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "+251";
            // 
            // pphonenumber
            // 
            this.pphonenumber.Location = new System.Drawing.Point(742, 121);
            this.pphonenumber.Margin = new System.Windows.Forms.Padding(4);
            this.pphonenumber.MaxLength = 9;
            this.pphonenumber.Name = "pphonenumber";
            this.pphonenumber.Size = new System.Drawing.Size(138, 30);
            this.pphonenumber.TabIndex = 0;
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(678, 171);
            this.page.Margin = new System.Windows.Forms.Padding(4);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(58, 30);
            this.page.TabIndex = 3;
            // 
            // pgender
            // 
            this.pgender.Controls.Add(this.radioButtonFemale);
            this.pgender.Controls.Add(this.radioButtonMale);
            this.pgender.Location = new System.Drawing.Point(558, 218);
            this.pgender.Margin = new System.Windows.Forms.Padding(4);
            this.pgender.Name = "pgender";
            this.pgender.Padding = new System.Windows.Forms.Padding(4);
            this.pgender.Size = new System.Drawing.Size(250, 98);
            this.pgender.TabIndex = 4;
            this.pgender.TabStop = false;
            this.pgender.Text = "Gender";
            this.pgender.Enter += new System.EventHandler(this.pgender_Enter);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(120, 47);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(90, 27);
            this.radioButtonFemale.TabIndex = 0;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(36, 47);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(72, 27);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(133, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Register Patient";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(792, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pemail
            // 
            this.pemail.Location = new System.Drawing.Point(252, 242);
            this.pemail.Margin = new System.Windows.Forms.Padding(4);
            this.pemail.Name = "pemail";
            this.pemail.Size = new System.Drawing.Size(257, 30);
            this.pemail.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 65);
            this.panel1.TabIndex = 7;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(943, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pgender);
            this.Controls.Add(this.page);
            this.Controls.Add(this.pcity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plname);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pphonenumber);
            this.Controls.Add(this.pfname);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Receptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.Receptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.page)).EndInit();
            this.pgender.ResumeLayout(false);
            this.pgender.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pfname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox plname;
        private System.Windows.Forms.ComboBox pcity;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox pphonenumber;
        private System.Windows.Forms.NumericUpDown page;
        private System.Windows.Forms.GroupBox pgender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}