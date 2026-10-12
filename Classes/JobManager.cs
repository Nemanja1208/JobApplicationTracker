using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplicationTracker.Classes
{
    public class JobManager
    {

        // Attributer
        List<JobApplication> jobs = new List<JobApplication>();

        // Metoder 
        //AddJob() – lägger till en ny ansökan
        public void AddJob(JobApplication job)
        {
            jobs.Add(job);
        }

        //UpdateStatus() – ändrar status på en befintlig ansökan
        public void UpdateStatus(int index, string newStatus)
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            jobs.ForEach(job => job.GetSummary());
        }
        //ShowByStatus() – filtrerar med LINQ efter status(VG del)
        //ShowStatistics() – visar statistik med LINQ(Count, Average, OrderBy, Where) (VG del)

    }
}
