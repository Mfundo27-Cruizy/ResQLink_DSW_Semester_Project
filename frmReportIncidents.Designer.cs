namespace DSW_Semester_Project
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            frmHomePage = new PictureBox();
            lblDashboard = new Label();
            pbxLogo = new PictureBox();
            lblResQLink = new Label();
            lblCommandCenter = new Label();
            btnDashboard = new Button();
            btnRreportIncidents = new Button();
            btnActiveIncidents = new Button();
            btnLogOut = new Button();
            lblWelcomeMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)frmHomePage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // frmHomePage
            // 
            frmHomePage.Image = Properties.Resources.logo;
            frmHomePage.Location = new Point(301, 81);
            frmHomePage.Margin = new Padding(4);
            frmHomePage.Name = "frmHomePage";
            frmHomePage.Size = new Size(1039, 756);
            frmHomePage.SizeMode = PictureBoxSizeMode.Zoom;
            frmHomePage.TabIndex = 1;
            frmHomePage.TabStop = false;
            // 
            // lblDashboard
            // 
            lblDashboard.BackColor = Color.FromArgb(4, 5, 36);
            lblDashboard.Location = new Point(-14, -5);
            lblDashboard.Margin = new Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(316, 828);
            lblDashboard.TabIndex = 3;
            // 
            // pbxLogo
            // 
            pbxLogo.BackColor = Color.FromArgb(4, 5, 36);
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(14, 31);
            pbxLogo.Margin = new Padding(2);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(111, 88);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 4;
            pbxLogo.TabStop = false;
            // 
            // lblResQLink
            // 
            lblResQLink.AutoSize = true;
            lblResQLink.BackColor = Color.FromArgb(4, 5, 36);
            lblResQLink.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResQLink.ForeColor = Color.White;
            lblResQLink.Location = new Point(115, 44);
            lblResQLink.Margin = new Padding(4, 0, 4, 0);
            lblResQLink.Name = "lblResQLink";
            lblResQLink.Size = new Size(118, 32);
            lblResQLink.TabIndex = 5;
            lblResQLink.Text = "ResQLink";
            // 
            // lblCommandCenter
            // 
            lblCommandCenter.AutoSize = true;
            lblCommandCenter.BackColor = Color.FromArgb(4, 5, 36);
            lblCommandCenter.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCommandCenter.ForeColor = Color.Silver;
            lblCommandCenter.Location = new Point(115, 81);
            lblCommandCenter.Margin = new Padding(4, 0, 4, 0);
            lblCommandCenter.Name = "lblCommandCenter";
            lblCommandCenter.Size = new Size(153, 21);
            lblCommandCenter.TabIndex = 6;
            lblCommandCenter.Text = "COMMAND CENTER";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(4, 5, 36);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(40, 164);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(199, 36);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnRreportIncidents
            // 
            btnRreportIncidents.BackColor = Color.FromArgb(4, 5, 36);
            btnRreportIncidents.ForeColor = Color.White;
            btnRreportIncidents.Location = new Point(40, 239);
            btnRreportIncidents.Margin = new Padding(4);
            btnRreportIncidents.Name = "btnRreportIncidents";
            btnRreportIncidents.Size = new Size(199, 36);
            btnRreportIncidents.TabIndex = 8;
            btnRreportIncidents.Text = "Report Incidents";
            btnRreportIncidents.TextAlign = ContentAlignment.BottomCenter;
            btnRreportIncidents.UseVisualStyleBackColor = false;
            // 
            // btnActiveIncidents
            // 
            btnActiveIncidents.BackColor = Color.FromArgb(4, 5, 36);
            btnActiveIncidents.ForeColor = Color.White;
            btnActiveIncidents.Location = new Point(40, 310);
            btnActiveIncidents.Margin = new Padding(4);
            btnActiveIncidents.Name = "btnActiveIncidents";
            btnActiveIncidents.Size = new Size(199, 36);
            btnActiveIncidents.TabIndex = 9;
            btnActiveIncidents.Text = "Active Incidents";
            btnActiveIncidents.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(4, 5, 36);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(40, 380);
            btnLogOut.Margin = new Padding(4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(199, 36);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.Location = new Point(481, 31);
            lblWelcomeMessage.Margin = new Padding(4, 0, 4, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(278, 44);
            lblWelcomeMessage.TabIndex = 11;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 5, 36);
            ClientSize = new Size(1328, 805);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(btnLogOut);
            Controls.Add(btnActiveIncidents);
            Controls.Add(btnRreportIncidents);
            Controls.Add(btnDashboard);
            Controls.Add(lblCommandCenter);
            Controls.Add(lblResQLink);
            Controls.Add(pbxLogo);
            Controls.Add(lblDashboard);
            Controls.Add(frmHomePage);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmHome";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)frmHomePage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox frmHomePage;
        private Label lblDashboard;
        private PictureBox pbxLogo;
        private Label lblResQLink;
        private Label lblCommandCenter;
        private Button btnDashboard;
        private Button btnRreportIncidents;
        private Button btnActiveIncidents;
        private Button btnLogOut;
        private Label lblWelcomeMessage;
    }
}