using System;
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
    public partial class LabTestResult : Form
    {
        DoctorAdd doctorAdd;
        int patientID;
        public LabTestResult(DoctorAdd doctorAdd, int patientID)
        {
            InitializeComponent();
            this.doctorAdd = doctorAdd;
            this.patientID = patientID;
            richTextBox1.ReadOnly = true;
            richTextBox1.Text = MySQLConn.retrieveTestResult(patientID);
            richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            
        }

        private void LabTestResult_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
