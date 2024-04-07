using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class UCApplicant : UserControl
    {
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        JobDAO jobDAO = new JobDAO();
        Apply apply = new Apply();
        Job job = new Job();
        Image applicantAvatar = null;
        public UCApplicant(Apply apply, Job job)
        {
            InitializeComponent();
            this.apply = apply;
            this.job = job;
            this.MaximumSize = new System.Drawing.Size(469, 515);
            FillInTemplate();
        }
        public void FillInTemplate()
        {
            lblApplicantNameT.Text = jsDAO.FetchName(apply.JSeekerID);
            lblEmailT.Text = jobDAO.FetchName(apply.JobID);
            lblDateT.Text = "Apply at " + apply.DATE.ToString("dd/MM/yyyy");
            applicantAvatar = jsDAO.FetchImg(apply.JSeekerID, "Avatar");
            if (applicantAvatar != null) ptbApplicantPicture.Image = applicantAvatar;
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            InformationDAO informationDAO = new InformationDAO();
            FCV fcv = new FCV(new JobSeeker(informationDAO.GetCommonByID(apply.JSeekerID, "JobSeeker")));
            fcv.Show();
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            ApplyDAO applyDao = new ApplyDAO();
            applyDao.UpdateStatus(button.Text, apply);
            FAnswer fAnswer = new FAnswer(apply, job);
            fAnswer.Show();
        }
    }
}
