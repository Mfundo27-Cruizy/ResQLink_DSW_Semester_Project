using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DSW_Semester_Project
{
    public partial class frmReportIncidents : Form
    {
        public frmReportIncidents()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmReportIncidents1_Load(object sender, EventArgs e)
        {
            txtGuide.ForeColor = Color.Red;

            txtGuide.Text += "1 Select appropriete disaster type to route to the specialized responders\r\n";
            txtGuide.Text += "2 State the location with building refference zone and department names clearly\r\n";
            txtGuide.Text += "3 Specify the appropriete headcount to configure matching medical and transit response\r\n";
            cmbEmergencyType.Text = "Select Emergency Type";
            cmbSeverity.Text = "Select Severity";
            string name = CurrentUser.User.FullName;

            lblWelcomeLoggedInUser.Text = "Welcome " + name;
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            string emergencyType = cmbEmergencyType.Text;
            string severity = cmbSeverity.Text;
            string location = txtIncidentLocation.Text.Trim();
            string description = txtIncidentDescription.Text.Trim();
            int peopleAffected = (int)nudAffectedPeople.Value;


            if (!ValidateIncidentSummary(location, description, peopleAffected))
            {
                return;
            }

            try
            {
                //Creating incident object
                Emergency_Incidents incident = new Emergency_Incidents(emergencyType, location, severity,
                    peopleAffected, description
                    );

                //Saving the incident to a txt_File

                File.AppendAllText("incidents.txt", incident.ToFileString() + Environment.NewLine);

                // Display success message
                MessageBox.Show(
                    "Incident reported successfully!\n\n" +
                    "Reference Number: " + incident.ReferenceNumber + "\n" +
                    "Priority: " + incident.Priority + "\n" +
                    "Status: " + incident.Status,
                    "Incident Submitted"
                );

            }
            catch (Exception ex)
            {

                MessageBox.Show(
                  "An error occurred while saving the incident.\n\n" +
                  ex.Message,
                  "Error"
                 );
            }
            //    string emergencyType = cmbEmergencyType.Text.Trim();
            //    string severity = cmbSeverity.Text.Trim();
            //    string location = txtIncidentLocation.Text.Trim();
            //    int affectedPeople;
            //    int.TryParse(nudAffectedPeople.ToString(), out affectedPeople);
            //    string description = txtIncidentDescription.Text.Trim();

            //    bool isValid = true;

            //    if (cmbEmergencyType.SelectedIndex == -1)
            //    {
            //        errChecker.SetError(cmbEmergencyType, "Please select emergency type");
            //        isValid = false;
            //    }
            //    else
            //    {
            //        errChecker.SetError(cmbEmergencyType, null);
            //        isValid = true;
            //    }

            //    if (cmbSeverity.SelectedIndex == -1)
            //    {
            //        errChecker.SetError(cmbSeverity, "Please select severity rate");
            //        isValid = false;
            //    }
            //    else
            //    {
            //        errChecker.SetError(cmbSeverity, null);
            //        isValid = true;
            //    }

            //    if (String.IsNullOrEmpty(location))
            //    {
            //        errChecker.SetError(txtIncidentLocation, "Please enter location");
            //        isValid = false;
            //    }
            //    else
            //    {
            //        errChecker.SetError(txtIncidentLocation, null);
            //        isValid = true;
            //    }

            //    if (String.IsNullOrEmpty(description))
            //    {
            //        errChecker.SetError(txtIncidentDescription, "Please describe the incidend");
            //        isValid = false;
            //    }
            //    else
            //    {
            //        errChecker.SetError(txtIncidentDescription, null);
            //        isValid = true;
            //    }

            //    if (isValid)
            //    {
            //        string incidentInfo = $"{emergencyType} | {location} | {severity} | {affectedPeople}" + Environment.NewLine + description + Environment.NewLine + Environment.NewLine;

            //        File.AppendAllText("Incident_Summary", incidentInfo);
            //        ClearForm();
            //        MessageBox.Show("Incident reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
        }
        private void ClearForm()
        {
            cmbEmergencyType.Text = "Select Emergency Type";
            cmbSeverity.Text = "Select Severity";
            cmbEmergencyType.SelectedIndex = -1;
            cmbSeverity.SelectedIndex = -1;
            txtIncidentLocation.Clear();
            nudAffectedPeople.Value = 0;
            txtIncidentDescription.Clear();

        }

        private void cmbEmergencyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGuide_TextChanged(object sender, EventArgs e)
        {
            txtGuide.ForeColor = Color.Red;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmCustomer_Dashboard dashboard = new frmCustomer_Dashboard();
            dashboard.Show();
            this.Hide();
        }
        public bool ValidateIncidentSummary(string location, string description, int peopleAffected)
        {

            if (cmbEmergencyType.SelectedIndex == -1) // Validate emergancy type
            {
                errChecker.SetError(cmbEmergencyType, " Please select an emergency type");
                cmbEmergencyType.Focus();
                return false;
            }
            else
            {
                errChecker.SetError(cmbEmergencyType, null);
            }

            if (String.IsNullOrEmpty(location)) // Validate location
            {
                errChecker.SetError(txtIncidentLocation, "Please enter the incident location");
                txtIncidentLocation.Focus();
                return false;
            }
            else
            {
                errChecker.SetError(txtIncidentLocation, null);
            }

            if (cmbSeverity.SelectedIndex == -1) //Validate severity
            {
                errChecker.SetError(cmbSeverity, "Please select the severity");
                cmbSeverity.Focus();
                return false;
            }
            else
            {
                errChecker.SetError(cmbSeverity, null);
            }

            if (peopleAffected < 1) // Validate number of affected people
            {
                errChecker.SetError(nudAffectedPeople, "Please enter the number of people affected");
                nudAffectedPeople.Focus();
            }
            else
            {
                errChecker.SetError(nudAffectedPeople, null);
            }

            if (string.IsNullOrEmpty(description)) // Validate description
            {
                errChecker.SetError(txtIncidentDescription, "Please enter a description of the incident");
                txtIncidentDescription.Focus();
                return false;
            }
            else
            {
                errChecker.SetError(txtIncidentDescription, null);
            }

            return true;
        }

        private void txtIncidenttionDescrip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
