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
            this.chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
            this.chart1.Series["Series1"].Points.AddXY("Category1", 50);
            this.chart1.Series["Series1"].Points.AddXY("Category2", 25);
            this.chart1.Series["Series1"].Points.AddXY("Category3", 25);
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
