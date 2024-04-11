using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class FJobEdit : Form
    {
        private Form currentFormChild = new Form();
        private FJobSKills fJobSKills;
        private List<Job> jobs;
        private string companyid;
        private JobDAO jobDAO = new JobDAO();
        private Job job;
        private SkillListDAO sldao = new SkillListDAO();
        private List<string> skills = new List<string>();
        public FJobEdit(Job job, string companyid)
        {
            InitializeComponent();
            this.job = job;
            this.companyid = companyid;
            skills = job.SkillList;
            fJobSKills = new FJobSKills(skills);
            FillForm();
            fJobSKills.ListReady += FJobSkills_ListReady;
        }

        private void FillForm()
        {
            txtJobName.Text = job.Name;
            cbbExperience.SelectedItem = job.Position;
            txtSalary.Text = job.Salary;
            rtxtdescription.Text = job.Description;
            rtxtjobrequirement.Text = job.Requirement;
            rtxtBenefit.Text = job.Benefit;
            dtpDateEnd.Value = job.DateEnd;
            FillSkills();
            cbbWorkingForm.Text = job.WorkingForm;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FPostJob(jobs, companyid));
            this.Hide();
        }
        private void FJobSkills_ListReady(object sender, List<string> e)
        {
            skills = e;
            FillForm();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Job job1 = new Job(job.Jobid, job.CompanyID, txtJobName.Text, cbbExperience.Text, txtSalary.Text, rtxtjobrequirement.Text, rtxtdescription.Text, rtxtBenefit.Text, job.DatePublish, dtpDateEnd.Value, job.Status, cbbWorkingForm.Text, skills);
            jobDAO.EditJob(job1);
            SkillList skillist = new SkillList(job.Jobid, skills);
            sldao.UpdateSkillList(skillist);
            jobs = jobDAO.FetchCompanyJob(companyid);
            this.Close();
        }
        private void FillSkills()
        {
            flpSkills.Controls.Clear();
            flpSkills.Width = 0;
            foreach (string s in skills)
            {
                if (s != "NULL")
                {
                    BtnSkill btnSkill = new BtnSkill();
                    btnSkill.Text = s;
                    btnSkill.Show();
                    flpSkills.Controls.Add(btnSkill);
                    flpSkills.Width += btnSkill.Width + 20;
                }
            }
        }

        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            fJobSKills.Show();

        }
    }
}
