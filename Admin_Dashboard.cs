using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSW_Semester_Project
{
    public partial class frmAdmin_Dashboard : Form
    {
        public frmAdmin_Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
        
        private void frmAdmin_Dashboard_Load(object sender, EventArgs e)
        {
            string name = CurrentUser.User.FullName;
            lblWelcomeLoggedInUser.Text = "Welcome Admin " + name;
        }
    }
}
