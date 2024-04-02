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

namespace WinFormProject
{
    public partial class FJobCreation : Form
    {
        private Form currentFormChild = new Form();
        private List<Job> jobs;
        private string companyid;
        private JobDAO jobDAO = new JobDAO();

        public FJobCreation(List<Job> jobs,string companyid)
        {
            InitializeComponent();
            this.jobs = jobs;
            this.companyid = companyid;
        }
        private void OpenChildForm(Form childForm)
        {
            foreach (Control control in this.Controls)
            {
                if (control == pnBody)
                    continue;
                control.Visible = false;
            }
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPostJob(jobs,companyid));
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            jobDAO.AddNewJob(companyid, txtJobName.Text, cbbExperience.Text, txtSalary.Text, rtxtjobrequirement.Text, rtxtdescription.Text, dtpDateEnd.Value.ToString("yyyy-MM-dd"));
            jobs = jobDAO.FetchCompanyJob(companyid);
            OpenChildForm(new FPostJob(jobs, companyid));
        }

    }
}
