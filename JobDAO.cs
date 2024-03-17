using System;
using System.CodeDom;
using System.Collections.Generic;
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
        public void AddNewJob(string companyid, string jobname, string position, string salary, string requirement, string description, DateTime datapublish)
        {
            string sqlUpdate = string.Format("INSERT INTO Job (jobid, companyid, jobname,position,salary, datepublish,description,requirement) Values ((SUBSTRING(CONVERT(VARCHAR(36), NEWID()), 1, 8), '{0}','{}','{3}','{4}','{5}','{6}')", companyid,jobname,position,salary,datapublish,description,requirement);
            conn.CRUD(sqlUpdate);
        }
        public void DeleteJob(string jobid)
        {
            string SQL = string.Format("DELETE FROM JOB WHERE jobid = '{0}'", jobid);
            conn.CRUD(SQL);
        }
    }
}
