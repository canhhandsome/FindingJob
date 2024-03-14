using System;
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
            return jobs;
        }
    }
}
