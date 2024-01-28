namespace SAD_APP
{
    partial class TriageAdd
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
            this.clinicalDia = new System.Windows.Forms.RichTextBox();
            this.history = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Symptoms = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.examination = new System.Windows.Forms.RichTextBox();
            this.patientName = new System.Windows.Forms.Label();
            this.agePatient = new System.Windows.Forms.Label();
            this.genderPatient = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.assignedDoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.assignedRoom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clinicalDia
            // 
            this.clinicalDia.Location = new System.Drawing.Point(8, 30);
            this.clinicalDia.Margin = new System.Windows.Forms.Padding(4);
            this.clinicalDia.MaxLength = 25;
            this.clinicalDia.Name = "clinicalDia";
            this.clinicalDia.Size = new System.Drawing.Size(234, 103);
            this.clinicalDia.TabIndex = 1;
            this.clinicalDia.Text = "";
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(8, 30);
            this.history.Margin = new System.Windows.Forms.Padding(4);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(326, 237);
            this.history.TabIndex = 1;
            this.history.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.history);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(342, 277);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clinicalDia);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(250, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clinical Diagnosis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Symptoms);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(60, 430);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(250, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symptoms";
            // 
            // Symptoms
            // 
            this.Symptoms.Location = new System.Drawing.Point(8, 30);
            this.Symptoms.Margin = new System.Windows.Forms.Padding(4);
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.Size = new System.Drawing.Size(234, 103);
            this.Symptoms.TabIndex = 1;
            this.Symptoms.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.examination);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(496, 430);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(250, 144);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Examination Result";
            // 
            // examination
            // 
            this.examination.Location = new System.Drawing.Point(8, 30);
            this.examination.Margin = new System.Windows.Forms.Padding(4);
            this.examination.Name = "examination";
            this.examination.Size = new System.Drawing.Size(234, 103);
            this.examination.TabIndex = 1;
            this.examination.Text = "";
            // 
            // patientName
            // 
            this.patientName.AutoSize = true;
            this.patientName.Location = new System.Drawing.Point(45, 55);
            this.patientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(132, 23);
            this.patientName.TabIndex = 3;
            this.patientName.Text = "Patient\'s Name";
            this.patientName.Click += new System.EventHandler(this.label1_Click);
            // 
            // agePatient
            // 
            this.agePatient.AutoSize = true;
            this.agePatient.Location = new System.Drawing.Point(255, 55);
            this.agePatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agePatient.Name = "agePatient";
            this.agePatient.Size = new System.Drawing.Size(43, 23);
            this.agePatient.TabIndex = 3;
            this.agePatient.Text = "Age";
            this.agePatient.Click += new System.EventHandler(this.label2_Click);
            // 
            // genderPatient
            // 
            this.genderPatient.AutoSize = true;
            this.genderPatient.Location = new System.Drawing.Point(376, 55);
            this.genderPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderPatient.Name = "genderPatient";
            this.genderPatient.Size = new System.Drawing.Size(70, 23);
            this.genderPatient.TabIndex = 3;
            this.genderPatient.Text = "Gender";
            this.genderPatient.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(71, 693);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(675, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 627);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Assigned Doctor";
            // 
            // assignedDoc
            // 
            this.assignedDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignedDoc.FormattingEnabled = true;
            this.assignedDoc.Location = new System.Drawing.Point(71, 654);
            this.assignedDoc.Margin = new System.Windows.Forms.Padding(4);
            this.assignedDoc.Name = "assignedDoc";
            this.assignedDoc.Size = new System.Drawing.Size(230, 31);
            this.assignedDoc.TabIndex = 6;
            this.assignedDoc.SelectedIndexChanged += new System.EventHandler(this.assignedDoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Detail of the Patient";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 627);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Assigned Room";
            // 
            // assignedRoom
            // 
            this.assignedRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignedRoom.FormattingEnabled = true;
            this.assignedRoom.Location = new System.Drawing.Point(495, 654);
            this.assignedRoom.Margin = new System.Windows.Forms.Padding(4);
            this.assignedRoom.Name = "assignedRoom";
            this.assignedRoom.Size = new System.Drawing.Size(230, 31);
            this.assignedRoom.TabIndex = 6;
            this.assignedRoom.SelectedIndexChanged += new System.EventHandler(this.assignedRoom_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.patientName);
            this.panel1.Controls.Add(this.agePatient);
            this.panel1.Controls.Add(this.genderPatient);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 86);
            this.panel1.TabIndex = 7;
            // 
            // TriageAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(804, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.assignedRoom);
            this.Controls.Add(this.assignedDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TriageAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TriageAdd";
            this.Load += new System.EventHandler(this.TriageAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox clinicalDia;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox Symptoms;
        private System.Windows.Forms.RichTextBox examination;
        private System.Windows.Forms.Label patientName;
        private System.Windows.Forms.Label agePatient;
        private System.Windows.Forms.Label genderPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox assignedDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox assignedRoom;
        private System.Windows.Forms.Panel panel1;
    }
}