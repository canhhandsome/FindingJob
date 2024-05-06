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
using WinFormProject.OOPCODE;
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class UCApplicant : UserControl
    {
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        JobDAO jobDAO = new JobDAO();
        Apply apply = new Apply();
        Job job = new Job();
        InformationDAO info = new InformationDAO();
        Image applicantAvatar = null;
        public UCApplicant(Apply apply, Job job)
        {
            InitializeComponent();
            this.apply = apply;
            this.job = job;
            this.MaximumSize = new System.Drawing.Size(469, 543);
            FillInfor();
        }
        public void FillInfor()
        {
            lblApplicantNameT.Text = jsDAO.FetchName(apply.JSeekerID);
            lblDateT.Text = "Apply at " + apply.DATE.ToString("dd/MM/yyyy");
            applicantAvatar = jsDAO.FetchImg(apply.JSeekerID, "Avatar");
            if (applicantAvatar != null) ptbApplicantPicture.Image = applicantAvatar;
            lblEmailT.Text = info.GetCommonByID(apply.JSeekerID, "JobSeeker").Email;
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            InformationDAO informationDAO = new InformationDAO();
            CVDao cVDao = new CVDao();
            //FCV fcv = new FCV(new JobSeeker(informationDAO.GetCommonByID(apply.JSeekerID, "JobSeeker")));
            CV cv = new CV();
            cVDao.FetchAllInformationOfCV(apply.JSeekerID, cv);
            FCompanyCVView fCompanyCVView = new FCompanyCVView(cv,job.CompanyID);
            fCompanyCVView.Show();
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            ApplyDAO applyDao = new ApplyDAO();
            FAnswer fAnswer = new FAnswer(apply, job);
            fAnswer.Show();
        }

    }
}
