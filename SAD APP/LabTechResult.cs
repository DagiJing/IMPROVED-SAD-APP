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
    public partial class LabTechResult : Form
    {
        LabTech labTech;
        int requestId;
        int labtechId;

        public LabTechResult(LabTech labTech, int requestId, int labtechId)
        {
            InitializeComponent();
            this.labTech = labTech;

            this.requestId = requestId;
            this.labtechId = labtechId;
        }

        private void LabTechResult_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            labTech.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string testResult = richTextBox1.Text + richTextBox2.Text;
            int pid = MySQLConn.retrievePatientId(requestId);
            if(MySQLConn.enterTestResults(pid, requestId, labtechId, testResult))
            {
                MessageBox.Show("Result Entered successfully!");
                labTech.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Result Couldn't be Entered!");
            }


        }
    }
}
