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
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class UCInformation : UserControl
    {
        public event EventHandler<string> SkillButtonClicked;
        private Job job = new Job();
        CompanyDAO companyDAO = new CompanyDAO();
        string jsID = string.Empty;
        Company company;
        public UCInformation(Job job, string jsID)
        {
            InitializeComponent();
            this.jsID = jsID;
            this.job = job;
            company = companyDAO.FetchCompanyInformationBasedOnID(job.CompanyID);
            FillInTemplate();
        }
        public void FillInTemplate()
        {
            lblCompany.Text = companyDAO.FetchName(job.CompanyID);
            lblDatePuslish.Text = $"Posted {PublishTime()}";
            lblNameJob.Text = job.Name;
            lblAddress.Text = company.INFO.Address;
            lblWorkingType.Text = job.WorkingForm;
            if (company.Avatar != null) ptbCompanyPicture.Image = company.Avatar;
            foreach (string s in job.SkillList)
            {
                if (s != "NULL")
                {
                    BtnSkillShow btnkillshow = new BtnSkillShow();
                    btnkillshow.Click += BtnSkill_Click;
                    btnkillshow.Text = s;
                    btnkillshow.Show();
                    flpSkills.Width += btnkillshow.Width + 10;
                    flpSkills.Controls.Add(btnkillshow);
                }
            }
        }

        private string PublishTime()
        {
            TimeSpan timeDifference = DateTime.Now - job.DatePublish;

            if (timeDifference.TotalMinutes < 1)
            {
                return "Just now";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{(int)timeDifference.TotalMinutes} minute(s) ago";
            }
            else if (timeDifference.TotalHours < 24)
            {
                return $"{(int)timeDifference.TotalHours} hour(s) ago";
            }
            else
            {
                return $"{(int)timeDifference.TotalDays} day(s) ago";
            }
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            FJobDetails jobDetails = new FJobDetails(job, jsID);
            jobDetails.Show();
        }
        private void BtnSkill_Click(object sender, EventArgs e)
        {
            // When a skill button is clicked, raise the event and pass the skill text
            if (sender is BtnSkillShow btnSkill)
            {
                string skillText = btnSkill.Text;
                SkillButtonClicked?.Invoke(this, skillText);
            }
        }

    }
}

