using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSW_Semester_Project
{
    public partial class frmCustomer_Dashboard : Form
    {
        public frmCustomer_Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnRreportIncidents_Click(object sender, EventArgs e)
        {
            frmReportIncidents reportIncidents = new frmReportIncidents();
            reportIncidents.Show();
            this.Hide();
        }

        private void pbxReportIncidents_Click(object sender, EventArgs e)
        {
            frmReportIncidents reportIncidents = new frmReportIncidents();
            reportIncidents.Show();
            this.Hide();
        }

        private void pbxLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            string name = CurrentUser.User.FullName;

            lblWelcomeLoggedInUser.Text = "Welcome " + name;
        }

        private void btnActiveIncidents_Click(object sender, EventArgs e)
        {
            frmActiveIncidents activeIncidents = new frmActiveIncidents();
            activeIncidents.Show();
            this.Hide();
        }
    }
}
