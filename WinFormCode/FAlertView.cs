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
        private CompanySendOfferDAO companySendOfferDAO = new CompanySendOfferDAO();
        private InterviewDAO interviewDAO = new InterviewDAO();
        private JobOfferDAO jobOfferDAO = new JobOfferDAO();
        private string jsID;
        private string companyID;
        private string jobID; 
        public FAlertView(Alert alert)
        {
            InitializeComponent();
            this.alert = alert;
            jsID = alert.RecipientID;
            companyID = alert.SenderID;
            jobID = alert.JobID;
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
            jsID = jobOffer.RecipientID;
            companyID = jobOffer.SenderID;
            jobID = "";
            StartUp(jobOffer);
        }
        private void StartUp(JobOffer jobOffer)
        {
            CompanyDAO companyDAO = new CompanyDAO();
            JobDAO jobDAO = new JobDAO();
            llFromT.Text = companyDAO.FetchName(JobOffer.SenderID);
            lblContentT.Text = JobOffer.Content;
            lblDateT.Text = jobOffer.DateReply.ToString("dd/MM/yyyy");
            lblSubjectT.Text = jobOffer.Subject;
            lblJobT.Text = "JOB OFFER!!";
            CheckStatus();
            EnableButton(jobOffer.Status);
        }
        private void EnableButton(string status)
        {
            if (status.Trim() == "Offering")
            {
                btnAccept.Visible = true;
                btnReject.Visible = true;
                lblResponse.Visible = true;
                lblResponseT.Visible = true;
                lblResponseT.Text = "You have not reponsed yet!";
            }
            if (status.Trim() == "Accepted")
            {
                lblResponse.Visible = true;
                lblResponseT.Visible = true;
                lblResponseT.Text = "You have accepted this deal!";
            }
            if (status.Trim() == "Rejected")
            {
                lblResponse.Visible = true;
                lblResponseT.Visible = true;
                lblResponseT.Text = "You have rejected this deal";
            }
        }
        private void CheckStatus()
        {
            if (lblSubjectT.Text.ToLower() != "decline" || lblSubjectT.Text.ToLower() != "rejected")
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
            fInterview = new FInterview(jsID, companyID, jobID);
            fInterview.Show();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            jobOfferDAO.OfferAccepted(JobOffer.SenderID,JobOffer.RecipientID);
            companySendOfferDAO.OfferAccepted(JobOffer.SenderID, JobOffer.RecipientID);
            interviewDAO.SetStatusForInterview(JobOffer.RecipientID,"","Accepted", JobOffer.SenderID);
            this.JobOffer.Status = "Accepted";
            StartUp(this.JobOffer);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            jobOfferDAO.OfferRejected(JobOffer.SenderID, JobOffer.RecipientID);
            companySendOfferDAO.OfferRejected(JobOffer.SenderID, JobOffer.RecipientID);
            interviewDAO.SetStatusForInterview(JobOffer.RecipientID, "", "Rejected", JobOffer.SenderID);
            this.JobOffer.Status = "Rejected";
            this.btnAccept.Visible = false;
            this.btnReject.Visible = false;
            StartUp(this.JobOffer);
        }
    }
}
