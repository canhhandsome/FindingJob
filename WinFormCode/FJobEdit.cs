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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            dtpDateEnd.MinDate = DateTime.Today.AddDays(-1);

        }

        public List<Job> JobList
        { get { return jobs; } }

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

        private void btnSave_Click_Error(object sender, EventArgs e)
        {
            SetError(txtJobName);
            SetError(txtSalary);
            SetError(cbbExperience);
            SetError(cbbWorkingForm);
            SetError(rtxtBenefit);
            SetError(rtxtdescription);
            SetError(rtxtjobrequirement);
            if (flpSkills.Controls.Count < 1)
            {
                MessageBox.Show("Choose the Main Skill!!");
                return;
            }
            if (AnyErrors(this))
            {
                return;
            }
            foreach (Control control in this.Controls)
            {
                if (AnyErrors(control))
                {
                    return;
                }
            }
            btnSave_Click(sender, e);
        }

        public bool AnyErrors(Control control)
        {
            // Check if the control has an ErrorProvider and if it has any errors
            if (control is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                if (!string.IsNullOrEmpty(epTextbox.GetError(txt)))
                {
                    return true;
                }
            }

            if (control is Guna.UI2.WinForms.Guna2ComboBox cbb)
            {
                if (!string.IsNullOrEmpty(epCbb.GetError(cbb)))
                {
                    return true;
                }
            }

            if (control is RichTextBox rtxt)
            {
                if (!string.IsNullOrEmpty(epTextbox.GetError(rtxt)))
                {
                    return true;
                }
            }

            foreach (Control childControl in control.Controls)
            {
                if (AnyErrors(childControl))
                {
                    return true;
                }
            }

            return false;
        }

        private void txtJobName_Leave(object sender, EventArgs e)
        {
            SetError(txtJobName);
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            SetError(txtSalary);
        }

        private void SetError(Guna.UI2.WinForms.Guna2TextBox txt)
        {
            if (txt.Text.Length == 0)
            {
                epTextbox.SetError(txt, "Textbox cannot be empty");
            }
            else
            {
                epTextbox.SetError(txt, "");
            }
        }
        private void SetError(Guna.UI2.WinForms.Guna2ComboBox cbb)
        {
            if (cbb.SelectedIndex < 0)
            {
                epCbb.SetError(cbb, "Must choose something!!!");
            }
            else
            {
                epCbb.SetError(cbb, "");
            }
        }
        private void SetError(RichTextBox rtxt)
        {
            if (rtxt.Text.Length < 1)
            {
                epTextbox.SetError(rtxt, "Textbox cannot be empty");
            }
            else
            {
                epTextbox.SetError(rtxt, "");
            }
        }
    }
}
