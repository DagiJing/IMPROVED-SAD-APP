using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SAD_APP
{
    public partial class Manager : Form
    {
        LoginPage loginPage;
        public Manager(LoginPage loginPage)
        {
            InitializeComponent();

            int totalLabRevenue, totalAdmissionRevenue;
            var financialInfo = MySQLConn.getFinancialInfo();

            totalAdmissionRevenue = financialInfo.admissionRevenue;
            totalLabRevenue = financialInfo.labRevenue;

            this.chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            this.chart1.Series["Series1"].Points.AddXY("Admission Revenue", totalAdmissionRevenue);
            this.chart1.Series["Series1"].Points.AddXY("Laboratory Revenue", totalLabRevenue);

            //this.chart1.Series["Series1"].Points.AddXY("Category3", 25);

            this.loginPage = loginPage;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            this.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
