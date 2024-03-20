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
    public partial class UCApplicant : UserControl
    {
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        JobDAO jobDAO = new JobDAO();
        Apply apply = new Apply();
        Company company = new Company();
        public UCApplicant(Apply apply, Company company)
        {
            InitializeComponent();
            this.apply = apply;
            this.company = company;
            this.MaximumSize = new System.Drawing.Size(950, 234);
            lblApplicantNameT.Text = jsDAO.FetchName(apply.JSeekerID);
            lblJobT.Text = jobDAO.FetchName(apply.JobID);
            lblDateT.Text = apply.DATE.ToString("dd/MM/yyyy");

            btnApprove.Click += btnAnswer_Click;
            btnDecline.Click += btnAnswer_Click;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            InformationDAO informationDAO = new InformationDAO();
            FProfile fProfile = new FProfile(new JobSeeker(informationDAO.GetCommonByID(apply.JSeekerID, "JobSeeker")));
            foreach (Control control in fProfile.Controls)
            {
                if (control == fProfile.btnEdit)
                {
                    control.Visible = false;
                }
                else if (control == fProfile.btnCV)
                    continue;
                control.Enabled = false;
            }
            fProfile.Show();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ApplyDAO applyDao = new ApplyDAO();
            applyDao.UpdateStatus(button.Text, apply);
            FAnswer fAnswer = new FAnswer(apply, company);
            fAnswer.Show();
        }
    }
}
