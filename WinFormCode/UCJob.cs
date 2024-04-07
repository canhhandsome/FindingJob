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
            this.MaximumSize = new System.Drawing.Size(481, 316);
            this.job = job;
        }

        public Job Job { get { return job; } }
        private void btnDone_Click(object sender, EventArgs e)
        {
            jobDAO.DoneJob(job.Jobid);
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            FApplicant fApplicant = new FApplicant(Job);
            fApplicant.Show();
        }

        private void UCJob_Load(object sender, EventArgs e)
        {
            lblDateEnd.Text = "Expired at: " + job.DateEnd.ToString("dd/MM/yyyy");
            lblDatePuslish.Text = "Publish at: " + job.DatePublish.ToString("dd/MM/yyyy");
            lblNameJob.Text = job.Name;
            lblStatus.Text = job.Status;
            lblWorkingType.Text = job.WorkingForm;
            foreach (string s in job.SkillList)
            {
                if (s != "NULL")
                {
                    BtnSkillShow btnkillshow = new BtnSkillShow();
                    //btnkillshow.Click += BtnSkill_Click;
                    btnkillshow.Text = s;
                    btnkillshow.Show();
                    flpSkills.Width += btnkillshow.Width + 10;
                    flpSkills.Controls.Add(btnkillshow);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FJobEdit fJobEdit = new FJobEdit(job, job.CompanyID);
            fJobEdit.Show();
        }
    }
}
