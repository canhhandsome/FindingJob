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
        Information information = new Information();
        JobDAO jobDao = new JobDAO();
        List<Job> jobs = new List<Job>();
        public Company()
        {

        }
        public Company(Information information)
        {
            this.information  = information;
            List<string> otherinfo = companyDAO.FetchInformation(this);
            companysize = otherinfo[1];
            companytype = otherinfo[0];
            jobs = jobDao.FetchAllJob(this.INFO.ID);
        }
        public List<Job> Jobs
        {
            get { return jobs; }
        }
        public Information INFO
        {
            get { return information; }
        }
    }
}
