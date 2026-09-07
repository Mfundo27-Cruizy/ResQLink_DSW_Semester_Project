using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSW_Semester_Project
{
    public partial class frmActiveIncidents : Form
    {
        List<Active_Incidents> incidents = new List<Active_Incidents>();

        public frmActiveIncidents()
        {
            InitializeComponent();

            LoadIncidents();

            DisplayIncidents();
        }



        private int GenerateIncidentNumber()
        {
            Random random = new Random();
            int number = random.Next(100, 1000);

            return number;
        }

        private void LoadIncidents()
        {
            incidents.Clear();

            if (!File.Exists("incidents.txt"))
            {
                return;
            }

            string[] lines = File.ReadAllLines("incidents.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                string[] incidentData = lines[i].Split('|');

                string referenceNumber = incidentData[0].Trim();
                string emergencyType = incidentData[1].Trim();
                string location = incidentData[2].Trim();
                string severity = incidentData[3].Trim();
                int affectedPeople = int.Parse(incidentData[4].Trim());
                string priority = incidentData[5].Trim();
                DateTime dateReported; 
                if (!DateTime.TryParse(incidentData[6].Trim(), out dateReported))
                {
                    dateReported = DateTime.Now;
                }
                string status = "";
                string description = "";
                if (incidentData.Length > 8)
                {
                     status = incidentData[7].Trim();
                     description = incidentData[8].Trim();
                }
                
                int incidentNumber = incidentData.Length;

                Active_Incidents incident = new Active_Incidents(referenceNumber, incidentNumber, emergencyType, location, severity, priority, affectedPeople, dateReported, status, description);
                
                incidents.Add(incident);

                i++;
            }

            DisplayIncidents();
        }

        private void CreateIncidentCard(Active_Incidents incident)
        {
            Panel card = new Panel();

            card.Width = 1000;
            card.Height = 175;
            card.Margin = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.BackColor = Color.White;
            card.AutoSize = true;

            Label lblIncidentNumber = new Label();
            lblIncidentNumber.Text = "Incident: #" + incident.incidentNumber;
            lblIncidentNumber.Location = new Point(500, 15);
            lblIncidentNumber.ForeColor = Color.Black;
            lblIncidentNumber.AutoSize = true;

            Label lblSeverity = new Label();
            lblSeverity.Text = incident.severity.ToUpper();
            lblSeverity.Location = new Point(15, 15);
            lblSeverity.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblSeverity.ForeColor = Color.Black;
            lblSeverity.AutoSize = true;
            lblSeverity.BorderStyle = BorderStyle.Fixed3D;
            if (incident.severity == "Critical")
            {
                lblSeverity.BackColor = Color.Red;
            }
            else if (incident.severity == "High")
            {

                lblSeverity.BackColor = Color.OrangeRed;
            }
            else if (incident.severity == "Medium")
            {

                lblSeverity.BackColor = Color.Orange;
            }

            Label lblEmergencyType = new Label();
            lblEmergencyType.Text = "Emergency Type: " + incident.emergencyType;
            lblEmergencyType.Location = new Point(15, 45);
            lblEmergencyType.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblEmergencyType.ForeColor = Color.Black;
            lblEmergencyType.AutoSize = true;

            Label lblLocation = new Label();
            lblLocation.Text = "Location: " + incident.location;
            lblLocation.Location = new Point(15, 80);
            //lblLocation.Font
            lblLocation.AutoSize = true;
            lblLocation.ForeColor = Color.Black;

            Label lblAffectedPeople = new Label();
            lblAffectedPeople.Text = "Affected people: " + incident.affectedPeople;
            lblAffectedPeople.Location = new Point(15, 105);
            lblAffectedPeople.ForeColor = Color.Black;
            lblAffectedPeople.AutoSize = true;

            Label lblincidentReference = new Label();
            lblincidentReference.Text = "Incident reference: " + incident.referenceNumber;
            lblincidentReference.Location = new Point(15,130);
            lblincidentReference.ForeColor = Color.Black;
            lblincidentReference.AutoSize = true;

            Label lbldateReported = new Label();
            lbldateReported.Text = "Date reported: " + incident.dateReported;
            lbldateReported.Location = new Point(500,155);
            lbldateReported.ForeColor = Color.Black;
            lbldateReported.AutoSize = true;
            lbldateReported.Font = new Font("Segoe UI", 10, FontStyle.Italic);

            Label lblDescription = new Label();
            lblDescription.Text = "Description: " + incident.description;
            lblDescription.Location = new Point(15, 155);
            lblDescription.Width = 400;
            lblDescription.Height = 50;
            lblDescription.ForeColor = Color.Black;

            card.Controls.Add(lblSeverity);
            card.Controls.Add(lblEmergencyType);
            card.Controls.Add(lblLocation);
            card.Controls.Add(lblAffectedPeople);
            card.Controls.Add(lblDescription);
            card.Controls.Add(lbldateReported);
            card.Controls.Add(lblincidentReference);
            card.Controls.Add(lblIncidentNumber);


            flpActivePanel.Controls.Add(card);
        }

        private void DisplayIncidents()
        {
            flpActivePanel.Controls.Clear();

            foreach (Active_Incidents incident in incidents)
            {
                CreateIncidentCard(incident);
            }
        }

        private void btnActiveIncidents_Click(object sender, EventArgs e)
        {
            frmActiveIncidents form = new frmActiveIncidents();
            btnActiveIncidents.BackColor = Color.DarkBlue;
            form.Show();

        }

        private void btnTrackProgress_Click(object sender, EventArgs e)
        {
            int searchIncident = int.Parse(txtIncidentNumber.Text);

            bool incidentFound = false;
            foreach (Active_Incidents incident in incidents)
            {
                if (incident.incidentNumber == searchIncident)
                {
                    MessageBox.Show("The incident exists.");
                    incidentFound = true;
                }
            }

            if (!incidentFound)
            {
                MessageBox.Show("The incident number entered does not exist!");
            }

        }

        private void btnReportIncidents_Click(object sender, EventArgs e)
        {
            //frmReportIncidents1 form = new frmReportIncidents1();
            //form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pnlMAin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmCustomer_Dashboard dashboard = new frmCustomer_Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnRreportIncidents_Click(object sender, EventArgs e)
        {
            frmReportIncidents reportIncidents = new frmReportIncidents();
            reportIncidents.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmSingup login = new frmSingup();
            login.Show();
            this.Hide();
        }
    }
}
