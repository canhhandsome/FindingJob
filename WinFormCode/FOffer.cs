using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;

namespace WinFormProject.WinFormCode
{
    public partial class FOffer : Form
    {
        JobPreference jobPreference;
        string companyid = string.Empty;
        JobSeekerDAO jsdao = new JobSeekerDAO();
        JobOfferDAO jobOfferDAO = new JobOfferDAO();
        CompanySendOfferDAO companySendOfferDAO = new CompanySendOfferDAO();
        public FOffer(string companyid, JobPreference jobPreference)
        {
            InitializeComponent();
            this.companyid = companyid;
            this.jobPreference = jobPreference;
            FillInfor();
        }
        private void FillInfor()
        {
            cbbSubject.Text = "Approve";
            cbbSubject.Enabled = false;
            lblTo.Text = jsdao.FetchName(jobPreference.JobSeekerId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSubject.SelectedIndex == 0)
            {
                btnInterview.Visible = true;
            }
            else btnInterview.Visible = false;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            JobOffer jobOffer = new JobOffer(companyid,jobPreference.JobSeekerId, cbbSubject.Text, txtContent.Text);
            jobOfferDAO.InsertOffer(jobOffer);
            CompanySendOffer companySendOffer = new CompanySendOffer(companyid,jobPreference.JobSeekerId);
            companySendOfferDAO.Insert(companySendOffer);
            this.Close();
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            FScheduleInterview fScheduleInterview = new FScheduleInterview(jobPreference, companyid);
            fScheduleInterview.Show();
        }
    }
}
