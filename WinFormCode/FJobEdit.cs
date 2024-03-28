using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class FJobEdit : Form
    {
        private Form currentFormChild = new Form();
        private List<Job> jobs;
        private string companyid;
        private JobDAO jobDAO = new JobDAO();
        private Job job;

        public FJobEdit(Job job)
        {
            InitializeComponent();
            this.job = job;
        }
        private void OpenChildForm(Form childForm)
        {
            foreach (Control control in this.Controls)
            {
                if (control == pnBody)
                    continue;
                control.Visible = false;
            }
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            pnBody.BackColor = Color.FromArgb(32, 41, 58);
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPostJob(jobs, companyid));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Job job1 = new Job(job.Jobid, job.CompanyID,txtJobName.Text,cbbExperience.Text,txtSalary.Text,rtxtjobrequirement.Text,rtxtdescription.Text,DateTime.Now);
            //jobDAO.EditJob(job1);
            //jobs = jobDAO.FetchAllJob(companyid);
            //OpenChildForm(new FPostJob(jobs, companyid));
        }
    }
}
