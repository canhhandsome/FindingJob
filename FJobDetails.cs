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
        public FJobDetails(Job job)
        {
            CompanyDAO companyDAO = new CompanyDAO();
            InitializeComponent();
            lblCompanyT.Text = companyDAO.FetchName(job.CompanyID);
            lblDateT.Text = job.DatePublish.ToString("dd/MM/yyyy");
            lblNameT.Text = job.Name;
            lblPositionT.Text = job.Position;
            lblSalaryT.Text = job.Salary;
            rtxtDescription.Text = job.Description;
            rtxtRequirement.Text = job.Requirement;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
