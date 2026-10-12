using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplicationTracker.Classes
{
    public enum ApplicationStatus
    {
        Applied,
        Interview,
        Offer,
        Rejected
    }
    public class JobApplication
    {
        //Attributer :
        public string CompanyName { get; set; }

        public string PositionTitle { get; set; }

        public ApplicationStatus Status { get; set; } = ApplicationStatus.Applied; // Applied, Interview, Offer, Rejected

        public DateTime ApplicationDate { get; set; }
        
        public DateTime ResponseDate { get; set; } 

        public int SalaryExpectation { get; set; }

        //Metoder:
        public int GetDaysSinceApplied()
        {
            // Returnerar antal dagar sedan ansökan skickades.
            int daysSinceApplied = 0;
            daysSinceApplied = (DateTime.Now - ApplicationDate).Days;
            return daysSinceApplied;
        }

        public void GetSummary()
        {
            // Returnerar en kort sammanfattning av ansökan.
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("Position: " + PositionTitle);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Applied on: " + ApplicationDate.ToShortDateString());
            Console.WriteLine("Response on: " + ResponseDate.ToShortDateString());
            Console.WriteLine("Salary expectation" + SalaryExpectation);
        }

    }
}
