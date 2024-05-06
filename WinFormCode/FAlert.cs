﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;

namespace WinFormProject
{
    public partial class FAlert : Form
    {
        public Job job = new Job();
        List<Alert> alerts = new List<Alert>();
        List<JobOffer> jobOffers = new List<JobOffer>();
        JobSeeker seeker = new JobSeeker();
        public FAlert(JobSeeker jobSeeker)
        {
            InitializeComponent();
            seeker = jobSeeker;
            AlertDAO alertDAO = new AlertDAO();
            this.alerts = alertDAO.FetchAlert(jobSeeker.INFO.ID);
            JobOfferDAO jobOfferDAO = new JobOfferDAO();
            this.jobOffers = jobOfferDAO.FetchOffers(jobSeeker.INFO.ID);
            FillInformation();
            
        }
        public void FillInformation()
        {
            foreach (Alert alert in alerts)
            {
                UCAlert uCAlert = new UCAlert(alert);
                flpAlert.Controls.Add(uCAlert);
                flpAlert.Height += 255;
            }
            foreach (JobOffer offer in jobOffers)
            {
                UCAlert uCAlert = new UCAlert(offer);
                flpAlert.Controls.Add(uCAlert);
                flpAlert.Height += 255;
            }
        }

    }
}
