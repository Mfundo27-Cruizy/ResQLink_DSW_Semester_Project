using System;
using System.Collections.Generic;
using System.Text;

namespace DSW_Semester_Project
{
    internal class Emergency_Incidents
    {
        public string ReferenceNumber { get; set; }
        public string EmergencyType { get; set; }
        public string Location { get; set; }
        public string Severity { get; set; }
        public int PeopleAffected { get; set; }
        public string Description { get; set; }
        public string Priority { get; private set; }
        public DateTime DateTimeReported { get; set; }
        public string Status { get; set; }

        public Emergency_Incidents(string emeregancyType, string location, string severity,
            int peopleAffected, string description)
        {
            ReferenceNumber = GenerateReferenceNumber();
            EmergencyType = emeregancyType;
            Location = location;
            Severity = severity;
            PeopleAffected = peopleAffected;
            Description = description;

            DateTimeReported = DateTime.Now;
            Status = "Reported";

            Priority = CalculatePriority();
        }

        private string GenerateReferenceNumber()
        {
            return "INC-" + DateTime.Now.ToString("yyyyMMddHHmmss"); // What does this part mean!
                                                                     //Get currecn date and Time and generate a reference number
        }

        public string CalculatePriority()
        {
            int score = 0;

            // Severity points
            if (Severity == "Low")
            {
                score += 1;
            }
            else if (Severity == "Medium")
            {
                score += 2;
            }
            else if (Severity == "High")
            {
                score += 3;
            }

            // People affected points
            if (PeopleAffected >= 10)
            {
                score += 3;
            }
            else if (PeopleAffected >= 5)
            {
                score += 2;
            }
            else if (PeopleAffected >= 1)
            {
                score += 1;
            }

            //Emergency type points
            if (EmergencyType == "Fire & Rescue Department")
            {
                score += 3;
            }
            else if (EmergencyType == "Search & Rescue Department")
            {
                score += 3;
            }
            else if (EmergencyType == "Security Department")
            {
                score += 1;
            }
            else if (EmergencyType == "Disaster Management")
            {
                score += 2;
            }
            else if (EmergencyType == "Medical/Emergency Services")
            {
                score += 2;
            }
            else
            {
                score += 1;
            }

            //Final Priorirty...
            if (score >= 7)
            {
                return "Critical";
            }
            else if (score >= 5)
            {
                return "High";
            }
            else if (score >= 3)
            {
                return "Medium";
            }
            else
            {
                return "Low";
            }
        }

        public string ToFileString()
        {
            return ReferenceNumber + " | " +
                EmergencyType + " | " +
                Location + " | " +
                Severity + " | " +
                PeopleAffected + " | " +
                Priority + " | " +
                DateTimeReported.ToString("yyyy-MM-dd HH:mm:ss") + " | " +
                Status + " | " +
                Description.Replace("|", "/");
        }
    }
}
