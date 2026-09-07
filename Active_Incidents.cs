using System;
using System.Collections.Generic;
using System.Text;

namespace DSW_Semester_Project
{
    internal class Active_Incidents
    {
        public string referenceNumber { get; set; }
        public int incidentNumber { get; set; }
        public string emergencyType { get; set; }
        public string location { get; set; }
        public string severity { get; set; }
        public string priority { get; set; }
        public int affectedPeople { get; set; }
        public DateTime dateReported { get; set; }
        public string status { get; set; }
        public string description { get; set; }

        public Active_Incidents(string referencenumber, int incidentNumber, string emergencyType, string location, string severity,string priority, int affectedPeople, DateTime dateReported, string status, string description)
        {
            this.referenceNumber = referencenumber;
            this.incidentNumber = incidentNumber;
            this.emergencyType = emergencyType;
            this.location = location;
            this.severity = severity;
            this.priority = priority;
            this.affectedPeople = affectedPeople;
            this.dateReported = dateReported;
            this.status = status;
            this.description = description;
        }
    }
}
