using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//fixed some bugs here
namespace SAD_APP
{
    public partial class Administrator : Form
    {
        LoginPage loginPage;

        public Administrator(LoginPage loginpage)
        {
            InitializeComponent();
            this.loginPage = loginpage;
        }

        public void refreshUsersList()
        {
            listOfUsers.DataSource = null;
            listOfUsers.Rows.Clear();
            listOfUsers.Columns.Clear();

            listOfUsers.DataSource = MySQLConn.listOfUsers();
            listOfUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            listOfUsers.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            this.listOfUsers.DataSource = MySQLConn.listOfUsers();
            listOfUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            listOfUsers.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdministratorAdd(this).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            loginPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Account Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (listOfUsers.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = listOfUsers.SelectedRows[0];
                    string username = row.Cells["Username"].Value.ToString();

                    if (MySQLConn.deleteUser(username))
                    {
                        MessageBox.Show("Accound deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Accound could not be deleted!");
                    } 
                }
                else
                {
                    MessageBox.Show("Please select the account you want to delete");
                }
            refreshUsersList();
            }
        }

        private void listOfUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
