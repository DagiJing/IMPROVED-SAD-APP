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
        DoctorAdd doctorAdd;
        public MedicalCertificate(DoctorAdd doctorAdd)
        {
            InitializeComponent();
            this.doctorAdd = doctorAdd;
        }

        private void MedicalCertificate_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctorAdd.Show();
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
    }
}
