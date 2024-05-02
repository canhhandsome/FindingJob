using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class CompanyLikeCV
    {
        string companyid = string.Empty;
        string jobseekerid = string.Empty;
        public CompanyLikeCV()
        {

        }
        public string CompanyId
        {
            get { return companyid; }
            set { companyid = value; }
        }

        public string JobseekerId
        {
            get { return jobseekerid; }
            set { jobseekerid = value; }
        }
    }
}
