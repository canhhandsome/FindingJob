using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Company: Information
    {
        string companytype, companysize;
        CompanyDAO companyDAO = new CompanyDAO();
        List<Job> jobs = new List<Job>();
        public Company(Account account) : base(account)
        {
            
        }
    }
}
