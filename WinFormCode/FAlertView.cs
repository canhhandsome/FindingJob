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
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class FAlertView : Form
    {
        private Alert alert = new Alert();
        private JobOffer JobOffer = new JobOffer();
        public FAlertView(Alert alert)
        {
            InitializeComponent();
            this.alert = alert;
            CompanyDAO companyDAO = new CompanyDAO();
            JobDAO jobDAO = new JobDAO();
            llFromT.Text = companyDAO.FetchName(alert.SenderID);
            lblContentT.Text = alert.Content;
            lblDateT.Text = alert.DateReply.ToString("dd/MM/yyyy");
            lblSubjectT.Text = alert.Subject;
            lblJobT.Text = jobDAO.FetchName(alert.JobID);
            CheckStatus();
        }
        public FAlertView(JobOffer jobOffer)
        {
            InitializeComponent();
            this.JobOffer = jobOffer;
            CompanyDAO companyDAO = new CompanyDAO();
            JobDAO jobDAO = new JobDAO();
            llFromT.Text = companyDAO.FetchName(JobOffer.SenderID);
            lblContentT.Text = JobOffer.Content;
            lblDateT.Text = jobOffer.DateReply.ToString("dd/MM/yyyy");
            lblSubjectT.Text = jobOffer.Subject;
            lblJobT.Text = "JOB OFFER!!";
            CheckStatus();
        }

        private void CheckStatus()
        {
            if (lblSubjectT.Text.ToLower() == "approve" || lblSubjectT.Text.ToLower() == "Offering")
            {
                
                btnInterview.Visible = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            FInterview fInterview;
            if(lblJobT.Text == "JOB OFFER!!")
            {
                fInterview = new FInterview(JobOffer.RecipientID, "");
            } else fInterview = new FInterview(alert.RecipientID, alert.JobID);
            fInterview.Show();
        }
    }
}
