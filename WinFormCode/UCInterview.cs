using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject.WinFormCode
{
    public partial class UCInterview : UserControl
    {
        Interview interview = new Interview();
        public UCInterview(Interview interview)
        {
            InitializeComponent();
            this.interview = interview;
            FillInfor();
        }

        private void FillInfor()
        {
            JobSeekerDAO jsDAO = new JobSeekerDAO();
            lblJSeeker.Text = jsDAO.FetchName(interview.IdJSeeker);
            JobDAO jobDAO = new JobDAO();
            lblJob.Text = jobDAO.FetchName(interview.IdJob);
            if (lblJob.Text == "") lblJob.Text = "Job Offer!";
            ptbAvatar.Image = jsDAO.FetchImg(interview.IdJSeeker, "Avatar");

            lblTime.Text = interview.TimeInterview;
            lblTimeAdd.Text = interview.DateInterview.ToString("dd/MM/yyyy");
            lblStatus.Text = interview.Status;
        }

        private void lblJob_Click(object sender, EventArgs e)
        {

        }
    }
}
