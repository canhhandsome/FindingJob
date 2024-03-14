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

        public List<Job> FetchJob()  
        {
            List<Job> jobs = new List<Job>();
            string strFetch = string.Format("Select * From Job");
            conn.FetchHiringJob(strFetch, jobs);
            foreach (Job job in jobs)
            {
                job.FetchRequirement(FetchMulti(job.ID,"Requirement"));
                job.FetchDescription(FetchMulti(job.ID,"Description"));

                
            }
            return jobs;
        }

        public List<string> FetchMulti(string jobid, string type)
        {
            List<string> list = new List<string>();
            string strFetch = string.Format("Select * from J_{0} where jobid = '{1}'", type, jobid);
            conn.FetchMultiValueJob(strFetch, list, type);
            return list;
        }

    }
}
