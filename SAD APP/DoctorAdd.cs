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
        int ID;

        public DoctorAdd(Doctor doctor, int ID)
        {
            InitializeComponent();
            this.doctor = doctor; 
            this.ID = ID;


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
            new DocterDifferential(this).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DoctorDefinitive(this).Show();
            this.Hide();
        }
    }
}
