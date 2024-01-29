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
    public partial class DoctorDefinitive : Form
    {
        DoctorAdd doctorAdd;
        int patientId;
        int doctorID;
        string definitive = "";



        public DoctorDefinitive(DoctorAdd doctorAdd, int patientId, int doctorID)
        {
            InitializeComponent();
            this.doctorAdd = doctorAdd;
            this.patientId = patientId;
            this.doctorID = doctorID;
            button3.Visible = false;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorDefinitive_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctorAdd.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BG ADDED START
            string medication = medicationTB.Text;
            string dosage = dosageTB.Text;
            string frequency = frequencyTB.Text;
            definitive += definitiveTB.Text;

            //A mechanism to get the doctor ID of the doctor currently entering the details
            // When creating a doctor, i made sure the UserID and the DoctorID are the same

            button3.Visible = true;


            try
            {
                if (MySQLConn.addPrescription(patientId, this.doctorID, medication, dosage, frequency) && MySQLConn.addDefinitive(patientId, definitive))
                {
                    MessageBox.Show("Definitive diagnosis entry was successful");

                    /*Here should we allow the doctor to enter another diagnosis (if that is the case) just
                     by clearning the entry fields or would that create a logic problem?
                     */

                    /*I think after the doctor enters the information, it should go back to the DoctorAdd page(it requires more logic for multiple entry )*/

                    doctorAdd.Show();
                    this.Close();
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occurred: " + err.Message);
            }
            //medical certificate

            //BG ADDED END
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new MedicalCertificate(this, patientId, definitive).Show();
        }
    }
}
