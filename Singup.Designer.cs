namespace DSW_Semester_Project
{
    partial class frmSingup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSingup));
            pnlDisplay = new Panel();
            txtFullName = new TextBox();
            lblFullName = new Label();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            btnCreateAccount = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            lblRequestSetup = new Label();
            lblNeedResQLinkDeployment = new Label();
            lblSmartEmergency = new Label();
            lblResqlink = new Label();
            pbxLogo = new PictureBox();
            ValidationError = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            lblHaveAccount = new Label();
            btnLogin = new Button();
            pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValidationError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.White;
            pnlDisplay.Controls.Add(txtFullName);
            pnlDisplay.Controls.Add(lblFullName);
            pnlDisplay.Controls.Add(label2);
            pnlDisplay.Controls.Add(txtConfirmPassword);
            pnlDisplay.Controls.Add(label1);
            pnlDisplay.Controls.Add(btnCreateAccount);
            pnlDisplay.Controls.Add(txtPassword);
            pnlDisplay.Controls.Add(txtEmail);
            pnlDisplay.Controls.Add(lblPassword);
            pnlDisplay.Controls.Add(lblUsername);
            pnlDisplay.Location = new Point(110, 131);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(816, 446);
            pnlDisplay.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(13, 110);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "e.g vance Smith";
            txtFullName.Size = new Size(778, 34);
            txtFullName.TabIndex = 12;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(17, 72);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(102, 25);
            lblFullName.TabIndex = 11;
            lblFullName.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 13);
            label2.Name = "label2";
            label2.Size = new Size(304, 38);
            label2.TabIndex = 10;
            label2.Text = "Create Your Account";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(17, 330);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm your password";
            txtConfirmPassword.Size = new Size(776, 31);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 302);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 8;
            label1.Text = "Confirm Password";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Red;
            btnCreateAccount.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = SystemColors.ControlLightLight;
            btnCreateAccount.Location = new Point(21, 388);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(776, 45);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(19, 258);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(776, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 182);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "e.g vance@resqlink.gov";
            txtEmail.Size = new Size(778, 34);
            txtEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(15, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(19, 144);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(140, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Email Address";
            // 
            // lblRequestSetup
            // 
            lblRequestSetup.AutoSize = true;
            lblRequestSetup.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRequestSetup.ForeColor = SystemColors.ControlLightLight;
            lblRequestSetup.Location = new Point(497, 592);
            lblRequestSetup.Name = "lblRequestSetup";
            lblRequestSetup.Size = new Size(140, 25);
            lblRequestSetup.TabIndex = 11;
            lblRequestSetup.Text = "Request Setup";
            // 
            // lblNeedResQLinkDeployment
            // 
            lblNeedResQLinkDeployment.AutoSize = true;
            lblNeedResQLinkDeployment.ForeColor = SystemColors.ControlLightLight;
            lblNeedResQLinkDeployment.Location = new Point(110, 592);
            lblNeedResQLinkDeployment.Name = "lblNeedResQLinkDeployment";
            lblNeedResQLinkDeployment.Size = new Size(364, 25);
            lblNeedResQLinkDeployment.TabIndex = 10;
            lblNeedResQLinkDeployment.Text = "Need ResQLink deployment for your facility?";
            lblNeedResQLinkDeployment.Click += lblNeedResQLinkDeployment_Click;
            // 
            // lblSmartEmergency
            // 
            lblSmartEmergency.AutoSize = true;
            lblSmartEmergency.ForeColor = SystemColors.ControlLightLight;
            lblSmartEmergency.Location = new Point(338, 90);
            lblSmartEmergency.Name = "lblSmartEmergency";
            lblSmartEmergency.Size = new Size(322, 25);
            lblSmartEmergency.TabIndex = 9;
            lblSmartEmergency.Text = "Smart Emergency Coordination System";
            // 
            // lblResqlink
            // 
            lblResqlink.AutoSize = true;
            lblResqlink.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResqlink.ForeColor = SystemColors.ControlLightLight;
            lblResqlink.Location = new Point(432, 60);
            lblResqlink.Name = "lblResqlink";
            lblResqlink.Size = new Size(114, 30);
            lblResqlink.TabIndex = 8;
            lblResqlink.Text = "ResQLink";
            // 
            // pbxLogo
            // 
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(353, -63);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(72, 56);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 7;
            pbxLogo.TabStop = false;
            // 
            // ValidationError
            // 
            ValidationError.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(451, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.AutoSize = true;
            lblHaveAccount.BackColor = Color.FromArgb(0, 0, 64);
            lblHaveAccount.ForeColor = SystemColors.ControlLightLight;
            lblHaveAccount.Location = new Point(287, 631);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(213, 25);
            lblHaveAccount.TabIndex = 13;
            lblHaveAccount.Text = "Already have an account?";
            lblHaveAccount.Click += lblHaveAccount_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 0, 64);
            btnLogin.ForeColor = Color.Red;
            btnLogin.Location = new Point(497, 626);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmSingup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1061, 665);
            Controls.Add(btnLogin);
            Controls.Add(lblHaveAccount);
            Controls.Add(pictureBox1);
            Controls.Add(pnlDisplay);
            Controls.Add(lblRequestSetup);
            Controls.Add(lblNeedResQLinkDeployment);
            Controls.Add(lblSmartEmergency);
            Controls.Add(lblResqlink);
            Controls.Add(pbxLogo);
            Name = "frmSingup";
            Text = "frmSingup";
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValidationError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDisplay;
        private Label lblForgotPassword;
        private Button btnCreateAccount;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblRequestSetup;
        private Label lblNeedResQLinkDeployment;
        private Label lblSmartEmergency;
        private Label lblResqlink;
        private PictureBox pbxLogo;
        private ErrorProvider ValidationError;
        private TextBox txtConfirmPassword;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnLogin;
        private Label lblHaveAccount;
        private TextBox txtFullName;
        private Label lblFullName;
    }
}