using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Company
    {
        string companytype, companysize;
        CompanyDAO companyDAO = new CompanyDAO();
        JobDAO jobDao = new JobDAO();
        ApplyDAO applyDAO = new ApplyDAO();
        Information information = new Information();
        List<Job> jobs = new List<Job>();
        List<Apply> applies = new List<Apply>();
        byte[] AvatarData;
        public Company()
        {

        }
        public Company(Information information)
        {
            this.information  = information;
            List<string> otherinfo = companyDAO.FetchInformation(this);
            companysize = otherinfo[1];
            companytype = otherinfo[0];
            jobs = jobDao.FetchCompanyJob(this.INFO.ID);
            foreach (Job job in jobs)
            {
                foreach(Apply apply in applyDAO.AllApplies(job.Jobid))
                {
                    applies.Add(apply);
                }
            }
            AvatarData = companyDAO.FetchImg(this.INFO.ID);
        }

        public List<Job> Jobs
        {
            get { return jobs; }
        }
        public Information INFO
        {
            get { return information; }
        }
        public List<Apply> Applies 
        { 
            get { return applies; } 
        }
    }
}
