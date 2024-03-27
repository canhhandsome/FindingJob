using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Job
    {
        string jobid, companyid, jobname ,position, salary, requirement,description;
        DateTime datapublish;
        JobDAO jobDAO = new JobDAO();
        public Job()
        {

        }
        public Job(string jobid,string companyid,string jobname,string position,string salary, string requirement,string description,DateTime datapublish)
        {
            this.jobid = jobid;
            this.jobname = jobname;
            this.companyid = companyid;
            this.position = position;
            this.salary = salary;
            this.requirement = requirement;
            this.description = description;
            this.datapublish = datapublish;

        }
        public string Jobid
        {
            get { return jobid; }
        }
        public string Name
        {
            get { return jobname; }
        }
        public DateTime DatePublish
        {
            get { return datapublish; }
        }
        public string CompanyID
        {
            get { return companyid; }
        }
        public string Salary
        {
            get { return salary; }
        }
        public string Requirement
        { 
            get { return requirement; } 
        }
        public string Description
        {
            get { return description; }
        }

        public string Position
        {
            get { return position; }
        }

    }
}
