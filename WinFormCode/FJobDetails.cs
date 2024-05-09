using Syncfusion.Pdf.ColorSpace;
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
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class FJobDetails : Form
    {
        string jsID;
        Job job;
        JobDAO jobDAO = new JobDAO();
        Company company;
        ApplyDAO applyDAO = new ApplyDAO();
        CompanyAddtionalImageDAO cadi = new CompanyAddtionalImageDAO();
        CompanyDAO companyDAO = new CompanyDAO();
        List<Job> relatedJobs = new List<Job>();
        int limit, offset, totalwaitingjob;
        public FJobDetails(Job job, string jsID)
        {
            InitializeComponent();
            this.job = job;
            this.jsID = jsID;
            company = companyDAO.FetchCompanyInformationBasedOnID(job.CompanyID);
            jobDAO.FetchRelatedJob(this.job.Name, this.relatedJobs, this.job.Jobid);
            FillForm();
            SetApplyButton();
            SetLimit();
            FillRelatedJob();
        }
        private void FillRelatedJob()
        {
            foreach (Control control in pnRelatedJob.Controls)
            {
                if (control is UCInformation)
                {
                    pnRelatedJob.Controls.Remove(control);
                }
            }
            // Calculate the limit based on the offset
            int limit = Math.Min(2, relatedJobs.Count - offset);

            // Add related jobs to the panel based on the limit and offset
            for (int i = offset; i < offset + limit; i++)
            {
                UCInformation uCJob = new UCInformation(relatedJobs[i], this.jsID);
                uCJob.OpenFromAnotherJob += HandleOpenAnotherJob;
                pnRelatedJob.Controls.Add(uCJob);
            }

            // Hide or show navigation buttons based on the number of related jobs
            btnBack.Visible = offset > 0;
            btnNext.Visible = offset + 2 < relatedJobs.Count;
        }
        private void HandleOpenAnotherJob(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetLimit()
        {
            totalwaitingjob = relatedJobs.Count();
            if (limit > totalwaitingjob)
            {
                limit = totalwaitingjob;
                offset = 0;
            }
            else
            {
                limit = 4;
                offset = 0;
            }
        }
        private void FillForm()
        {
            lblWorkingTime.ForeColor = Color.FromArgb(166, 166, 166);
            lblAddress.ForeColor = Color.FromArgb(166, 166, 166);
            lblWorkingTime.ForeColor = Color.FromArgb(166, 166, 166);
            lblCompanySize.ForeColor = Color.FromArgb(166, 166, 166);
            lblCompanyType.ForeColor = Color.FromArgb(166, 166, 166);
            lblJobName.Text = job.Name;
            lblCompany.Text = company.INFO.Name;
            lblSalary.Text = job.Salary;
            lbLocation.Text = company.INFO.Address;
            lblWorkingForm.Text = job.WorkingForm;
            lblDate.Text = job.DatePublish.ToString();
            // Description
            string description = job.Description;
            string[] descriptionLines = description.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            description = string.Join(Environment.NewLine + "- ", descriptionLines);
            rtxtDescription.Text = "- " + description;

            // Requirement
            string requirement = job.Requirement;
            string[] requirementLines = requirement.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            requirement = string.Join(Environment.NewLine + "- ", requirementLines);
            rtxtRequirement.Text = "- " + requirement;

            // Benefit
            string benefit = job.Benefit;
            string[] benefitLines = benefit.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            benefit = string.Join(Environment.NewLine + "- ", benefitLines);
            rtxtBenefit.Text = "- " + benefit;
            if (company.Avatar != null) ptbAvatar.Image = company.Avatar;
            lblCompanyNameLeft.Text = company.INFO.Name;
            lblCompanySizeText.Text = company.CompanySize;
            lblCompanyTypeText.Text = company.CompanyType;
            lblWorkingTimeText.Text = company.WorkingTimeBegin + " to " + company.WorkingTimeEnd;
            lblAddressText.Text = company.INFO.Address;
            UCCarousel ucc = new UCCarousel(cadi.FetchAllPictures(company.INFO.ID));
            pnCarousel.Controls.Add(ucc);
            ucc.Dock = DockStyle.Fill;
            SetMostRecruited();
            foreach (string s in job.SkillList)
            {
                if (s != "NULL")
                {
                    BtnSkill btnSkill = new BtnSkill();
                    btnSkill.Text = s;
                    btnSkill.Show();
                    flowLayoutPanel4.Controls.Add(btnSkill);
                    flowLayoutPanel4.Width += btnSkill.Width + 20;
                }
            }
            if (company.CheckDownTrend() == false)
            {
                lblStatus.Visible = false;
            }
            else lblStatus.Visible = true;
        }

        private void SetMostRecruited()
        {
            if (company.INFO.ID == companyDAO.GetCompanyWithMostRecruitedCandidates())
            {
                pnTopCompany.Visible = true;
                pnTopCompany.Enabled = true;
            }
        }

        private void SetApplyButton()
        {
            if (applyDAO.CheckApply(job.Jobid, jsID))
            {
                btnApply.Enabled = false;
                btnApply.ColorBackground = Color.FromArgb(214, 204, 194);
                btnApply.ColorBackground_Pen = Color.FromArgb(214, 204, 194);
            }
            else
            {
                btnApply.Enabled = true;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {
            applyDAO.InsertApply(jsID, job.Jobid);
            btnApply.Enabled = false;
            btnApply.ColorBackground = Color.FromArgb(214, 204, 194);
            btnApply.ColorBackground_Pen = Color.FromArgb(214, 204, 194);
        }

        private void btnCompanyDetail_Click(object sender, EventArgs e)
        {
            FCompanyDetail companydetail = new FCompanyDetail(company.INFO.ID);
            companydetail.Show();
        }

        private void btnSeeMore_Click(object sender, EventArgs e)
        {
            FJobByCompany fJobByCompany = new FJobByCompany(company.INFO.ID, jsID);
            fJobByCompany.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Increase the offset to display the next set of related jobs
            offset += 2;
            FillRelatedJob();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            offset -= 2;
            FillRelatedJob();
        }
        private void FJobDetails_Load(object sender, EventArgs e)
        {

        }


    }
}
