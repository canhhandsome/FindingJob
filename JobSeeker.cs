using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class JobSeeker
    {
        Information information = new Information();
        private DateTime bdate = new DateTime();
        private string nationalid = string.Empty;
        private string gender = string.Empty;

        public JobSeeker()
        {
            
        }
        public JobSeeker (Information information)
        {
            this.information = information;    
        }
        public JobSeeker (Information information, DateTime bdate, string nationalid, string gender)
        {
            this.information = information;
            this.bdate = bdate;
            this.nationalid = nationalid;
            this.gender = gender;
        }

        public Information INFO 
        { 
            get { return information; } 
        }

    }
}
