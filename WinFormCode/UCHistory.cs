using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject.WinFormCode
{
    public partial class UCHistory : UserControl
    {
        Job job = new Job();
        JobDAO jobDAO = new JobDAO();

        public UCHistory(Job job)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(550, 421);
            this.job = job;
        }


        private void btnApplicants_Click(object sender, EventArgs e)
        {
            FApplicant fApplicant = new FApplicant(job);
            fApplicant.Show();
        }

        private void UCHistory_Load(object sender, EventArgs e)
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
    }
}
