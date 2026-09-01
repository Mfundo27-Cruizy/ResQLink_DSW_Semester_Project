namespace DSW_Semester_Project
{
    partial class frmReportIncidents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportIncidents));
            lblDashboard = new Label();
            pbxLogo = new PictureBox();
            lblResQLink = new Label();
            btnDashboard = new Button();
            btnRreportIncidents = new Button();
            btnActiveIncidents = new Button();
            btnLogOut = new Button();
            grpReportInformation = new GroupBox();
            nudAffectedPeople = new NumericUpDown();
            grpProtocols = new GroupBox();
            txtGuide = new TextBox();
            btnSubmitRequest = new Button();
            txtIncidentDescription = new TextBox();
            lblIncidentDescription = new Label();
            cmbSeverity = new ComboBox();
            label4 = new Label();
            lblSeverity = new Label();
            txtIncidentLocation = new TextBox();
            lblIncidentLocation = new Label();
            cmbEmergencyType = new ComboBox();
            lblEmergrncyType = new Label();
            errChecker = new ErrorProvider(components);
            lblWelcomeLoggedInUser = new Label();
            pbxProfile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            grpReportInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAffectedPeople).BeginInit();
            grpProtocols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errChecker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxProfile).BeginInit();
            SuspendLayout();
            // 
            // lblDashboard
            // 
            lblDashboard.BackColor = Color.FromArgb(0, 0, 64);
            lblDashboard.Location = new Point(-9, -19);
            lblDashboard.Margin = new Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(316, 828);
            lblDashboard.TabIndex = 4;
            // 
            // pbxLogo
            // 
            pbxLogo.BackColor = Color.FromArgb(0, 0, 64);
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(14, 28);
            pbxLogo.Margin = new Padding(2);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(61, 43);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 5;
            pbxLogo.TabStop = false;
            // 
            // lblResQLink
            // 
            lblResQLink.AutoSize = true;
            lblResQLink.BackColor = Color.FromArgb(0, 0, 64);
            lblResQLink.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResQLink.ForeColor = Color.White;
            lblResQLink.Location = new Point(81, 28);
            lblResQLink.Margin = new Padding(4, 0, 4, 0);
            lblResQLink.Name = "lblResQLink";
            lblResQLink.Size = new Size(118, 32);
            lblResQLink.TabIndex = 6;
            lblResQLink.Text = "ResQLink";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 0, 64);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(39, 166);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(199, 36);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnRreportIncidents
            // 
            btnRreportIncidents.BackColor = Color.FromArgb(0, 0, 64);
            btnRreportIncidents.FlatAppearance.BorderSize = 0;
            btnRreportIncidents.FlatStyle = FlatStyle.Flat;
            btnRreportIncidents.ForeColor = Color.White;
            btnRreportIncidents.Location = new Point(39, 229);
            btnRreportIncidents.Margin = new Padding(4);
            btnRreportIncidents.Name = "btnRreportIncidents";
            btnRreportIncidents.Size = new Size(199, 36);
            btnRreportIncidents.TabIndex = 9;
            btnRreportIncidents.Text = "Report Incidents";
            btnRreportIncidents.TextAlign = ContentAlignment.BottomCenter;
            btnRreportIncidents.UseVisualStyleBackColor = false;
            // 
            // btnActiveIncidents
            // 
            btnActiveIncidents.BackColor = Color.FromArgb(0, 0, 64);
            btnActiveIncidents.FlatAppearance.BorderSize = 0;
            btnActiveIncidents.FlatStyle = FlatStyle.Flat;
            btnActiveIncidents.ForeColor = Color.White;
            btnActiveIncidents.Location = new Point(39, 298);
            btnActiveIncidents.Margin = new Padding(4);
            btnActiveIncidents.Name = "btnActiveIncidents";
            btnActiveIncidents.Size = new Size(199, 36);
            btnActiveIncidents.TabIndex = 10;
            btnActiveIncidents.Text = "Active Incidents";
            btnActiveIncidents.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(0, 0, 64);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(39, 361);
            btnLogOut.Margin = new Padding(4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(199, 36);
            btnLogOut.TabIndex = 11;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // grpReportInformation
            // 
            grpReportInformation.BackColor = Color.White;
            grpReportInformation.Controls.Add(nudAffectedPeople);
            grpReportInformation.Controls.Add(grpProtocols);
            grpReportInformation.Controls.Add(btnSubmitRequest);
            grpReportInformation.Controls.Add(txtIncidentDescription);
            grpReportInformation.Controls.Add(lblIncidentDescription);
            grpReportInformation.Controls.Add(cmbSeverity);
            grpReportInformation.Controls.Add(label4);
            grpReportInformation.Controls.Add(lblSeverity);
            grpReportInformation.Controls.Add(txtIncidentLocation);
            grpReportInformation.Controls.Add(lblIncidentLocation);
            grpReportInformation.Controls.Add(cmbEmergencyType);
            grpReportInformation.Controls.Add(lblEmergrncyType);
            grpReportInformation.ForeColor = Color.White;
            grpReportInformation.Location = new Point(328, 15);
            grpReportInformation.Margin = new Padding(4);
            grpReportInformation.Name = "grpReportInformation";
            grpReportInformation.Padding = new Padding(4);
            grpReportInformation.Size = new Size(949, 761);
            grpReportInformation.TabIndex = 12;
            grpReportInformation.TabStop = false;
            // 
            // nudAffectedPeople
            // 
            nudAffectedPeople.Location = new Point(511, 244);
            nudAffectedPeople.Margin = new Padding(4);
            nudAffectedPeople.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAffectedPeople.Name = "nudAffectedPeople";
            nudAffectedPeople.Size = new Size(399, 31);
            nudAffectedPeople.TabIndex = 12;
            // 
            // grpProtocols
            // 
            grpProtocols.Controls.Add(txtGuide);
            grpProtocols.Location = new Point(45, 584);
            grpProtocols.Margin = new Padding(4);
            grpProtocols.Name = "grpProtocols";
            grpProtocols.Padding = new Padding(4);
            grpProtocols.Size = new Size(878, 156);
            grpProtocols.TabIndex = 11;
            grpProtocols.TabStop = false;
            grpProtocols.Text = "Protocol Quick Guide";
            // 
            // txtGuide
            // 
            txtGuide.Enabled = false;
            txtGuide.ForeColor = Color.Red;
            txtGuide.Location = new Point(12, 31);
            txtGuide.Margin = new Padding(4);
            txtGuide.Multiline = true;
            txtGuide.Name = "txtGuide";
            txtGuide.ReadOnly = true;
            txtGuide.Size = new Size(856, 116);
            txtGuide.TabIndex = 0;
            txtGuide.TextChanged += txtGuide_TextChanged;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.BackColor = Color.Red;
            btnSubmitRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRequest.ForeColor = Color.Transparent;
            btnSubmitRequest.Location = new Point(44, 502);
            btnSubmitRequest.Margin = new Padding(4);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(866, 36);
            btnSubmitRequest.TabIndex = 10;
            btnSubmitRequest.Text = "Submit Request";
            btnSubmitRequest.UseVisualStyleBackColor = false;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // txtIncidentDescription
            // 
            txtIncidentDescription.Location = new Point(40, 346);
            txtIncidentDescription.Margin = new Padding(4);
            txtIncidentDescription.Multiline = true;
            txtIncidentDescription.Name = "txtIncidentDescription";
            txtIncidentDescription.Size = new Size(869, 116);
            txtIncidentDescription.TabIndex = 9;
            // 
            // lblIncidentDescription
            // 
            lblIncidentDescription.AutoSize = true;
            lblIncidentDescription.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncidentDescription.ForeColor = Color.Black;
            lblIncidentDescription.Location = new Point(40, 318);
            lblIncidentDescription.Margin = new Padding(4, 0, 4, 0);
            lblIncidentDescription.Name = "lblIncidentDescription";
            lblIncidentDescription.Size = new Size(253, 25);
            lblIncidentDescription.TabIndex = 8;
            lblIncidentDescription.Text = "Detail Incident Description";
            // 
            // cmbSeverity
            // 
            cmbSeverity.FormattingEnabled = true;
            cmbSeverity.Items.AddRange(new object[] { "Critical", "Medium", "Low" });
            cmbSeverity.Location = new Point(40, 242);
            cmbSeverity.Margin = new Padding(4);
            cmbSeverity.Name = "cmbSeverity";
            cmbSeverity.Size = new Size(423, 33);
            cmbSeverity.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(511, 214);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(342, 25);
            label4.TabIndex = 5;
            label4.Text = "Estimate Number of People Affected";
            // 
            // lblSeverity
            // 
            lblSeverity.AutoSize = true;
            lblSeverity.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeverity.ForeColor = Color.Black;
            lblSeverity.Location = new Point(40, 214);
            lblSeverity.Margin = new Padding(4, 0, 4, 0);
            lblSeverity.Name = "lblSeverity";
            lblSeverity.Size = new Size(203, 25);
            lblSeverity.TabIndex = 4;
            lblSeverity.Text = "Report Severity Level";
            lblSeverity.Click += label3_Click;
            // 
            // txtIncidentLocation
            // 
            txtIncidentLocation.Location = new Point(40, 165);
            txtIncidentLocation.Margin = new Padding(4);
            txtIncidentLocation.Name = "txtIncidentLocation";
            txtIncidentLocation.Size = new Size(869, 31);
            txtIncidentLocation.TabIndex = 3;
            // 
            // lblIncidentLocation
            // 
            lblIncidentLocation.AutoSize = true;
            lblIncidentLocation.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncidentLocation.ForeColor = Color.Black;
            lblIncidentLocation.Location = new Point(40, 136);
            lblIncidentLocation.Margin = new Padding(4, 0, 4, 0);
            lblIncidentLocation.Name = "lblIncidentLocation";
            lblIncidentLocation.Size = new Size(166, 25);
            lblIncidentLocation.TabIndex = 2;
            lblIncidentLocation.Text = "Incident Location";
            // 
            // cmbEmergencyType
            // 
            cmbEmergencyType.FormattingEnabled = true;
            cmbEmergencyType.Items.AddRange(new object[] { "Police Department", "Medical/Emergrncy Services", "Fire & Rescue Department", "Disaster Management", "Securirty Department", "Search & Rescue Department" });
            cmbEmergencyType.Location = new Point(40, 79);
            cmbEmergencyType.Margin = new Padding(4);
            cmbEmergencyType.Name = "cmbEmergencyType";
            cmbEmergencyType.Size = new Size(869, 33);
            cmbEmergencyType.TabIndex = 1;
            cmbEmergencyType.SelectedIndexChanged += cmbEmergencyType_SelectedIndexChanged;
            // 
            // lblEmergrncyType
            // 
            lblEmergrncyType.AutoSize = true;
            lblEmergrncyType.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergrncyType.ForeColor = Color.Black;
            lblEmergrncyType.Location = new Point(40, 50);
            lblEmergrncyType.Margin = new Padding(4, 0, 4, 0);
            lblEmergrncyType.Name = "lblEmergrncyType";
            lblEmergrncyType.Size = new Size(157, 25);
            lblEmergrncyType.TabIndex = 0;
            lblEmergrncyType.Text = "Emergency Type";
            // 
            // errChecker
            // 
            errChecker.ContainerControl = this;
            // 
            // lblWelcomeLoggedInUser
            // 
            lblWelcomeLoggedInUser.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeLoggedInUser.ForeColor = Color.White;
            lblWelcomeLoggedInUser.Location = new Point(129, 79);
            lblWelcomeLoggedInUser.Name = "lblWelcomeLoggedInUser";
            lblWelcomeLoggedInUser.Size = new Size(110, 67);
            lblWelcomeLoggedInUser.TabIndex = 18;
            // 
            // pbxProfile
            // 
            pbxProfile.Image = (Image)resources.GetObject("pbxProfile.Image");
            pbxProfile.Location = new Point(29, 78);
            pbxProfile.Name = "pbxProfile";
            pbxProfile.Size = new Size(94, 49);
            pbxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pbxProfile.TabIndex = 17;
            pbxProfile.TabStop = false;
            // 
            // frmReportIncidents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1291, 791);
            Controls.Add(lblWelcomeLoggedInUser);
            Controls.Add(pbxProfile);
            Controls.Add(grpReportInformation);
            Controls.Add(btnLogOut);
            Controls.Add(btnActiveIncidents);
            Controls.Add(btnRreportIncidents);
            Controls.Add(btnDashboard);
            Controls.Add(lblResQLink);
            Controls.Add(pbxLogo);
            Controls.Add(lblDashboard);
            ForeColor = Color.FromArgb(0, 0, 64);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmReportIncidents";
            Text = "frmReportIncidents";
            Load += frmReportIncidents1_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            grpReportInformation.ResumeLayout(false);
            grpReportInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAffectedPeople).EndInit();
            grpProtocols.ResumeLayout(false);
            grpProtocols.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errChecker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboard;
        private PictureBox pbxLogo;
        private Label lblResQLink;
        private Button btnDashboard;
        private Button btnRreportIncidents;
        private Button btnActiveIncidents;
        private Button btnLogOut;
        private GroupBox grpReportInformation;
        private Label label4;
        private Label lblSeverity;
        private TextBox txtIncidentLocation;
        private Label lblIncidentLocation;
        private ComboBox cmbEmergencyType;
        private Label lblEmergrncyType;
        private GroupBox grpProtocols;
        private Button btnSubmitRequest;
        private TextBox txtIncidentDescription;
        private Label lblIncidentDescription;
        private ComboBox cmbSeverity;
        private TextBox txtGuide;
        private ErrorProvider errChecker;
        private NumericUpDown nudAffectedPeople;
        private Label lblWelcomeLoggedInUser;
        private PictureBox pbxProfile;
    }
}