using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.X509Certificates;

namespace DSW_Semester_Project
{
    public partial class frmSingup : Form
    {
        string fullName = "";
        string email = "";
        string password = "";
        string confirmPassword = "";
        string role = "";
        UserRepository userRepository1 = new UserRepository();

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

        }
        public void ClearLogin()
        {
            txtConfirmPassword.Clear();
            txtEmail.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtFullName.Focus();
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
            role = cmbRole.SelectedIndex.ToString();
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
            User user1 = new User(fullName, email, password, role);
            userRepository1.AddUser(user1);
            File.AppendAllText("UserAccount.txt", fullName + '|' + email + '|' + password + '|' + role + space);
            ClearLogin();
            if (role == "0") 
            {
                frmCustomer_Dashboard customer_Dashboard = new frmCustomer_Dashboard();
                customer_Dashboard.Show();
                this.Hide();
            }
            if (role == "1")
            {
                frmAdmin_Dashboard frmAdmin_Dashboard = new frmAdmin_Dashboard(); 
                frmAdmin_Dashboard.Show();
                this.Hide();
            }
            


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
            if (!txtEmail.Text.Contains("."))
            {
                ValidationError.SetError(txtEmail, "Email Must Have . Operator");
                return false;
            }

            else
            {
                ValidationError.SetError(txtEmail, "");

            }
            if (File.Exists("UserAccount.txt"))
            {   foreach (string line in File.ReadAllLines("UserAccount.txt"))
                {
                    string[] parts = line.Split('|');
                    string confrim_Email = parts[1];
                    if (email == confrim_Email)
                    {
                        MessageBox.Show("Email Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                        return false;
                    }
                }

            }
            return true;
        }

        private void frmSingup_Load(object sender, EventArgs e)
        {
            txtFullName.Focus();
            
            cmbRole.SelectedIndex = 0;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}

//using System;
//using System.Windows.Forms;

//namespace DSW_Semester_Project
//{
//    public partial class frmSingup : Form
//    {
//        private UserRepository userRepository;

//        public frmSingup()
//        {
//            InitializeComponent();

//            userRepository = new UserRepository();
//        }

//        private void btnCreateAccount_Click(object sender,EventArgs e)
//        {
//            // Check the form
//            if (!UserValidation())
//            {
//                return;
//            }

//            string fullName = txtFullName.Text.Trim();
//            string email = txtEmail.Text.Trim();
//            string password = txtPassword.Text;
//            string confirmPassword = txtConfirmPassword.Text;

//            // Check that the passwords match
//            if (password != confirmPassword)
//            {
//                ValidationError.SetError(
//                    txtConfirmPassword,
//                    "Passwords must match"
//                );

//                return;
//            }

//            ValidationError.SetError(
//                txtConfirmPassword,
//                ""
//            );

//            // Check if email already exists
//            if (userRepository.EmailExists(email))
//            {
//                ValidationError.SetError(
//                    txtEmail,
//                    "Email is already registered"
//                );

//                MessageBox.Show(
//                    "An account with this email already exists."
//                );

//                return;
//            }

//            ValidationError.SetError(
//                txtEmail,
//                ""
//            );

//            // Set the role
//            string role;

//            if (cmbRole.SelectedIndex == 0)
//            {
//                role = "0";
//            }
//            else
//            {
//                role = "1";
//            }

//            // Create the User object
//            User newUser = new User(
//                fullName,
//                email,
//                password,
//                role
//            );

//            // Save the user
//            userRepository.AddUser(newUser);

//            // Make the new user the current user
//            CurrentUser.Login(newUser);

//            MessageBox.Show(
//                "Account created successfully!",
//                "Sign Up",
//                MessageBoxButtons.OK,
//                MessageBoxIcon.Information
//            );

//            // Open customer dashboard
//            if (CurrentUser.IsCustomer())
//            {
//                Customer_Dashboard dashboard =
//                    new Customer_Dashboard();

//                dashboard.Show();
//                this.Hide();
//            }

//            // Open administrator form
//            if (CurrentUser.IsAdministrator())
//            {
//                frmReportIncidents report =
//                    new frmReportIncidents();

//                report.Show();
//                this.Hide();
//            }
//        }

//        public bool UserValidation()
//        {
//            ValidationError.Clear();

//            if (string.IsNullOrWhiteSpace(txtFullName.Text))
//            {
//                ValidationError.SetError(
//                    txtFullName,
//                    "This field is required"
//                );

//                return false;
//            }

//            if (string.IsNullOrWhiteSpace(txtEmail.Text))
//            {
//                ValidationError.SetError(
//                    txtEmail,
//                    "This field is required"
//                );

//                return false;
//            }

//            if (!txtEmail.Text.Contains("@"))
//            {
//                ValidationError.SetError(
//                    txtEmail,
//                    "Email must contain @"
//                );

//                return false;
//            }

//            if (!txtEmail.Text.Contains("."))
//            {
//                ValidationError.SetError(
//                    txtEmail,
//                    "Email must contain ."
//                );

//                return false;
//            }

//            if (string.IsNullOrWhiteSpace(txtPassword.Text))
//            {
//                ValidationError.SetError(
//                    txtPassword,
//                    "This field is required"
//                );

//                return false;
//            }

//            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
//            {
//                ValidationError.SetError(
//                    txtConfirmPassword,
//                    "This field is required"
//                );

//                return false;
//            }

//            return true;
//        }

//        private void frmSingup_Load(
//            object sender,
//            EventArgs e)
//        {
//            txtFullName.Focus();

//            txtPassword.UseSystemPasswordChar = true;
//            txtConfirmPassword.UseSystemPasswordChar = true;

//            // Customer is selected by default
//            cmbRole.SelectedIndex = 0;
//        }

//        private void lblLogin_Click(
//            object sender,
//            EventArgs e)
//        {
//            frmLogin login = new frmLogin();

//            login.Show();
//            this.Hide();
//        }

//        public void ClearLogin()
//        {
//            txtFullName.Clear();
//            txtEmail.Clear();
//            txtPassword.Clear();
//            txtConfirmPassword.Clear();
//        }

//        private void lblNeedResQLinkDeployment_Click(
//            object sender,
//            EventArgs e)
//        {
//        }

//        private void lblForgotPassword_Click(
//            object sender,
//            EventArgs e)
//        {
//        }

//        private void lblHaveAccount_Click(
//            object sender,
//            EventArgs e)
//        {
//        }

//        private void btnLogin_Click(
//            object sender,
//            EventArgs e)
//        {
//        }
//    }
//}
