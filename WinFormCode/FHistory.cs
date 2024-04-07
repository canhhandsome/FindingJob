using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormProject.WinFormCode
{
    public partial class FHistory : Form
    {
        private List<Job> jobs;
        private string companyid;

        public FHistory(List<Job> jobs, string companyid)
        {
            InitializeComponent();
            this.jobs = jobs;
            this.companyid = companyid;
            foreach (Job job in jobs)
            {
                UCHistory uchistory = new UCHistory(job);
                pnSubBody.Controls.Add(uchistory);
                uchistory.Dock = DockStyle.Top;
                pnSubBody.Height += 150;
            }
        }
        private void Job_Load(object sender, EventArgs e)
        {
            JobDAO jobDAO = new JobDAO();
            jobs = jobDAO.FetchCompanyJob(companyid);
            pnSubBody.Controls.Clear();
            foreach (Job job in jobs)
            {
                UCHistory uchistory = new UCHistory(job);
                pnSubBody.Controls.Add(uchistory);
                uchistory.Dock = DockStyle.Top;
                pnSubBody.Height += 270;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Job_Load(sender, e);
        }
    }
}
