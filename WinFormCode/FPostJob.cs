using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormProject
{
    public partial class FPostJob : Form
    {
        private Form currentFormChild;
        private int locaX = 62;
        private int locaY = 0;
        private List<string> jobNames = new List<string>();
        private List<Job> jobs;
        private string companyid;

        public FPostJob(List<Job> jobs, string companyid)
        {
            InitializeComponent();
            this.jobs = jobs;
            this.companyid = companyid;
            foreach (Job job in jobs)
            {
                UCJob ucjob = new UCJob(job);
                pnSubBody.Controls.Add(ucjob);
                ucjob.Dock = DockStyle.Top;
                pnSubBody.Height += 180;
                // Subscribe to JobDeleted event
                ucjob.JobDeleted += UCJob_JobDeleted;
            }
        }

        private void PostJob_Load(object sender, EventArgs e)
        {
            
        }
        private void OpenChildForm(Form childForm)
        {
            //foreach (Control control in this.Controls)
            //{
            //    if (control == pnBody)
            //        continue;
            //    control.Visible = false;
            //}
            pnBody.Controls.Clear();

            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            pnBody.BackColor = Color.FromArgb(32, 41, 58);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPostingJob_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FJobCreation(jobs, companyid));
        }
        private void btnEditJob_Click(object sender, EventArgs e)
        {
            //FJobEdit fJobEdit = new FJobEdit();
            //fJobEdit.LblTitle = "Editing a job";
            //fJobEdit.BtnPostJob = "Save";
            //OpenChildForm(fJobEdit);
        }
        private void UCJob_JobDeleted(object sender, EventArgs e)
        {
            if (sender is UCJob ucjob)
            {
                // Remove the UCJob control from the panel
                pnSubBody.Controls.Remove(ucjob);
                ucjob.Dispose(); // Dispose if necessary
                jobs.Remove(ucjob.Job);
            }
        }
    }
}

