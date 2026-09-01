namespace DSW_Semester_Project
{
    partial class frmCustomer_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer_Dashboard));
            pbxLogo = new PictureBox();
            panel1 = new Panel();
            lblWelcomeLoggedInUser = new Label();
            pbxProfile = new PictureBox();
            btnLogOut = new Button();
            lblResQLink = new Label();
            btnActiveIncidents = new Button();
            btnRreportIncidents = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            pbxMyIncidents = new PictureBox();
            pbxReportIncident = new PictureBox();
            pbxLogOut = new PictureBox();
            lblQuickActions = new Label();
            panel4 = new Panel();
            txtDisplayRecentIncidents = new TextBox();
            lblDateReported = new Label();
            lblStatus = new Label();
            lblLocation = new Label();
            lblType = new Label();
            lbl_ID = new Label();
            lblRecentIcidents = new Label();
            panel3 = new Panel();
            lblUnresolvedIncidents = new Label();
            lbl_InProgressIncidents = new Label();
            lblResolved_Incidents = new Label();
            lblTotal_Incidents = new Label();
            pictureBox4 = new PictureBox();
            pbxInProgress = new PictureBox();
            pbxResolved = new PictureBox();
            pbxTotal_Icidents = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProfile).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMyIncidents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxReportIncident).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogOut).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxInProgress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxResolved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxTotal_Icidents).BeginInit();
            SuspendLayout();
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
            panel1.Location = new Point(5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 603);
            panel1.TabIndex = 7;
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
            btnDashboard.Location = new Point(8, 182);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(199, 36);
            btnDashboard.TabIndex = 11;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(226, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(963, 603);
            panel2.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pbxMyIncidents);
            panel5.Controls.Add(pbxReportIncident);
            panel5.Controls.Add(pbxLogOut);
            panel5.Controls.Add(lblQuickActions);
            panel5.Location = new Point(786, 124);
            panel5.Name = "panel5";
            panel5.Size = new Size(183, 468);
            panel5.TabIndex = 2;
            // 
            // pbxMyIncidents
            // 
            pbxMyIncidents.Cursor = Cursors.Hand;
            pbxMyIncidents.Image = (Image)resources.GetObject("pbxMyIncidents.Image");
            pbxMyIncidents.Location = new Point(24, 234);
            pbxMyIncidents.Name = "pbxMyIncidents";
            pbxMyIncidents.Size = new Size(150, 75);
            pbxMyIncidents.SizeMode = PictureBoxSizeMode.Zoom;
            pbxMyIncidents.TabIndex = 9;
            pbxMyIncidents.TabStop = false;
            // 
            // pbxReportIncident
            // 
            pbxReportIncident.Cursor = Cursors.Hand;
            pbxReportIncident.Image = (Image)resources.GetObject("pbxReportIncident.Image");
            pbxReportIncident.Location = new Point(24, 103);
            pbxReportIncident.Name = "pbxReportIncident";
            pbxReportIncident.Size = new Size(150, 75);
            pbxReportIncident.SizeMode = PictureBoxSizeMode.Zoom;
            pbxReportIncident.TabIndex = 8;
            pbxReportIncident.TabStop = false;
            pbxReportIncident.Click += pbxReportIncidents_Click;
            // 
            // pbxLogOut
            // 
            pbxLogOut.Cursor = Cursors.Hand;
            pbxLogOut.Image = (Image)resources.GetObject("pbxLogOut.Image");
            pbxLogOut.Location = new Point(24, 336);
            pbxLogOut.Name = "pbxLogOut";
            pbxLogOut.Size = new Size(127, 75);
            pbxLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogOut.TabIndex = 8;
            pbxLogOut.TabStop = false;
            pbxLogOut.Click += pbxLogOut_Click;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickActions.Location = new Point(18, 21);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(136, 25);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "Quick Actions";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtDisplayRecentIncidents);
            panel4.Controls.Add(lblDateReported);
            panel4.Controls.Add(lblStatus);
            panel4.Controls.Add(lblLocation);
            panel4.Controls.Add(lblType);
            panel4.Controls.Add(lbl_ID);
            panel4.Controls.Add(lblRecentIcidents);
            panel4.Location = new Point(3, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(777, 476);
            panel4.TabIndex = 1;
            // 
            // txtDisplayRecentIncidents
            // 
            txtDisplayRecentIncidents.Location = new Point(-3, 86);
            txtDisplayRecentIncidents.Multiline = true;
            txtDisplayRecentIncidents.Name = "txtDisplayRecentIncidents";
            txtDisplayRecentIncidents.ReadOnly = true;
            txtDisplayRecentIncidents.Size = new Size(777, 336);
            txtDisplayRecentIncidents.TabIndex = 7;
            // 
            // lblDateReported
            // 
            lblDateReported.AutoSize = true;
            lblDateReported.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateReported.Location = new Point(585, 58);
            lblDateReported.Name = "lblDateReported";
            lblDateReported.Size = new Size(137, 25);
            lblDateReported.TabIndex = 6;
            lblDateReported.Text = "Date Reported";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(454, 58);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(281, 58);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(85, 25);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(127, 58);
            lblType.Name = "lblType";
            lblType.Size = new Size(53, 25);
            lblType.TabIndex = 3;
            lblType.Text = "Type";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID.Location = new Point(17, 58);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(31, 25);
            lbl_ID.TabIndex = 1;
            lbl_ID.Text = "ID";
            // 
            // lblRecentIcidents
            // 
            lblRecentIcidents.AutoSize = true;
            lblRecentIcidents.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentIcidents.Location = new Point(17, 12);
            lblRecentIcidents.Name = "lblRecentIcidents";
            lblRecentIcidents.Size = new Size(159, 25);
            lblRecentIcidents.TabIndex = 2;
            lblRecentIcidents.Text = "Recent Incidents";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblUnresolvedIncidents);
            panel3.Controls.Add(lbl_InProgressIncidents);
            panel3.Controls.Add(lblResolved_Incidents);
            panel3.Controls.Add(lblTotal_Incidents);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pbxInProgress);
            panel3.Controls.Add(pbxResolved);
            panel3.Controls.Add(pbxTotal_Icidents);
            panel3.Location = new Point(6, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(954, 115);
            panel3.TabIndex = 0;
            // 
            // lblUnresolvedIncidents
            // 
            lblUnresolvedIncidents.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnresolvedIncidents.Location = new Point(798, 44);
            lblUnresolvedIncidents.Name = "lblUnresolvedIncidents";
            lblUnresolvedIncidents.Size = new Size(47, 27);
            lblUnresolvedIncidents.TabIndex = 15;
            lblUnresolvedIncidents.Text = "0";
            lblUnresolvedIncidents.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_InProgressIncidents
            // 
            lbl_InProgressIncidents.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_InProgressIncidents.Location = new Point(570, 44);
            lbl_InProgressIncidents.Name = "lbl_InProgressIncidents";
            lbl_InProgressIncidents.Size = new Size(47, 27);
            lbl_InProgressIncidents.TabIndex = 14;
            lbl_InProgressIncidents.Text = "0";
            lbl_InProgressIncidents.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResolved_Incidents
            // 
            lblResolved_Incidents.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResolved_Incidents.Location = new Point(316, 44);
            lblResolved_Incidents.Name = "lblResolved_Incidents";
            lblResolved_Incidents.Size = new Size(47, 27);
            lblResolved_Incidents.TabIndex = 13;
            lblResolved_Incidents.Text = "0";
            lblResolved_Incidents.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTotal_Incidents
            // 
            lblTotal_Incidents.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal_Incidents.Location = new Point(83, 44);
            lblTotal_Incidents.Name = "lblTotal_Incidents";
            lblTotal_Incidents.Size = new Size(47, 27);
            lblTotal_Incidents.TabIndex = 12;
            lblTotal_Incidents.Text = "0";
            lblTotal_Incidents.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Red;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(749, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(184, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pbxInProgress
            // 
            pbxInProgress.BackColor = Color.White;
            pbxInProgress.Image = (Image)resources.GetObject("pbxInProgress.Image");
            pbxInProgress.Location = new Point(509, 18);
            pbxInProgress.Name = "pbxInProgress";
            pbxInProgress.Size = new Size(216, 75);
            pbxInProgress.SizeMode = PictureBoxSizeMode.Zoom;
            pbxInProgress.TabIndex = 10;
            pbxInProgress.TabStop = false;
            // 
            // pbxResolved
            // 
            pbxResolved.Image = (Image)resources.GetObject("pbxResolved.Image");
            pbxResolved.Location = new Point(251, 18);
            pbxResolved.Name = "pbxResolved";
            pbxResolved.Size = new Size(218, 75);
            pbxResolved.SizeMode = PictureBoxSizeMode.Zoom;
            pbxResolved.TabIndex = 9;
            pbxResolved.TabStop = false;
            // 
            // pbxTotal_Icidents
            // 
            pbxTotal_Icidents.BackColor = Color.White;
            pbxTotal_Icidents.Image = (Image)resources.GetObject("pbxTotal_Icidents.Image");
            pbxTotal_Icidents.Location = new Point(21, 18);
            pbxTotal_Icidents.Name = "pbxTotal_Icidents";
            pbxTotal_Icidents.Size = new Size(204, 78);
            pbxTotal_Icidents.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTotal_Icidents.TabIndex = 8;
            pbxTotal_Icidents.TabStop = false;
            // 
            // frmCustomer_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1201, 627);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCustomer_Dashboard";
            Text = "Customer_Dashboard";
            Load += Customer_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxProfile).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMyIncidents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxReportIncident).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogOut).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxInProgress).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxResolved).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxTotal_Icidents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxLogo;
        private Panel panel1;
        private Button btnActiveIncidents;
        private Button btnRreportIncidents;
        private Button btnDashboard;
        private Label lblResQLink;
        private Panel panel2;
        private Button btnLogOut;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label lblWelcomeLoggedInUser;
        private PictureBox pbxProfile;
        private Label lbl_ID;
        private Label lblQuickActions;
        private Label lblRecentIcidents;
        private Label lblDateReported;
        private Label lblStatus;
        private Label lblLocation;
        private Label lblType;
        private TextBox txtDisplayRecentIncidents;
        private PictureBox pbxLogOut;
        private PictureBox pbxMyIncidents;
        private PictureBox pbxReportIncident;
        private PictureBox pictureBox4;
        private PictureBox pbxInProgress;
        private PictureBox pbxResolved;
        private PictureBox pbxTotal_Icidents;
        private Label lblUnresolvedIncidents;
        private Label lbl_InProgressIncidents;
        private Label lblResolved_Incidents;
        private Label lblTotal_Incidents;
    }
}