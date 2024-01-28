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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
//updated some stuff
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (string role, int userid) = MySQLConn.loginPage(this.staffUsername.Text, this.staffPass.Text);
            this.staffUsername.Text = "";
            this.staffPass.Text = "";

            if (role != null)
            {
                this.Hide();
                switch (role)
                {
                    case "administrator":
                        new Administrator(this).Show();
                        break;
                    case "doctor":
                        new Doctor(this, userid).Show();
                        break;
                    case "technician":
                        new LabTech(this, userid).Show();
                        break;
                    case "manager":
                        new Manager(this).Show();
                        break;
                    case "pharmacy":
                        new Pharmacy(this).Show();
                        break;
                    case "receptionist":
                        new Receptionist(this).Show();
                        break;
                    case "triage":
                        new Triage(this).Show();
                        break;
                    default:
                        MessageBox.Show("No specified role for you");
                        this.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                this.staffPass.PasswordChar = '\0';
            }
            else
            {
                this.staffPass.PasswordChar = '*';
            }
 
        }
    }
}
