using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Runtime.CompilerServices;

namespace DSW_Semester_Project
{
    public partial class frmLogin : Form
    {      
        
      public  string userName = "";
       
        string password = "";

        public frmLogin()
        {
            InitializeComponent();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '*';
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
           
        }
        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            if (!UserValidation())
            {
                return;
            }

            userName = txtUsernameOrEmail.Text.Trim();
            password = txtPassword.Text.Trim();

            if (!File.Exists("UserAccount.txt"))
            {
                MessageBox.Show("No user accounts found. Please sign up first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] accounts = File.ReadAllLines("UserAccount.txt");
            bool isUserNameAuthenticated = false;
            bool isPasswordAuthenticated = false;
            string storedRole = "";
            foreach (string item in accounts)
            {
                string[] accountDetails = item.Split('|');
               string storedUserName = accountDetails[0].Trim();
                string storedEmail = accountDetails[1].Trim();
                string storedPassword = accountDetails[2].Trim();
                storedRole = accountDetails[3].Trim();
                User user1 = new User(storedUserName, storedEmail, storedPassword, storedRole);
                CurrentUser.Login(user1);
                if (userName.ToLower() == storedUserName.ToLower() || userName.ToLower() == storedEmail.ToLower())
                {
                    isUserNameAuthenticated = true;
                    if (password == storedPassword)
                    {
                        isPasswordAuthenticated = true;
                        break; // Exit the loop if both username and password are authenticated
                    }
                }


            }
            if (isUserNameAuthenticated && isPasswordAuthenticated)
            {
                if (storedRole == "0")
                {

                    frmCustomer_Dashboard customer_Dashboard = new frmCustomer_Dashboard();
                    customer_Dashboard.Show();
                    this.Hide();
                    

                }
                else if (storedRole == "1")
                {
                    frmAdmin_Dashboard admin_Dashboard = new frmAdmin_Dashboard();
                    admin_Dashboard.Show();
                    this.Hide();
                }
               

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }



        public bool UserValidation()
        {
            if (string.IsNullOrEmpty(txtUsernameOrEmail.Text.Trim()) || string.IsNullOrWhiteSpace(txtUsernameOrEmail.Text.Trim()))
            {
                ValidationError.SetError(txtUsernameOrEmail, "This Field Is Required");
                return false;
            }
            else
            {
                ValidationError.SetError(txtUsernameOrEmail, "");

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


            return true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void lblSignUp_Click(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click_1(object sender, EventArgs e)
        {
            frmSingup Singup = new frmSingup();
            Singup.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}



//using System;
//using System.Windows.Forms;

//namespace DSW_Semester_Project
//{
//    public partial class frmLogin : Form
//    {
//        private AuthenticationService authenticationService;

//        public frmLogin()
//        {
//            InitializeComponent();

//            authenticationService = new AuthenticationService();
//        }

//        private void frmLogin_Load(object sender, EventArgs e)
//        {
//            txtPassword.UseSystemPasswordChar = true;
//        }

//        private void btnAuthenticate_Click(object sender, EventArgs e)
//        {
//            // Check that the user entered something
//            if (!UserValidation())
//            {
//                return;
//            }

//            string usernameOrEmail = txtUsernameOrEmail.Text.Trim();
//            string password = txtPassword.Text;

//            // Ask AuthenticationService to check the login
//            User user = authenticationService.Login(
//                usernameOrEmail,
//                password
//            );

//            // Login failed
//            if (user == null)
//            {
//                MessageBox.Show(
//                    "Invalid username or password.",
//                    "Login Error",
//                    MessageBoxButtons.OK,
//                    MessageBoxIcon.Error
//                );

//                return;
//            }

//            // Save the logged-in user
//            CurrentUser.Login(user);

//            MessageBox.Show(
//                "Login successful!",
//                "Login",
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
//            if (string.IsNullOrWhiteSpace(txtUsernameOrEmail.Text))
//            {
//                ValidationError.SetError(
//                    txtUsernameOrEmail,
//                    "This field is required"
//                );

//                return false;
//            }

//            ValidationError.SetError(
//                txtUsernameOrEmail,
//                ""
//            );

//            if (string.IsNullOrWhiteSpace(txtPassword.Text))
//            {
//                ValidationError.SetError(
//                    txtPassword,
//                    "This field is required"
//                );

//                return false;
//            }

//            ValidationError.SetError(
//                txtPassword,
//                ""
//            );

//            return true;
//        }

//        private void chkShowPassword_CheckedChanged(
//            object sender,
//            EventArgs e)
//        {
//            if (chkShowPassword.Checked)
//            {
//                txtPassword.UseSystemPasswordChar = false;
//            }
//            else
//            {
//                txtPassword.UseSystemPasswordChar = true;
//            }
//        }

//        private void lblSignUp_Click_1(
//            object sender,
//            EventArgs e)
//        {
//            frmSingup signup = new frmSingup();

//            signup.Show();
//            this.Hide();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {
//        }

//        private void lblSignUp_Click(object sender, EventArgs e)
//        {
//        }
//    }
//}
