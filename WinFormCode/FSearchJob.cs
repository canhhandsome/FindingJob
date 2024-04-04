using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            int count = 0;
            foreach (Job job in jobslist)
            {
                if (job.Status == "waiting")
                {
                    count++;
                    UCInformation uCInformation = new UCInformation(job, jsID);
                    uCInformation.flpBody.BackColor = colorJob(count);
                    flpJob.Controls.Add(uCInformation);
                    if (count % 2 == 1)
                    {
                        flpJob.Height += 481;
                    }
                }
                if (count == 4)
                {
                    count = 0;
                }
            }
        }
        private Color colorJob(int count)
        {
            if (count == 1)
                return Color.FromArgb(227, 219, 250);
            else if (count == 2)
                return Color.FromArgb(251, 226, 244);
            else if (count == 3)
                return Color.FromArgb(255, 225, 204);
            else return Color.FromArgb(212, 246, 237);
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
                    string[] propertiesToSearch = { job.Name.ToLower(), job.Position.ToLower(), job.Requirement.ToLower(), job.Description.ToLower(), job.Benefit.ToLower(), namecompany };

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
