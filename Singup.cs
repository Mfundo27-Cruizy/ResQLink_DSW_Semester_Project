using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSW_Semester_Project
{
    public partial class frmSingup : Form
    {
        string fullName = "";
        string email = "";
        string password = "";
        string confirmPassword = "";
        public frmSingup()
        {
            InitializeComponent();
        }

        private void lblNeedResQLinkDeployment_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblHaveAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!UserValidation())
            {
                return;
            }
            
                 fullName = txtFullName.Text.Trim();
                 email = txtEmail.Text.Trim();
                password = txtPassword.Text.Trim();
                 confirmPassword = txtConfirmPassword.Text.Trim();
            string space = Environment.NewLine;
            if (password != confirmPassword)
            {
                ValidationError.SetError(txtConfirmPassword, "Passwords Must Match");
                return;
            }
            else
            {
                ValidationError.SetError(txtConfirmPassword, "");

            }

            File.AppendAllText("UserAccount.txt",fullName+'|'+ email+'|'+ password+space);

        }
        public bool UserValidation()
        {
            ValidationError.Clear();
            if (string.IsNullOrEmpty(txtFullName.Text.Trim()) || string.IsNullOrWhiteSpace(txtFullName.Text.Trim()))
            {
                ValidationError.SetError(txtFullName, "This Field Is Required");
                return false;
            }
            else
            {
                ValidationError.SetError(txtFullName, "");

            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                ValidationError.SetError(txtEmail, "This Field Is Required");
                return false;
            }
            else
            {
                ValidationError.SetError(txtEmail, "");

            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()) || string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                ValidationError.SetError(txtPassword, "This Field Is Required");
                return false;
            }
            else
            {
                ValidationError.SetError(txtPassword, "");

            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text.Trim()))
            {
                ValidationError.SetError(txtConfirmPassword, "This Field Is Required");
                return false;
            }
            else
            {
                ValidationError.SetError(txtConfirmPassword, "");

            }
            if (!txtEmail.Text.Contains("@"))
            {
                ValidationError.SetError(txtEmail, "Email Must Have @ Operator");
                return false;
            }
            else
            {
                ValidationError.SetError(txtEmail, "");

            }

            return true;
        }
    }
}
