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

        

        public DoctorDefinitive(DoctorAdd doctorAdd, int patientId)
        {
            InitializeComponent();
            this.doctorAdd = doctorAdd;
            this.patientId = patientId;
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
            string definitive = definitiveTB.Text;

            //A mechanism to get the doctor ID of the doctor currently entering the details
            int doctorId = 0;

            try
            {
                MySQLConn.addPrescription(patientId, doctorId, medication, dosage, frequency);
                MySQLConn.addDefinitive(patientId, definitive);

                if (/*TODO: Condition to check if entry was successful*/ true)
                {
                    MessageBox.Show("Definitive diagnosis entry was successful");

                    /*Here should we allow the doctor to enter another diagnosis (if that is the case) just
                     by clearning the entry fields or would that create a logic problem?
                     */
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occurred: " + err.Message);
            }
            

            //BG ADDED END
        }
    }
}
