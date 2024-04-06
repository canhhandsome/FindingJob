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
            rtxtDescription.Text = job.Description;
            rtxtRequirement.Text = job.Requirement;
            rtxtBenefit.Text = job.Benefit;
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            applyDAO.InsertApply(jsID, job.Jobid);
            btnApply.Enabled = false;
            btnApply.ColorBackground = Color.FromArgb(214, 204, 194);
            btnApply.ColorBackground_Pen = Color.FromArgb(214, 204, 194);
        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {

        }

        private void FJobDetails_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
