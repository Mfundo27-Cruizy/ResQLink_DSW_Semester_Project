namespace DSW_Semester_Project
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnlDisplay = new Panel();
            chkShowPassword = new CheckBox();
            lblSingin = new Label();
            lblForgotPassword = new Label();
            btnAuthenticate = new Button();
            txtPassword = new TextBox();
            txtUsernameOrEmail = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblCredintials = new Label();
            pbxLogo = new PictureBox();
            lblResqlink = new Label();
            lblSmartEmergency = new Label();
            ValidationError = new ErrorProvider(components);
            lblNoAccount = new Label();
            lblSignUp = new Label();
            pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValidationError).BeginInit();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.White;
            pnlDisplay.Controls.Add(chkShowPassword);
            pnlDisplay.Controls.Add(lblSingin);
            pnlDisplay.Controls.Add(lblForgotPassword);
            pnlDisplay.Controls.Add(btnAuthenticate);
            pnlDisplay.Controls.Add(txtPassword);
            pnlDisplay.Controls.Add(txtUsernameOrEmail);
            pnlDisplay.Controls.Add(lblPassword);
            pnlDisplay.Controls.Add(lblUsername);
            pnlDisplay.Controls.Add(lblCredintials);
            pnlDisplay.Location = new Point(111, 169);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(856, 416);
            pnlDisplay.TabIndex = 0;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(29, 314);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(162, 29);
            chkShowPassword.TabIndex = 9;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblSingin
            // 
            lblSingin.AutoSize = true;
            lblSingin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSingin.Location = new Point(21, 30);
            lblSingin.Name = "lblSingin";
            lblSingin.Size = new Size(94, 32);
            lblSingin.TabIndex = 8;
            lblSingin.Text = "Sign in";
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.Cursor = Cursors.Hand;
            lblForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.Red;
            lblForgotPassword.Location = new Point(645, 235);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(181, 25);
            lblForgotPassword.TabIndex = 7;
            lblForgotPassword.Text = "Forgot password?";
            // 
            // btnAuthenticate
            // 
            btnAuthenticate.BackColor = Color.Red;
            btnAuthenticate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuthenticate.ForeColor = SystemColors.ControlLightLight;
            btnAuthenticate.Location = new Point(21, 357);
            btnAuthenticate.Name = "btnAuthenticate";
            btnAuthenticate.Size = new Size(776, 45);
            btnAuthenticate.TabIndex = 6;
            btnAuthenticate.Text = "Authenticate && Connect";
            btnAuthenticate.UseVisualStyleBackColor = false;
            btnAuthenticate.Click += btnAuthenticate_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(21, 263);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new Size(776, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsernameOrEmail
            // 
            txtUsernameOrEmail.Location = new Point(19, 167);
            txtUsernameOrEmail.Multiline = true;
            txtUsernameOrEmail.Name = "txtUsernameOrEmail";
            txtUsernameOrEmail.PlaceholderText = "e.g vance@resqlink.gov";
            txtUsernameOrEmail.Size = new Size(778, 34);
            txtUsernameOrEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(21, 235);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(19, 139);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(247, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username / Email Address";
            // 
            // lblCredintials
            // 
            lblCredintials.Location = new Point(19, 91);
            lblCredintials.Name = "lblCredintials";
            lblCredintials.Size = new Size(515, 29);
            lblCredintials.TabIndex = 1;
            lblCredintials.Text = "Enter your credentials to access the incident desk.";
            // 
            // pbxLogo
            // 
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(492, 31);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(72, 56);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 1;
            pbxLogo.TabStop = false;
            // 
            // lblResqlink
            // 
            lblResqlink.AutoSize = true;
            lblResqlink.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResqlink.ForeColor = SystemColors.ControlLightLight;
            lblResqlink.Location = new Point(479, 79);
            lblResqlink.Name = "lblResqlink";
            lblResqlink.Size = new Size(114, 30);
            lblResqlink.TabIndex = 2;
            lblResqlink.Text = "ResQLink";
            // 
            // lblSmartEmergency
            // 
            lblSmartEmergency.AutoSize = true;
            lblSmartEmergency.ForeColor = SystemColors.ControlLightLight;
            lblSmartEmergency.Location = new Point(385, 119);
            lblSmartEmergency.Name = "lblSmartEmergency";
            lblSmartEmergency.Size = new Size(322, 25);
            lblSmartEmergency.TabIndex = 3;
            lblSmartEmergency.Text = "Smart Emergency Coordination System";
            // 
            // ValidationError
            // 
            ValidationError.ContainerControl = this;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.ForeColor = SystemColors.ControlLightLight;
            lblNoAccount.Location = new Point(291, 604);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(197, 25);
            lblNoAccount.TabIndex = 8;
            lblNoAccount.Text = "Don't have an account?";
            lblNoAccount.Click += label1_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Cursor = Cursors.Hand;
            lblSignUp.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = SystemColors.ControlLightLight;
            lblSignUp.Location = new Point(494, 604);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(123, 25);
            lblSignUp.TabIndex = 10;
            lblSignUp.Text = "Sign up here";
            lblSignUp.Click += lblSignUp_Click_1;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1031, 681);
            Controls.Add(lblSignUp);
            Controls.Add(lblNoAccount);
            Controls.Add(lblSmartEmergency);
            Controls.Add(lblResqlink);
            Controls.Add(pbxLogo);
            Controls.Add(pnlDisplay);
            Name = "frmLogin";
            Text = " frmLogin";
            Load += frmLogin_Load;
            Click += lblSignUp_Click;
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValidationError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDisplay;
        private Label lblUsername;
        private Label lblCredintials;
        private Button btnAuthenticate;
        private TextBox txtPassword;
        private TextBox txtUsernameOrEmail;
        private Label lblPassword;
        private PictureBox pbxLogo;
        private Label lblResqlink;
        private Label lblSmartEmergency;
        private Label lblForgotPassword;
        private ErrorProvider ValidationError;
        private Label lblNoAccount;
        private Label lblSingin;
        private Label lblSignUp;
        private CheckBox chkShowPassword;
    }
}
