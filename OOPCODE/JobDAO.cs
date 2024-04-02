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

        public List<Job> FetchAvailableJobs()
        {
            List<Job> jobs = new List<Job>();
            string strFetch = string.Format("Select * from job");
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
        public void AddNewJob(string companyid, string jobname, string position, string salary, string requirement, string description, string DateEnd)
        {
            string sqlUpdate = string.Format("INSERT INTO Job (companyid, jobname, position, salary, description, requirement, DateEnd) " +
                                     "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                                     companyid, jobname, position, salary, description, requirement, DateEnd);
            conn.CRUD(sqlUpdate);
        }
        public void DeleteJob(string jobid)
        {
            string SQL = string.Format("DELETE FROM JOB WHERE jobid = '{0}'", jobid);
            conn.CRUD(SQL);
        }
        public void EditJob(Job job)
        {
            string sqlUpdate = string.Format("UPDATE Job SET  jobname = '{0}', position = '{1}', salary = '{2}', description = '{3}', requirement = '{4}' WHERE jobid = '{5}'",
                                             job.CompanyID, job.Name, job.Position, job.Salary, job.Description, job.Requirement, job.Jobid);
            conn.CRUD(sqlUpdate);
        }

    }
}
