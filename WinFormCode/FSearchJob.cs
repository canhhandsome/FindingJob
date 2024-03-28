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
    public partial class FSearchJob : Form
    {
        private List<Job> jobs = new List<Job>();
        string jsID;
        public FSearchJob(string jsID)
        {
            this.jsID = jsID;
            InitializeComponent();
            JobDAO jobDAO = new JobDAO();
            jobs = jobDAO.FetchAvailableJobs();
            FillJob(this.jobs);
        }

        private void FillJob(List<Job> jobslist)
        {
            flpJob.Controls.Clear() ;
            foreach (Job job in jobslist)
            {
                UCInformation uCInformation = new UCInformation(job, jsID);
                flpJob.Controls.Add(uCInformation);
                flpJob.Height += 150;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = txtSearch.Text.ToLower();
                List<Job> searchJob = this.jobs.Where(job =>
                {
                    CompanyDAO companyDAO = new CompanyDAO();
                    string namecompany = companyDAO.FetchName(job.CompanyID).ToLower();
                    string[] propertiesToSearch = { job.Name.ToLower(), job.Position.ToLower(), job.Requirement.ToLower(), job.Description.ToLower(), namecompany};

                    return propertiesToSearch.Any(property => property.Contains(search));
                }).ToList();
                FillJob(searchJob);
            }
        }

    }
}
