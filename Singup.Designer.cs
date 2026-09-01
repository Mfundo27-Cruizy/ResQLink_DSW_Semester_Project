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
            lblSmartEmergency = new Label();
            lblResqlink = new Label();
            pbxLogo = new PictureBox();
            ValidationError = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            lblHaveAccount = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnCreateAccount = new Button();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            pnlDisplay = new Panel();
            cmbRole = new ComboBox();
            lblRole = new Label();
            lblLogIn = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValidationError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // lblSmartEmergency
            // 
            lblSmartEmergency.AutoSize = true;
            lblSmartEmergency.ForeColor = SystemColors.ControlLightLight;
            lblSmartEmergency.Location = new Point(338, 90);
            lblSmartEmergency.Margin = new Padding(2, 0, 2, 0);
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
            lblResqlink.Margin = new Padding(2, 0, 2, 0);
            lblResqlink.Name = "lblResqlink";
            lblResqlink.Size = new Size(114, 30);
            lblResqlink.TabIndex = 8;
            lblResqlink.Text = "ResQLink";
            // 
            // pbxLogo
            // 
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(352, -62);
            pbxLogo.Margin = new Padding(2);
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
            pictureBox1.Margin = new Padding(2);
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
            lblHaveAccount.Location = new Point(281, 659);
            lblHaveAccount.Margin = new Padding(2, 0, 2, 0);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(213, 25);
            lblHaveAccount.TabIndex = 13;
            lblHaveAccount.Text = "Already have an account?";
            lblHaveAccount.Click += lblHaveAccount_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(19, 144);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(140, 25);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Email Address";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(15, 230);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(98, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 182);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "e.g vance@resqlink.gov";
            txtEmail.Size = new Size(778, 34);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(19, 258);
            txtPassword.Margin = new Padding(2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(776, 32);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Red;
            btnCreateAccount.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.ForeColor = SystemColors.ControlLightLight;
            btnCreateAccount.Location = new Point(15, 458);
            btnCreateAccount.Margin = new Padding(2);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(776, 45);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 302);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 8;
            label1.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(18, 330);
            txtConfirmPassword.Margin = new Padding(2);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm your password";
            txtConfirmPassword.Size = new Size(776, 32);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(304, 38);
            label2.TabIndex = 10;
            label2.Text = "Create Your Account";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(18, 72);
            lblFullName.Margin = new Padding(2, 0, 2, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(102, 25);
            lblFullName.TabIndex = 11;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(13, 108);
            txtFullName.Margin = new Padding(2);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "e.g vance Smith";
            txtFullName.Size = new Size(778, 34);
            txtFullName.TabIndex = 12;
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.White;
            pnlDisplay.Controls.Add(cmbRole);
            pnlDisplay.Controls.Add(lblRole);
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
            pnlDisplay.Margin = new Padding(2);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(816, 515);
            pnlDisplay.TabIndex = 6;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Customer(Default)", "Administrator" });
            cmbRole.Location = new Point(19, 407);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(182, 33);
            cmbRole.TabIndex = 14;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(19, 379);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 25);
            lblRole.TabIndex = 13;
            lblRole.Text = "Role";
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Cursor = Cursors.Hand;
            lblLogIn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblLogIn.ForeColor = SystemColors.ControlLightLight;
            lblLogIn.Location = new Point(499, 659);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(63, 25);
            lblLogIn.TabIndex = 15;
            lblLogIn.Text = "login ";
            lblLogIn.Click += lblLogin_Click;
            // 
            // frmSingup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1061, 703);
            Controls.Add(lblLogIn);
            Controls.Add(lblHaveAccount);
            Controls.Add(pictureBox1);
            Controls.Add(pnlDisplay);
            Controls.Add(lblSmartEmergency);
            Controls.Add(lblResqlink);
            Controls.Add(pbxLogo);
            Margin = new Padding(2);
            Name = "frmSingup";
            Text = "frmSingup";
            Load += frmSingup_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValidationError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblForgotPassword;
        private Label lblSmartEmergency;
        private Label lblResqlink;
        private PictureBox pbxLogo;
        private ErrorProvider ValidationError;
        private PictureBox pictureBox1;
        private Label lblHaveAccount;
        private Panel pnlDisplay;
        private ComboBox cmbRole;
        private Label lblRole;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label label2;
        private TextBox txtConfirmPassword;
        private Label label1;
        private Button btnCreateAccount;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblLogIn;
    }
}