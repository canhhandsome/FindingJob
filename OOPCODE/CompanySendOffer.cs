using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class CompanySendOffer
    {
        public string companyid, jobseekerid;
        public CompanySendOffer(string companyid, string jobseekerid)
        {
            this.companyid = companyid;
            this.jobseekerid = jobseekerid;
        }
        string CompanyID
        {
            get { return companyid; }
        }
        string JobSeekerID
        {
            get { return jobseekerid; }
        }
        
    }
}
