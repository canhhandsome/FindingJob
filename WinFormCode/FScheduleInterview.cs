using ReaLTaiizor.Controls;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;

namespace WinFormProject.WinFormCode
{
    public partial class FScheduleInterview : Form
    {
        Apply apply = new Apply();
        List<Interview> interviews = new List<Interview>();
        InterviewDAO InterviewDAO = new InterviewDAO();
        List<string> times = new List<string>();
        string jobseekerid, jobid;
        public FScheduleInterview(Apply apply)
        {
            InitializeComponent();
            this.apply = apply;
            jobseekerid = apply.JSeekerID;
            jobid = apply.JobID;
            interviews = InterviewDAO.AllInterview();
            times.AddRange(cbbTimeIv.Items.Cast<string>());
        }
        public FScheduleInterview(JobPreference jobPreference)
        {
            InitializeComponent();
            this.jobseekerid = jobPreference.JobSeekerId;
            this.jobid = string.Empty;
            interviews = InterviewDAO.AllInterview();
            times.AddRange(cbbTimeIv.Items.Cast<string>());
        }
        private void mcpSchdule_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblDateTime.Text = "Interview schedule: " + mcpSchdule.SelectionRange.Start.ToString("dd/MM/yyyy");
            cbbTimeIv.Items.Clear();
            cbbTimeIv.Items.AddRange(times.ToArray());
            FScheduleInterview_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Interview interview = new Interview(jobseekerid, jobid, cbbTimeIv.Text, mcpSchdule.SelectionRange.Start);
            InterviewDAO.InsertInterview(interview);
            interviews.Add(interview);
            FScheduleInterview_Load(sender, e);
        }

        private void FScheduleInterview_Load(object sender, EventArgs e)
        {
            flpBody.Controls.Clear();
            foreach (Interview interview in interviews)
            {
                if (interview.DateInterview == mcpSchdule.SelectionRange.Start)
                {
                    cbbTimeIv.Items.Remove(interview.TimeInterview);
                    UCInterview uc = new UCInterview(interview);
                    flpBody.Controls.Add(uc);
                    flpBody.Height += 85;
                }
            }
        }
    }
}
