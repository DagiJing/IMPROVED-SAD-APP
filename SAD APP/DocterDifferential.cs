﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_APP
{
    public partial class DocterDifferential : Form
    {
        DoctorAdd doctorAdd;
        int doctorID;
        int patientID;
        public DocterDifferential(DoctorAdd doctorAdd, int doctorID, int patientID)
        {
            InitializeComponent();
            this.doctorAdd = doctorAdd;
            this.doctorID = doctorID;
            this.patientID = patientID;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DocterDifferential_Load(object sender, EventArgs e)
        {
            this.trackBar1.Minimum = 1;
            this.trackBar1.Maximum = 5;

            this.trackBar2.Minimum = 1;
            this.trackBar2.Maximum = 5;

            this.trackBar3.Minimum = 1;
            this.trackBar3.Maximum = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctorAdd.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(string testRequested in this.checkedListTest.CheckedItems)
            {
                if (testRequested =="Stool Test")
                {
                    MySQLConn.EnterLabRequest(doctorID, 1, patientID);
                    MessageBox.Show("here");

                }
                else if(testRequested == "Radiography")
                {
                    MySQLConn.EnterLabRequest(doctorID, 2, patientID);
                }
                else
                {
                    MySQLConn.EnterLabRequest(doctorID, 3, patientID);
                }
        
            }
            doctorAdd.Show();
            this.Close();
        }
    }
}
