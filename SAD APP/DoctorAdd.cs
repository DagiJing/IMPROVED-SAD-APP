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
    public partial class DoctorAdd : Form
    {
        Doctor doctor;
        int patientID;
        int doctorID;
        

        public DoctorAdd(Doctor doctor, int ID, string fullName, string patientAge, string patientGender, int doctorID)
        {
            InitializeComponent();
            this.doctor = doctor; 
            this.patientID = ID;
            this.doctorID = doctorID;


            
            //(string patientName, string gender, int age) = MySQLConn.RetrieveGeneralInfo(patientID);

            patientNameTB.Text = fullName;
            patientGenderTB.Text = patientGender;
            patientAgeTB.Text = patientAge.ToString();

            (string clinicalDiagnosis, string symptoms, string history) = MySQLConn.RetrieveDiagnosisAndSymptoms(patientID);
            patientHistory.Text = history;
            patientSymptoms.Text = symptoms;
            patientClinical.Text = clinicalDiagnosis;


            
         }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DoctorAdd_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            doctor.refreshListOfReviewed();
            doctor.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DocterDifferential(this, this.doctorID, patientID).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DoctorDefinitive(this, patientID, this.doctorID).Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            //might need to make MDI
            new LabTestResult(this, patientID).Show();

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
