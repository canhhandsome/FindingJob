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
        private FJobSKills fJobSKills = new FJobSKills();
        private List<Job> jobs;
        private string companyid;
        private JobDAO jobDAO = new JobDAO();
        private Job job;
        private SkillListDAO sldao = new SkillListDAO();

        public FJobEdit(Job job, string companyid)
        {
            InitializeComponent();
            this.job = job;
            this.companyid = companyid;
            fJobSKills.ListReady += FJobSkills_ListReady;
            FillForm();
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
            foreach (string skill in job.SkillList)
            {
                BtnSkill btnSkill = new BtnSkill();
                btnSkill.Text = skill;
                btnSkill.Show();
                flpSkills.Width += btnSkill.Width + 10;
                flpSkills.Controls.Add(btnSkill);
            }
            cbbWorkingForm.Text = job.WorkingForm;
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
            OpenChildForm(new FPostJob(jobs, companyid));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> skills = new List<string>();
            foreach (BtnSkill button in flpSkills.Controls.OfType<BtnSkill>())
            {
                skills.Add(button.Text);
            }
            Job job1 = new Job(job.Jobid, job.CompanyID, txtJobName.Text, cbbExperience.Text, txtSalary.Text, tbprequirement.Text, tbpdescription.Text, tbpbenefit.Text, job.DatePublish, dtpDateEnd.Value, job.Status, cbbWorkingForm.Text, skills);
            jobDAO.EditJob(job1);
            SkillList skillist = new SkillList(job.Jobid, skills);
            sldao.UpdateSkillList(skillist);
            jobs = jobDAO.FetchCompanyJob(companyid);
            OpenChildForm(new FPostJob(jobs, companyid));
        }
        private void FillSkills()
        {
            flpSkills.Controls.Clear();
            flpSkills.Width = 0;
            //foreach (string s in skills)
            {
                BtnSkill btnSkill = new BtnSkill();
                btnSkill.Text = s;
                btnSkill.Show();
                flpSkills.Width += btnSkill.Width + 10;
                flpSkills.Controls.Add(btnSkill);
            }
        }

        private void FJobSkills_ListReady(object sender, List<string> e)
        {
            //= e;
            //FillSkills();
        }
        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            fJobSKills.Show();
        }
    }
}
