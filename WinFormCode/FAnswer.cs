using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class FAnswer : Form
    {
        Apply apply = new Apply();
        Job job = new Job();
        public FAnswer(Apply apply, Job job)
        {
            InitializeComponent();
            this.apply = apply;
            this.job = job;
            JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
            JobDAO jobDAO = new JobDAO();
            lblToT.Text = jobSeekerDAO.FetchName(apply.JSeekerID);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            AlertDAO dAO = new AlertDAO();
            Alert alert = new Alert(job.CompanyID, apply.JSeekerID, cbbSubject.Text, txtContent.Text, job.Jobid);
            ApplyDAO applyDAO = new ApplyDAO();
            applyDAO.UpdateStatus(cbbSubject.Text, apply);
            dAO.InsertAlert(alert);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbSubject.SelectedIndex == 0)
            {
                btnInterview.Visible = true;
            }
            else btnInterview .Visible = false;
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            FScheduleInterview fScheduleInterview = new FScheduleInterview(apply);
            fScheduleInterview.Show();
        }
    }
}
