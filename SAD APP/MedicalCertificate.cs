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
    public partial class MedicalCertificate : Form
    {
        DoctorDefinitive doctorDefinitive;
        int patientID;
        string definitiveDiagnosis;
        public MedicalCertificate(DoctorDefinitive doctorDefinitive, int patientID, string definitiveDiagnosis)
        {
            InitializeComponent();
            this.doctorDefinitive = doctorDefinitive;
            this.patientID = patientID;
            this.definitiveDiagnosis = definitiveDiagnosis;

           
            string definitive = doctorDefinitive.ToString();

            (string pname, int page, string pcontactNumber, string pgender) = MySQLConn.getPatientInfo(patientID);

            nameTB.Text = pname;
            ageTB.Text = page.ToString();
            phoneNumberTB.Text = pcontactNumber;
            genderTB.Text = pgender;
            definitiveTB.Text = definitive;
            DateTime currentdate = DateTime.Now;
            string currentDateAndTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            dateTB.Text = currentDateAndTime;

        }

        private void MedicalCertificate_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctorDefinitive.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
