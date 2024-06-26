﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Interview
    {
        private string idJSeeker = string.Empty;
        private string idJob = string.Empty;
        private string timeInterview = string.Empty;
        private string status = string.Empty;   
        private string companyID = string.Empty;   
        private DateTime dateInterview = DateTime.MinValue;

        public Interview() { }

        public Interview(string idJSeeker, string idJob, string timeInterview, DateTime dateInterview, string companyID)
        {
            this.idJSeeker = idJSeeker;
            this.idJob = idJob;
            this.timeInterview = timeInterview;
            this.dateInterview = dateInterview;
            this.status = "waiting";
            this.companyID = companyID;
        }
        public Interview(string idJSeeker, string idJob, string timeInterview, string status, DateTime dateInterview, string companyID)
        {
            this.idJSeeker = idJSeeker;
            this.idJob = idJob;
            this.timeInterview = timeInterview;
            this.dateInterview = dateInterview;
            this.status = status;
            this.companyID = companyID;
        }

        public string IdJSeeker 
        { get {  return idJSeeker; } }

        public string IdJob 
        { get { return idJob; } }

        public string TimeInterview 
        { get {  return timeInterview; } }

        public string Status
        { get { return status; } }

        public DateTime DateInterview 
        { get { return dateInterview; } }

        public string CompanyID
        { get { return companyID; } }

    }
}
