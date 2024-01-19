using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAD_APP
{
    public partial class TriageAdd : Form
    {
        Triage triage;
        int patientID;
        string patientFullName;
        string patientAge;
        string patientGender;
        public TriageAdd(Triage triage, int patientID, string patientFullName, string patientAge, string patientGender)
        {
            InitializeComponent();
            this.triage = triage;
            this.patientID = patientID;
            this.patientFullName = patientFullName;
            this.patientAge = patientAge;
            this.patientGender = patientGender;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            triage.Show();
            this.Close();
        }

        private void TriageAdd_Load(object sender, EventArgs e)
        {
            // Initializing the basic info about the patient
            this.patientName.Text = this.patientFullName;
            this.agePatient.Text = this.patientAge;
            this.genderPatient.Text = this.patientGender;
            
            // Populating the combo box with the name of doctors
            List<string> doctorNames = MySQLConn.GetDoctorNames();

            foreach (string name in doctorNames)
            {
                assignedDoc.Items.Add(name);
            }

            // Populating the combo box with the list of Rooms
            List<string> vacantRooms = MySQLConn.GetVacantRooms();

            foreach (string room in vacantRooms)
            {
                assignedRoom.Items.Add(room);
            }
        }

        private void assignedDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void assignedRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string history = this.history.Text;
            string clinicalDia = this.clinicalDia.Text;
            string symptoms = this.Symptoms.Text;
            string assDoc = this.assignedDoc.Text;
            int assRoom = int.Parse(this.assignedRoom.Text);

            if (string.IsNullOrEmpty(history) && string.IsNullOrEmpty(clinicalDia))
            {
                MessageBox.Show("Please Enter a valid input");
            }
            else
            {
                if(MySQLConn.registerClinical(this.patientID, clinicalDia, history, symptoms, assDoc, assRoom))
                {
                    MessageBox.Show("Clinical Diagnosis has been registered!!");

                    this.triage.refreshListOfPatient();
                    this.triage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Clinical Diagnosis is not registered!!");
                }
            }
        }
    }
}
