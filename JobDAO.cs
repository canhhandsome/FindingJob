using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        public List<Job> FetchJobs()
        {
            List<Job> jobs = new List<Job>();
            string strFetch = string.Format("Select * from job");
            conn.FetchHiringJob(strFetch, jobs);
            return jobs;
        }

        public List<Job> FetchAllJob(string companyid)  
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
        public void AddNewJob(string companyid, string jobname, string position, string salary, string requirement, string description, DateTime datapublish)
        {
            string sqlUpdate = string.Format("INSERT INTO Job (jobid, companyid, jobname, position, salary, datepublish, description, requirement) " +
                                     "VALUES (SUBSTRING(CONVERT(VARCHAR(4), NEWID()), 1, 8),'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                     companyid, jobname, position, salary, datapublish.ToString("yyyy-MM-dd"), description, requirement);
            conn.CRUD(sqlUpdate);
        }
        public void DeleteJob(string jobid)
        {
            string SQL = string.Format("DELETE FROM JOB WHERE jobid = '{0}'", jobid);
            conn.CRUD(SQL);
        }
        public void EditJob(Job job)
        {
            Job job1 = new Job();
            string sqlUpdate = string.Format("UPDATE Job SET companyid = '{0}', jobname = '{1}', position = '{2}', salary = '{3}', datepublish = '{4}', description = '{5}', requirement = '{6}' WHERE jobid = '{7}'",
                                             job.CompanyID, job.Name, job.Position, job.Salary, job.DatePublish.ToString("yyyy-MM-dd"), job.Description, job.Requirement, job.Jobid);
            conn.CRUD(sqlUpdate);
        }

    }
}
