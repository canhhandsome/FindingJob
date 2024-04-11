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
        private FJobSKills fJobSKills;
        private List<Job> jobs;
        private string companyid;
        private JobDAO jobDAO = new JobDAO();
        private SkillListDAO slDAO = new SkillListDAO();
        private List<string> skills = new List<string>();
        public FJobCreation(List<Job> jobs, string companyid)
        {
            InitializeComponent();
            this.jobs = jobs;
            this.companyid = companyid;
            fJobSKills = new FJobSKills(skills);
            fJobSKills.ListReady += FJobSkills_ListReady;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            List<string> skills = new List<string>();
            foreach (BtnSkill button in flpSkills.Controls.OfType<BtnSkill>())
            {
                skills.Add(button.Text);
            }
            Job job = new Job(companyid, txtJobName.Text, cbbExperience.Text, txtSalary.Text, rtxtjobrequirement.Text, rtxtdescription.Text, rtxtBenefit.Text, cbbWorkingForm.Text, dtpDateEnd.Value);
            string jobID = jobDAO.AddNewJob(job);
            SkillList sll = new SkillList(jobID, skills);
            slDAO.AddSkillList(sll);
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
