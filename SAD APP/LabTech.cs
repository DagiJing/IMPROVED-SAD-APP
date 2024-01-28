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
        int userID;
        public LabTech(LoginPage loginpage, int userid)
        {
            InitializeComponent();
            this.loginPage = new LoginPage();
            userID = MySQLConn.GetLabTechID(userid);

            //this.loginPage = loginpage;

            dataGridView1.DataSource = MySQLConn.listOfRequestedTests();

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void LabTech_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                int requestId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["requestid"].Value);
               // int patientId = ;

                string patientName = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string patientGender = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string doctorName = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string testName = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;

                new LabTechResult(this, requestId, userID).Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Please select a row");
            }
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
