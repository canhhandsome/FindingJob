using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class JobPreference
    {
        string jobseekerid, title, position,companytype,workingform,companyzie,location;
        int salary;
        DateTime deadline;
        List<string> skilllist;
        public JobPreference()
        {
            // Initialize default values or perform other initialization logic here
            jobseekerid = "";
            title = "";
            position = "";
            companytype = "";
            workingform = "";
            companyzie = "";
            location = "";
            salary = 0;
            deadline = DateTime.MinValue;
            skilllist = new List<string>();
        }
        public JobPreference(string jobseekerid)
        {
            this.jobseekerid = jobseekerid;
            skilllist = new List<string>();
        }
        public string JobSeekerId
        {
            get { return jobseekerid; }
            set { jobseekerid = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string CompanyType
        {
            get { return companytype; }
            set { companytype = value; }
        }

        public string WorkingForm
        {
            get { return workingform; }
            set { workingform = value; }
        }

        public string CompanySize
        {
            get { return companyzie; }
            set { companyzie = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        public List<string> SkillList
        {
            get { return skilllist; }
            set { skilllist = value; }
        }

    }
}
