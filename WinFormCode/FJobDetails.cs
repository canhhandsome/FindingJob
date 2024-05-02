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
        Company company;
        ApplyDAO applyDAO = new ApplyDAO();
        CompanyAddtionalImageDAO cadi = new CompanyAddtionalImageDAO();
        CompanyDAO companyDAO = new CompanyDAO();
        public FJobDetails(Job job, string jsID)
        {
            InitializeComponent();
            this.job = job;
            this.jsID = jsID;
            company = companyDAO.FetchCompanyInformationBasedOnID(job.CompanyID);
            FillForm();
            SetApplyButton();
        }

        private void FillForm()
        {
            lblWorkingTime.ForeColor = Color.FromArgb(166, 166, 166);
            lblAddress.ForeColor = Color.FromArgb(166, 166, 166);
            lblWorkingTime.ForeColor = Color.FromArgb(166, 166, 166);
            lblCompanySize.ForeColor = Color.FromArgb(166, 166, 166);
            lblCompanyType.ForeColor = Color.FromArgb(166, 166, 166);
            btnApply.ColorBackground = Color.FromArgb(237, 27, 47);
            lblJobName.Text = job.Name;
            lblCompany.Text = company.INFO.Name;
            lblSalary.Text = job.Salary;
            lbLocation.Text = company.INFO.Address;
            lblWorkingForm.Text = job.WorkingForm;
            lblDate.Text = job.DatePublish.ToString();
            rtxtDescription.Text = job.Description;
            rtxtRequirement.Text = job.Requirement;
            rtxtBenefit.Text = job.Benefit;
            if (company.Avatar != null) ptbAvatar.Image = company.Avatar;
            lblCompanyNameLeft.Text = company.INFO.Name;
            lblCompanySizeText.Text = company.CompanySize;
            lblCompanyTypeText.Text = company.CompanyType;
            lblWorkingTimeText.Text = company.WorkingTimeBegin + " to " + company.WorkingTimeEnd;
            lblAddressText.Text = company.INFO.Address;
            UCCarousel ucc = new UCCarousel(cadi.FetchAllPictures(company.INFO.ID));
            pnCarousel.Controls.Add(ucc);
            SetMostRecruited();
        }

        private void SetMostRecruited()
        {
            if(company.INFO.ID == companyDAO.GetCompanyWithMostRecruitedCandidates())
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
                btnApply.ColorBackground = Color.FromArgb(176, 226, 243);
                btnApply.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
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
    }
}
