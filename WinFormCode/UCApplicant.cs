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
        byte[] applicantAvatar = new byte[0];
        public UCApplicant(Apply apply, Job job)
        {
            InitializeComponent();
            this.apply = apply;
            this.job = job;
            this.MaximumSize = new System.Drawing.Size(950, 234);
            FillInTemplate();
            PanelUtils.MakeRounded(this.panel1, 15);
        }
        public void FillInTemplate()
        {
            lblApplicantNameT.Text = jsDAO.FetchName(apply.JSeekerID);
            lblEmailT.Text = jobDAO.FetchName(apply.JobID);
            lblDateT.Text = apply.DATE.ToString("dd/MM/yyyy");
            applicantAvatar = jsDAO.FetchImg(apply.JSeekerID);
            ImageHandler.DisplayImage(applicantAvatar, ref ptbApplicantPicture);
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            InformationDAO informationDAO = new InformationDAO();
            FCV fcv = new FCV(new JobSeeker(informationDAO.GetCommonByID(apply.JSeekerID, "JobSeeker")));
            fcv.Show();
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            ReaLTaiizor.Controls.CyberButton button = (ReaLTaiizor.Controls.CyberButton)sender;
            ApplyDAO applyDao = new ApplyDAO();
            applyDao.UpdateStatus(button.TextButton, apply);
            FAnswer fAnswer = new FAnswer(apply, job);
            fAnswer.Show();
        }

        private void lblEmailT_Click(object sender, EventArgs e)
        {

        }
    }
}
