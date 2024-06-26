﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Job
    {
        string jobid, companyid, jobname ,position, salary, requirement, description, benefit, status,workingform;
        DateTime datapublish, dateend;
        List<string> skilllist = new List<string>();
        public Job()
        {

        }
        public Job(string jobid,string companyid,string jobname,string position,string salary, string requirement,string description, string benefit,DateTime datapublish, DateTime dateend, string status,string workingform, List<string> skilllist)
        {
            this.jobid = jobid;
            this.jobname = jobname;
            this.companyid = companyid;
            this.position = position;
            this.salary = salary;
            this.requirement = requirement;
            this.description = description;
            this.benefit = benefit;
            this.datapublish = datapublish;
            this.dateend = dateend;
            this.status = status;
            this.workingform = workingform;
            this.skilllist = skilllist;
        }
        public Job(string companyid, string jobname, string position, string salary, string requirement, string description, string benefit, string workingform, DateTime dateend)
        {
            this.companyid = companyid;
            this.jobname = jobname;
            this.position = position;
            this.salary = salary;
            this.requirement = requirement;
            this.description = description;
            this.benefit = benefit;
            this.workingform = workingform;
            this.dateend = dateend;
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

        public string Benefit
        { 
            get { return benefit; } 
        }

        public DateTime DateEnd
        {
            get { return dateend; }
        }

        public string Status
        { 
            get { return status; } 
        }
        public string WorkingForm
        {
            get { return workingform; }
        }
        public List<string> SkillList { get { return skilllist; } }
    }
}
