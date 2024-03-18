// UCJob.cs

using System;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class UCJob : UserControl
    {
        // Define delegate and event
        public delegate void JobDeletedEventHandler(object sender, EventArgs e);
        public event JobDeletedEventHandler JobDeleted;

        Job job;
        JobDAO jobDAO = new JobDAO();

        public UCJob(Job job)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(812, 212);
            this.job = job;
            lblJobNameT.Text = job.Name;
            lblDateT.Text = job.DatePublish.ToString();
        }
        public Job Job { get { return job; } }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            // Delete job from database
            jobDAO.DeleteJob(job.Jobid);

            // Raise the event to notify parent form
            OnJobDeleted(EventArgs.Empty);
        }

        // Method to raise the event
        protected virtual void OnJobDeleted(EventArgs e)
        {
            JobDeleted?.Invoke(this, e);
        }
    }
}
