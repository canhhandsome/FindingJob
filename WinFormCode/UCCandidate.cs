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
    public partial class UCCandidate : UserControl
    {
        string companyid;
        JobPreference jobPreference = new JobPreference();
        public UCCandidate(JobPreference jobPreference,string companyid)
        {
            this.jobPreference = jobPreference;
            InitializeComponent();
            FillInformation();
            this.companyid = companyid;
        }
        private void FillInformation()
        {
            lblTitle.Text = jobPreference.Title;
            lblWorkingType.Text = jobPreference.WorkingForm;
            lblLocation.Text = jobPreference.Location;
            FillSkill();
            JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
            lblCandidateName.Text = jobSeekerDAO.FetchName(jobPreference.JobSeekerId);
            ptbCandidateAvatar.Image = jobSeekerDAO.FetchImg(jobPreference.JobSeekerId, "Avatar");


        }
        private void FillSkill()
        {
            foreach (string s in jobPreference.SkillList)
            {
                if (s != "NULL")
                {
                    BtnSkillShow btnSkillShow = new BtnSkillShow();
                    btnSkillShow.Text = s;
                    btnSkillShow.Enabled = false; // Disable button
                    flpSkills.Controls.Add(btnSkillShow);
                    flpSkills.Width += btnSkillShow.Width + 20;
                }
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FJobPreferenceView fJobPreferenceView = new FJobPreferenceView(jobPreference.JobSeekerId,companyid);
            fJobPreferenceView.Show();
        }
    }
}
