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
    public partial class LabTech : Form
    {
        LoginPage loginPage;
        public LabTech(LoginPage loginpage)
        {
            InitializeComponent();
            this.loginPage = new LoginPage();

            //this.loginPage = loginpage;

            dataGridView1.DataSource = MySQLConn.listOfRequestedTests();
        }

        private void LabTech_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LabTechResult(this).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }
    }
}
