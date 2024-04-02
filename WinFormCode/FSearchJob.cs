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
        FFilter fFilter;
        JobDAO jobDAO = new JobDAO();
        public FSearchJob(string jsID)
        {
            this.jsID = jsID;
            InitializeComponent();
            jobs = jobDAO.FetchAvailableJobs();
            fFilter = new FFilter(jobs);
            FillJob(this.jobs);
            fFilter.ListReady += fFilter_ListReady;
        }
        private void fFilter_ListReady(object sender, List<Job> e)
        {
            jobs = e;
            FillJob(this.jobs);
        }
        private void FillJob(List<Job> jobslist)
        {
            flpJob.Controls.Clear();
            foreach (Job job in jobslist)
            {
                if(job.Status == "waiting")
                {
                    UCInformation uCInformation = new UCInformation(job, jsID);
                    flpJob.Controls.Add(uCInformation);
                    flpJob.Height += 150;
                }
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
                    string[] propertiesToSearch = { job.Name.ToLower(), job.Position.ToLower(), job.Requirement.ToLower(), job.Description.ToLower(), namecompany };

                    return propertiesToSearch.Any(property => property.Contains(search));
                }).ToList();
                FillJob(searchJob);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            fFilter.Show();
        }
    }
}
