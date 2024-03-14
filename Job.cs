using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Job
    {
        string jobid, jobname, position, salary;
        DateTime datapublish;
        List<string> descriptions = new List<string>();
        List<string> requirements = new List<string>();
        JobDAO JobDAO = new JobDAO();

        public Job(string jobid)
        {
            this.jobid = jobid;

        }

        public Job(string jobid, string jobname, string position, string salary, DateTime datapublish, List<string> descriptions, List<string> requirements)
        {
            this.jobid = jobid;
            this.jobname = jobname;
            this.position = position;
            this.salary = salary;
            this.datapublish = datapublish;
            this.descriptions = descriptions;
            this.requirements = requirements;
        }
        public Job(string jobid, string jobname, string position, string salary, DateTime datapublish)
        {
            this.jobid = jobid;
            this.jobname = jobname;
            this.position = position;
            this.salary = salary;
            this.datapublish = datapublish;
        }

    }
}
