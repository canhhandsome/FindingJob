using Syncfusion.XPS;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace WinFormProject
{
    public class JobDAO
    {
        DBConnection conn = new DBConnection();
        public JobDAO()
        {
        }
        public List<Job> FetchAvailableJobs()
        {
            List<Job> jobs = new List<Job>();

           
            string strFetch = string.Format("SELECT* FROM job WHERE status = 'waiting' ORDER BY datepublish DESC");
            conn.FetchHiringJob(strFetch, jobs);
            return jobs;
        }

        public List<Job> FetchCompanyJob(string companyid)  
        {
            List<Job> jobs = new List<Job>();
            string strFetch = string.Format("Select * From Job where companyid= '{0}'", companyid);
            conn.FetchHiringJob(strFetch, jobs);
            return jobs;
        }

        public string FetchName(string jobid)
        {
            string strFetch = string.Format("Select JobName From Job where jobid = '{0}'", jobid);
            return conn.FetchScalar(strFetch);
        }
        public string AddNewJob(Job job)
        {
            //string sqlUpdate = string.Format("INSERT INTO Job (companyid, jobname, position, salary, description, requirement, benefit, DateEnd) " +
            //                         "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
            //                         job.CompanyID, job.Name, job.Position, job.Salary, job.Description, job.Requirement, job.Benefit, job.DateEnd.ToString());
            return conn.GetTheJobID(job);
        }
        public void DoneJob(string jobid)
        {
            string SQL = string.Format("UPDATE JOB SET status = 'done', DateEnd = '{1}' WHERE jobid = '{0}'", jobid, DateTime.Now.ToString("yyyy-MM-dd"));
            conn.CRUD(SQL);
        }
        public void EditJob(Job job)
        {
            string sqlUpdate = string.Format("UPDATE Job SET jobname = '{0}', position = '{1}', salary = '{2}', description = '{3}', requirement = '{4}', benefit = '{5}', DateEnd = '{6:yyyy-MM-dd}', workingform = '{7}' WHERE jobid = '{8}'",
                                   job.Name, job.Position, job.Salary, job.Description, job.Requirement, job.Benefit, job.DateEnd, job.WorkingForm, job.Jobid);
            conn.CRUD(sqlUpdate);
        }
        //public int TotalWaitingJob()
        ////{
        ////    string SQL = string.Format("SELECT dbo.CountWaitingJobs() AS WaitingJobCount");
        ////    return conn.GetTotal(SQL);
        ////}

        public void FetchRelatedJob(string jobname, List<Job> relatedJobs,string jobid)
        {
            List<string> JobNameEach = JobNameLike(jobname);
            foreach(string name in JobNameEach)
            {
                string SQL = string.Format("SELECT * FROM Job WHERE Status = 'waiting' And Jobid != '{1}' AND JobName LIKE '%{0}%'", name,jobid);
                conn.FetchRelatedJob(SQL, relatedJobs);
            }
        }
        private static List<string> JobNameLike(string jobName)
        {
            // Split the job name into individual words
            string[] wordsArray = jobName.Split(' ');

            // Trim each word in the array
            for (int i = 0; i < wordsArray.Length; i++)
            {
                wordsArray[i] = wordsArray[i].Trim();
            }

            // Convert the array to a list
            List<string> wordsList = new List<string>(wordsArray);

            return wordsList;
        }


    }
}
