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
    public partial class Pharmacy : Form
    {
        LoginPage loginPage;
        public Pharmacy(LoginPage loginPage)
        {
            InitializeComponent();
            this.loginPage = loginPage;
            listOfMedication.DataSource = MySQLConn.GetPrescriptionData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pharmacy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }
    }
}
