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
            jobs = jobDAO.FetchJobs();
        }

        private void hopeTextBox1_Enter(object sender, EventArgs e)
        {
            foreach(Job job in jobs)
            {
                UCInformation uCInformation = new UCInformation(job, jsID);
                flpJob.Controls.Add(uCInformation);
                flpJob.Height += 135;
            }
        }

    }
}
