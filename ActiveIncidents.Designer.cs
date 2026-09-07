namespace DSW_Semester_Project
{
    partial class frmActiveIncidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActiveIncidents));
            panel2 = new Panel();
            pnlMAin = new Panel();
            txtIncidentNumber = new TextBox();
            btnTrackProgress = new Button();
            lblActiveIcidents = new Label();
            flpActivePanel = new FlowLayoutPanel();
            lblWelcomeLoggedInUser = new Label();
            pbxProfile = new PictureBox();
            btnLogOut = new Button();
            lblResQLink = new Label();
            btnActiveIncidents = new Button();
            btnRreportIncidents = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            pbxLogo = new PictureBox();
            panel2.SuspendLayout();
            pnlMAin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProfile).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlMAin);
            panel2.Location = new Point(217, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(963, 603);
            panel2.TabIndex = 10;
            // 
            // pnlMAin
            // 
            pnlMAin.BackColor = Color.White;
            pnlMAin.Controls.Add(txtIncidentNumber);
            pnlMAin.Controls.Add(btnTrackProgress);
            pnlMAin.Controls.Add(lblActiveIcidents);
            pnlMAin.Controls.Add(flpActivePanel);
            pnlMAin.Location = new Point(3, 17);
            pnlMAin.Name = "pnlMAin";
            pnlMAin.Size = new Size(945, 583);
            pnlMAin.TabIndex = 1;
            pnlMAin.Paint += pnlMAin_Paint;
            // 
            // txtIncidentNumber
            // 
            txtIncidentNumber.Location = new Point(585, 31);
            txtIncidentNumber.Name = "txtIncidentNumber";
            txtIncidentNumber.PlaceholderText = "Incident Number";
            txtIncidentNumber.Size = new Size(150, 31);
            txtIncidentNumber.TabIndex = 18;
            // 
            // btnTrackProgress
            // 
            btnTrackProgress.BackColor = Color.Red;
            btnTrackProgress.FlatAppearance.BorderSize = 0;
            btnTrackProgress.FlatStyle = FlatStyle.Flat;
            btnTrackProgress.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrackProgress.ForeColor = Color.White;
            btnTrackProgress.Location = new Point(742, 31);
            btnTrackProgress.Margin = new Padding(4);
            btnTrackProgress.Name = "btnTrackProgress";
            btnTrackProgress.Size = new Size(199, 36);
            btnTrackProgress.TabIndex = 17;
            btnTrackProgress.Text = "Track Progress";
            btnTrackProgress.UseVisualStyleBackColor = false;
            // 
            // lblActiveIcidents
            // 
            lblActiveIcidents.AutoSize = true;
            lblActiveIcidents.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveIcidents.Location = new Point(0, 0);
            lblActiveIcidents.Name = "lblActiveIcidents";
            lblActiveIcidents.Size = new Size(339, 54);
            lblActiveIcidents.TabIndex = 1;
            lblActiveIcidents.Text = "Active Incidents";
            // 
            // flpActivePanel
            // 
            flpActivePanel.Location = new Point(21, 107);
            flpActivePanel.Name = "flpActivePanel";
            flpActivePanel.Size = new Size(921, 465);
            flpActivePanel.TabIndex = 0;
            // 
            // lblWelcomeLoggedInUser
            // 
            lblWelcomeLoggedInUser.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeLoggedInUser.ForeColor = Color.White;
            lblWelcomeLoggedInUser.Location = new Point(80, 69);
            lblWelcomeLoggedInUser.Name = "lblWelcomeLoggedInUser";
            lblWelcomeLoggedInUser.Size = new Size(110, 66);
            lblWelcomeLoggedInUser.TabIndex = 16;
            // 
            // pbxProfile
            // 
            pbxProfile.Image = (Image)resources.GetObject("pbxProfile.Image");
            pbxProfile.Location = new Point(3, 69);
            pbxProfile.Name = "pbxProfile";
            pbxProfile.Size = new Size(71, 49);
            pbxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbxProfile.TabIndex = 15;
            pbxProfile.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(0, 0, 64);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(8, 358);
            btnLogOut.Margin = new Padding(4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(199, 36);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lblResQLink
            // 
            lblResQLink.AutoSize = true;
            lblResQLink.BackColor = Color.FromArgb(0, 0, 64);
            lblResQLink.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResQLink.ForeColor = Color.White;
            lblResQLink.Location = new Point(50, 17);
            lblResQLink.Margin = new Padding(4, 0, 4, 0);
            lblResQLink.Name = "lblResQLink";
            lblResQLink.Size = new Size(91, 25);
            lblResQLink.TabIndex = 14;
            lblResQLink.Text = "ResQLink";
            // 
            // btnActiveIncidents
            // 
            btnActiveIncidents.BackColor = Color.FromArgb(0, 0, 64);
            btnActiveIncidents.FlatAppearance.BorderSize = 0;
            btnActiveIncidents.FlatStyle = FlatStyle.Flat;
            btnActiveIncidents.ForeColor = Color.White;
            btnActiveIncidents.Location = new Point(8, 301);
            btnActiveIncidents.Margin = new Padding(4);
            btnActiveIncidents.Name = "btnActiveIncidents";
            btnActiveIncidents.Size = new Size(199, 36);
            btnActiveIncidents.TabIndex = 13;
            btnActiveIncidents.Text = "Active Incidents";
            btnActiveIncidents.UseVisualStyleBackColor = false;
            // 
            // btnRreportIncidents
            // 
            btnRreportIncidents.BackColor = Color.FromArgb(0, 0, 64);
            btnRreportIncidents.FlatAppearance.BorderSize = 0;
            btnRreportIncidents.FlatStyle = FlatStyle.Flat;
            btnRreportIncidents.ForeColor = Color.White;
            btnRreportIncidents.Location = new Point(8, 245);
            btnRreportIncidents.Margin = new Padding(4);
            btnRreportIncidents.Name = "btnRreportIncidents";
            btnRreportIncidents.Size = new Size(199, 36);
            btnRreportIncidents.TabIndex = 12;
            btnRreportIncidents.Text = "Report Incidents";
            btnRreportIncidents.TextAlign = ContentAlignment.BottomCenter;
            btnRreportIncidents.UseVisualStyleBackColor = false;
            btnRreportIncidents.Click += btnRreportIncidents_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 0, 64);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(12, 188);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(199, 36);
            btnDashboard.TabIndex = 11;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblWelcomeLoggedInUser);
            panel1.Controls.Add(pbxProfile);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(lblResQLink);
            panel1.Controls.Add(btnActiveIncidents);
            panel1.Controls.Add(btnRreportIncidents);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(pbxLogo);
            panel1.Location = new Point(-4, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 603);
            panel1.TabIndex = 9;
            // 
            // pbxLogo
            // 
            pbxLogo.BackColor = Color.FromArgb(0, 0, 64);
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(8, 2);
            pbxLogo.Margin = new Padding(2);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(36, 62);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 6;
            pbxLogo.TabStop = false;
            // 
            // frmActiveIncidents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1177, 672);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmActiveIncidents";
            Text = "ActiveIncidents";
            panel2.ResumeLayout(false);
            pnlMAin.ResumeLayout(false);
            pnlMAin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProfile).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDateReported;
        private Label lblStatus;
        private Label lblLocation;
        private Label lblType;
        private Label lbl_ID;
        private Label lblRecentIcidents;
        private Panel panel2;
        private Panel pnlMAin;
        private TextBox txtDisplayRecentIncidents;
        private Label lblWelcomeLoggedInUser;
        private PictureBox pbxProfile;
        private Button btnLogOut;
        private Label lblResQLink;
        private Button btnActiveIncidents;
        private Button btnRreportIncidents;
        private Button btnDashboard;
        private Panel panel1;
        private PictureBox pbxLogo;
        private Label lblActiveIcidents;
        private FlowLayoutPanel flpActivePanel;
        private TextBox txtIncidentNumber;
        private Button btnTrackProgress;
    }
}