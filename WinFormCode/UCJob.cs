// UCJob.cs

using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using WinFormProject.WinFormCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormProject
{
    public partial class UCJob : UserControl
    {
        Job job = new Job();
        JobDAO jobDAO = new JobDAO();
        public UCJob(Job job)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(550, 421);
            this.job = job;
        }

        public Job Job { get { return job; } }
        private void btnDone_Click(object sender, EventArgs e)
        {
            jobDAO.DoneJob(job.Jobid);
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            FApplicant fApplicant = new FApplicant(job);
            fApplicant.Show();
        }

        private void UCJob_Load(object sender, EventArgs e)
        {
            lblNameJob.Text = job.Name;
            lblStatus.Text = job.Status;
            lblDatePuslish.Text = "Posted " + PublishTime();
            lblDateEnd.Text = "Expired after " + ExpiredTime();
            lblWorkingType.Text = job.WorkingForm;
            foreach (string s in job.SkillList)
            {
                if (s != "NULL")
                {
                    BtnSkill btnSkill = new BtnSkill();
                    btnSkill.Text = s;
                    btnSkill.Show();
                    flpSkills.Width += btnSkill.Width + 10;
                    flpSkills.Controls.Add(btnSkill);
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

        private string ExpiredTime()
        {
            TimeSpan timeDifference =job.DateEnd - DateTime.Now;

            if (timeDifference.TotalMinutes < 0)
            {
                return $"{(int)timeDifference.TotalSeconds} second(s)";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{(int)timeDifference.TotalMinutes} minute(s)";
            }
            else if (timeDifference.TotalHours < 24)
            {
                return $"{(int)timeDifference.TotalHours} hour(s)";
            }
            else
            {
                return $"{(int)timeDifference.TotalDays} day(s)";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FJobEdit fJobEdit = new FJobEdit(job, job.CompanyID);
            fJobEdit.Show();
        }
    }
}
