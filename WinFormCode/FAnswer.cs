using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Alert alert = new Alert(job.CompanyID, apply.JSeekerID, txtSubject.Text, txtContent.Text, job.Jobid);
            dAO.InsertAlert(alert);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ApplyDAO applyDAO = new ApplyDAO();
            applyDAO.UpdateStatus("Waiting", apply);
            this.Close();
        }
    }
}
