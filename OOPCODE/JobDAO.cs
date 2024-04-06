using Syncfusion.XPS;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class JobDAO
    {
        DBConnection conn = new DBConnection();

        public JobDAO() 
        {
            
        }

        public List<Job> FetchAvailableJobs(int limit,int offset)
        {
            List<Job> jobs = new List<Job>();
            string strFetch = string.Format("SELECT * FROM job ORDER BY jobid OFFSET {0} ROWS FETCH NEXT {1} ROWS ONLY", offset, limit);
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
        public int TotalWaitingJob()
        {
            string SQL = string.Format("SELECT dbo.CountWaitingJobs() AS WaitingJobCount");
            return conn.GetTotal(SQL);
        }

    }
}
