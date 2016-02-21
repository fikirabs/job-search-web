using System;
using System.Text;
using System.Net;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace practicingjason
{
    public class Class1
    {
        public static void Main(string[] args)
        {

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://data.usajobs.gov/api/jobs?Country=USA");
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
         //   sr.Close();
           // myResponse.Close();
            //file.Close();

            //   4.Next step, store the jobs data into rawDB
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO JobData (DocumentID, JobTitle, OrganizationName, AgencySubElement,SalaryMin,SalaryMax,SalaryBasis, StartDate,EndDate, WhoMayApplyText,PayPlan,Series,Grade, WorkSchedule,WorkType, AnnouncementNumber,Locations,  JobSummary,ApplyOnlineURL)");
    VALUES (DocumentID, JobTitle, OrganizationName, AgencySubElement, SalaryMin, SalaryMax, SalaryBasis, StartDate, EndDate, 
        WhoMayApplyText, PayPlan, Series, Grade, WorkSchedule, WorkType, AnnouncementNumber, Locations, JobSummary, ApplyOnlineURL);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@DocumentID", jobData.DocumentID);
            cmd.Parameters.AddWithValue("@JobTitle", jobData.JobTitle);
            cmd.Parameters.AddWithValue("@OrganizationName", jobData.OrganizationName);
            cmd.Parameters.AddWithValue("@AgencySubElement", jobData.AgencySubElement);
            cmd.Parameters.AddWithValue("@SalaryMin", jobData.SalaryMin);
            cmd.Parameters.AddWithValue("@SalaryMax", jobData.SalaryMax);
            cmd.Parameters.AddWithValue("@SalaryBasis", jobData.SalaryBasis);
            cmd.Parameters.AddWithValue("@EndDate", jobData.EndDate);
            cmd.Parameters.AddWithValue("@WhoMayApplyText", jobData.WhoMayApplyText);
            cmd.Parameters.AddWithValue("@PayPlan", jobData.PayPlan);
            cmd.Parameters.AddWithValue("@Series", jobData.Series);
            cmd.Parameters.AddWithValue("@Grade", jobData.Grade);
            cmd.Parameters.AddWithValue("@WorkSchedule", jobData.WorkSchedule);
            cmd.Parameters.AddWithValue("@WorkType", jobData.WorkType);
            cmd.Parameters.AddWithValue("@AnnouncementNumber", jobData.AnnouncementNumber);
            cmd.Parameters.AddWithValue("@Locations", jobData.Locations);
            cmd.Parameters.AddWithValue("@JobSummary", jobData.JobSummary);
            cmd.Parameters.AddWithValue("@ApplyOnlineURL", jobData.ApplyOnlineURL);
            connection.Open();
            cmd.ExecuteNonQuery();
        
    }


}
        // Entity model for json deserialization (parsing)
        public class Jobs
        {
            public int TotalJobs { get; set; }

            public List<JobData> JobData { get; set; }
        }
        public class JobData
        {
            public int DocumentID { get; set; }
            public string JobTitle { get; set; }
            public string OrganizationName { get; set; }
            public string AgencySubElement { get; set; }
            public string SalaryMin { get; set; }
            public string SalaryMax { get; set; }
            public string SalaryBasis { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string WhoMayApplyText { get; set; }
            public string PayPlan { get; set; }
            public string Series { get; set; }
            public string Grade { get; set; }
            public string WorkSchedule { get; set; }
            public string WorkType { get; set; }
            public string Locations { get; set; }
            public string AnnouncementNumber { get; set; }
            public string JobSummary { get; set; }
            public string ApplyOnlineURL { get; set; }

        public static string Header()
        {
            return string.Format("{0}\t{1}\t{2}\t{3\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}\t{18}\t{19}")
                   ( "DocumentID", "JobTitle", "OrganizationName",
                    "AgencySubElement", "SalaryMin", "SalaryMax", "SalaryBasis", "StartDate", "EndDate",
                    "WhoMayApplyText", "PayPlan", "Series", "Grade", "WorkSchedule", "WorkType", "Locations", "AnnouncementNumber", "JobSummary","ApplyOnlineURL");
            
            }
            public override string ToString()
            {
                return string.Format("{0}\t{1}\t{2}\t{3\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}\t{18}\t{19}")
                   ("DocumentID", "JobTitle", "OrganizationName",
                    "AgencySubElement", "SalaryMin", "SalaryMax", "SalaryBasis", "StartDate", "EndDate",
                    "WhoMayApplyText", "PayPlan", "Series", "Grade", "WorkSchedule", "WorkType", "Locations", "AnnouncementNumber", "JobSummary",
                    "ApplyOnlineURL");
        }
    }
}
