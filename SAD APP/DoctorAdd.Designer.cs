namespace SAD_APP
{
    partial class DoctorAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.patientClinical = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.patientSymptoms = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.patientHistory = new System.Windows.Forms.Label();
            this.patientGenderTB = new System.Windows.Forms.Label();
            this.patientAgeTB = new System.Windows.Forms.Label();
            this.patientNameTB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.patientGenderTB);
            this.groupBox1.Controls.Add(this.patientAgeTB);
            this.groupBox1.Controls.Add(this.patientNameTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(931, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(788, 253);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 52);
            this.button5.TabIndex = 1;
            this.button5.Text = "View Lab Result";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.patientClinical);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(434, 191);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(332, 172);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clinical Diagnosis";
            // 
            // patientClinical
            // 
            this.patientClinical.AutoSize = true;
            this.patientClinical.Location = new System.Drawing.Point(29, 55);
            this.patientClinical.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientClinical.Name = "patientClinical";
            this.patientClinical.Size = new System.Drawing.Size(139, 19);
            this.patientClinical.TabIndex = 0;
            this.patientClinical.Text = "Clinical Diagnosis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.patientSymptoms);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(434, 20);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(332, 144);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symptom";
            // 
            // patientSymptoms
            // 
            this.patientSymptoms.AutoSize = true;
            this.patientSymptoms.Location = new System.Drawing.Point(21, 41);
            this.patientSymptoms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientSymptoms.Name = "patientSymptoms";
            this.patientSymptoms.Size = new System.Drawing.Size(160, 19);
            this.patientSymptoms.TabIndex = 0;
            this.patientSymptoms.Text = "Patient\'s Symptoms";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.patientHistory);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(366, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // patientHistory
            // 
            this.patientHistory.AutoSize = true;
            this.patientHistory.Location = new System.Drawing.Point(21, 41);
            this.patientHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientHistory.Name = "patientHistory";
            this.patientHistory.Size = new System.Drawing.Size(131, 19);
            this.patientHistory.TabIndex = 0;
            this.patientHistory.Text = "Patient\'s history";
            // 
            // patientGenderTB
            // 
            this.patientGenderTB.AutoSize = true;
            this.patientGenderTB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientGenderTB.Location = new System.Drawing.Point(7, 78);
            this.patientGenderTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientGenderTB.Name = "patientGenderTB";
            this.patientGenderTB.Size = new System.Drawing.Size(63, 20);
            this.patientGenderTB.TabIndex = 0;
            this.patientGenderTB.Text = "Gender";
            // 
            // patientAgeTB
            // 
            this.patientAgeTB.AutoSize = true;
            this.patientAgeTB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAgeTB.Location = new System.Drawing.Point(8, 112);
            this.patientAgeTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientAgeTB.Name = "patientAgeTB";
            this.patientAgeTB.Size = new System.Drawing.Size(39, 20);
            this.patientAgeTB.TabIndex = 0;
            this.patientAgeTB.Text = "Age";
            // 
            // patientNameTB
            // 
            this.patientNameTB.AutoSize = true;
            this.patientNameTB.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTB.Location = new System.Drawing.Point(8, 40);
            this.patientNameTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNameTB.Name = "patientNameTB";
            this.patientNameTB.Size = new System.Drawing.Size(52, 20);
            this.patientNameTB.TabIndex = 0;
            this.patientNameTB.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(108, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 110);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter Differential Diagnosis";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(312, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 110);
            this.button2.TabIndex = 1;
            this.button2.Text = "Enter Definitive Diagnosis";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(803, 481);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DoctorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(968, 552);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorAdd";
            this.Load += new System.EventHandler(this.DoctorAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label patientClinical;
        private System.Windows.Forms.Label patientGenderTB;
        private System.Windows.Forms.Label patientAgeTB;
        private System.Windows.Forms.Label patientHistory;
        private System.Windows.Forms.Label patientNameTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label patientSymptoms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}