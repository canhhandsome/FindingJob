using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach(Job job in jobs)
            {
                UCHistory uchistory = new UCHistory(job);
                pnSubBody.Controls.Add(uchistory);
                uchistory.Dock = DockStyle.Top;
                pnSubBody.Height += 270;
            }
        }
    }
}
