using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This is the receptionist page beza g
namespace SAD_APP
{
    public partial class Receptionist : Form
    {
        LoginPage loginPage;
        public Receptionist(LoginPage loginPage)
        {
            InitializeComponent();
            this.loginPage = loginPage;
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = this.pfname.Text + " " + this.plname.Text;
            int age = (int)this.page.Value;
            string gender = null;
            string city = this.pcity.Text;
            int.TryParse(this.pphonenumber.Text, out int phonenumber);
            string email = this.pemail.Text;

            if (radioButtonMale.Checked)
            {
                gender = radioButtonMale.Text;
            } else if (radioButtonFemale.Checked)
            {
                gender = radioButtonFemale.Text;
            }

            if (fullName != null && age != 0 && gender != null)
            {
                MySQLConn.registerPatient(fullName, age, gender, city,phonenumber,email);

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox && c.Name != "textBox3")
                    {
                        ((TextBox)c).Clear();
                    }
                    else if (c is ComboBox)
                    {
                        ((ComboBox)c).SelectedIndex = -1;
                    }
                    else if (c is NumericUpDown)
                    {
                        ((NumericUpDown)c).Value = ((NumericUpDown)c).Minimum;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid values!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pgender_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_checkedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }
    }
}
