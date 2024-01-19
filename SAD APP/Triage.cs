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
    public partial class Triage : Form
    {
        LoginPage loginPage;
        public Triage(LoginPage loginPage)
        {
            InitializeComponent();
            refreshListOfPatient();
            this.loginPage = loginPage;
        }

        public void refreshListOfPatient()
        {
            listOfPatient.DataSource = null;
            listOfPatient.Rows.Clear();
            listOfPatient.Columns.Clear();
            listOfPatient.DataSource = MySQLConn.listOfPatient();
            listOfPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listOfPatient.Columns["PatientID"].Visible = false;
        }

        public void Triage_Load(object sender, EventArgs e)
        {
            
            // listOfPatient.Dock = DockStyle.Fill;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listOfPatient.SelectedRows.Count > 0)
            {
                DataGridViewRow row = listOfPatient.SelectedRows[0];
                bool rowHasEmptyCell = false;

                // Check if any cell in the row is empty
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        rowHasEmptyCell = true;
                        break;
                    }
                }

                // If any cell is empty, show a message and return
                if (rowHasEmptyCell)
                {
                    MessageBox.Show("The selected row contains an empty cell. Please select a complete row.");
                    return;
                }

                // If no cells are empty, proceed with the existing logic
                int patientID = int.Parse(row.Cells["PatientID"].Value.ToString());
                string fullName = row.Cells["Name"].Value.ToString();
                string patientAge = row.Cells["Age"].Value.ToString();
                string patientGender = row.Cells["Gender"].Value.ToString();

                new TriageAdd(this, patientID, fullName, patientAge, patientGender).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row!");
            }
        }


        private void listOfPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
