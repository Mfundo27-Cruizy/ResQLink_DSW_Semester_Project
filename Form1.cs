namespace DSW_Semester_Project
{
    public partial class frmLogin : Form
    {
        string userName = "";
        string password = "";
        public frmLogin()
        {
            InitializeComponent();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
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
            foreach (string item in accounts)
            { string[] accountDetails = item.Split('|');
                string storedUserName = accountDetails[0].Trim();
                string storedEmail = accountDetails[1].Trim();
                string storedPassword = accountDetails[2].Trim();

                if (userName == storedUserName || userName == storedEmail)
                {
                    isUserNameAuthenticated = true;
                }

                if (password == storedPassword)
                {
                    isPasswordAuthenticated = true;
                   
                }
            }
            if (isUserNameAuthenticated && isPasswordAuthenticated)
            {
                MessageBox.Show("Log in Successfully", "Log in");
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmSingup frmSingup = new frmSingup();
            frmSingup.Show();
            this.Hide();
        }
    }
}
