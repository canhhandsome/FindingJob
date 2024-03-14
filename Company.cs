using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Company
    {
        Information information = new Information();
        string companytype, companysize;
        CompanyDAO companyDAO = new CompanyDAO();
        List<Job> jobs = new List<Job>();
        public Company()
        {

        }
        public Company(Information information)
        {
            this.information  = information;
        }
        public Company(Information information, string companytype, string companysize, CompanyDAO companyDAO, List<Job> jobs) : this(information)
        {
            this.companytype = companytype;
            this.companysize = companysize;
            this.companyDAO = companyDAO;
            this.jobs = jobs;
        }
        public Information INFO
        {
            get { return information; }
        }
    }
}
