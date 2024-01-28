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
    public partial class Doctor : Form
    {
        LoginPage loginPage;
        int doctorID;
        public Doctor(LoginPage loginpage,int doctorID)
        {
            InitializeComponent();
            this.loginPage = loginpage;
            refreshListOfReviewed();
            this.doctorID = doctorID;
        }

        public void refreshListOfReviewed()
        { 
            this.listOfReviewedPatient.DataSource = null;
            this.listOfReviewedPatient.Rows.Clear();
            this.listOfReviewedPatient.Columns.Clear();
            this.listOfReviewedPatient.DataSource = null;
            this.listOfReviewedPatient.DataSource = MySQLConn.listOfReviewedPatient();
            this.listOfReviewedPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.listOfReviewedPatient.Columns["PatientID"].Visible = false;
            listOfReviewedPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listOfReviewedPatient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            refreshListOfReviewed();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listOfReviewedPatient.SelectedRows.Count > 0)
            {
                DataGridViewRow row = listOfReviewedPatient.SelectedRows[0];
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
                    //TODO: Replace message with something more medical and try to see why/when this condition occurs
                    MessageBox.Show("The selected row contains an empty cell. Please select a complete row.");
                    return;
                }

                // If no cells are empty, proceed with the existing logic
                int patientID = int.Parse(row.Cells["PatientID"].Value.ToString());

                
                string fullName = row.Cells["Name"].Value.ToString();
                string patientAge = row.Cells["Age"].Value.ToString();
                string patientGender = row.Cells["Gender"].Value.ToString();

                new DoctorAdd(this, patientID, fullName, patientAge, patientGender, this.doctorID).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row!");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }

        private void listOfReviewedPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
