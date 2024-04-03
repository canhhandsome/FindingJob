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
    public partial class FJobDetails : Form
    {
        string jsID;
        Job job; 
        ApplyDAO applyDAO = new ApplyDAO();

        public FJobDetails(Job job, string jsID)
        {
            CompanyDAO companyDAO = new CompanyDAO();
            this.job = job;
            this.jsID = jsID;
            InitializeComponent();
            lblCompanyT.Text = companyDAO.FetchName(job.CompanyID);
            lblDateT.Text = job.DatePublish.ToString("dd/MM/yyyy");
            lblNameT.Text = job.Name;
            lblPositionT.Text = job.Position;
            lblSalaryT.Text = job.Salary;
            rtxtDescription.Text = job.Description;
            rtxtRequirement.Text = job.Requirement;
            rtxtBenefit.Text = job.Benefit;
            lblEndT.Text = job.DateEnd.ToString("dd/MM/yyyy");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            applyDAO.InsertApply(jsID, job.Jobid);
        }
    }
}
