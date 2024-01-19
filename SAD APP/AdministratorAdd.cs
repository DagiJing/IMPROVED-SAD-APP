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
    public partial class AdministratorAdd : Form
    {
        Administrator administrator;

        public AdministratorAdd(Administrator administrator)
        {
            InitializeComponent();
            this.administrator = administrator;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdministratorAdd_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            
            administrator.Show();
            this.Close();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string fullname = this.fullname.Text;
            int.TryParse(this.phonenumber.Text, out int phonenumber);
            string email = this.email.Text;  
            string specialization = this.specialization.Text;
            string username = this.username.Text;
            string role = this.role.Text;
            string newpass = this.newpass.Text;
            string conpass = this.conpass.Text;

            if(newpass == conpass)
            {
                MySQLConn.createUser(fullname,phonenumber,email,specialization,username,role,newpass);
            }
            else
            {
                MessageBox.Show("Please confirm your password correctly.");
            }

            administrator.refreshUsersList();
            administrator.Show();
            
            this.Close();
        }
    }
}
