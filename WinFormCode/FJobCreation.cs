using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;
using WinFormProject.WinFormCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormProject
{
    public partial class FJobCreation : Form
    {
        private Form currentFormChild = new Form();
        private FJobSKills fJobSKills = new FJobSKills();
        private List<Job> jobs;
        private string companyid;
        private JobDAO jobDAO = new JobDAO();
        private SkillListDAO slDAO = new SkillListDAO();
        private List<string> skills;
        public FJobCreation(List<Job> jobs, string companyid)
        {
            InitializeComponent();
            this.jobs = jobs;
            this.companyid = companyid;
            fJobSKills.ListReady += FJobSkills_ListReady;
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

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            List<string> skills = new List<string>();
            foreach (BtnSkill button in flpSkills.Controls.OfType<BtnSkill>())
            {
                skills.Add(button.Text);   
            }
            Job job = new Job(companyid,txtJobName.Text,cbbExperience.Text,txtSalary.Text,rtxtjobrequirement.Text,rtxtdescription.Text,rtxtBenefit.Text, cbbWorkingForm.Text, dtpDateEnd.Value);
            string jobID = jobDAO.AddNewJob(job);
            SkillList sll = new SkillList(jobID, skills);
            slDAO.AddSkillList(sll);
            jobs = jobDAO.FetchCompanyJob(companyid);
            OpenChildForm(new FPostJob(jobs, companyid));
        }

        private void FillSkills()
        {
            flpSkills.Controls.Clear();
            flpSkills.Width = 0;
            foreach (string s in skills)
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
            skills = e;
            FillSkills();
        }

        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            fJobSKills.Show();
        }
    }
}
