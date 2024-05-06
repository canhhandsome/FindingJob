using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;

namespace WinFormProject.WinFormCode
{
    public partial class FJobPreference : Form
    {
        JobPreference jobpreference;
        JobPreferenceDAO JobPreferenceDAO = new JobPreferenceDAO();
        FJobSKills fJobSKills;
        string jobseekerid;

        public FJobPreference(string jobseekerid)
        {
            jobpreference = JobPreferenceDAO.FetchJobPreference(jobseekerid);
            InitializeComponent();
            FillInformation();
            fJobSKills = new FJobSKills(jobpreference.SkillList);
            fJobSKills.ListReady += FJobSkills_ListReady;
            this.jobseekerid = jobseekerid;

        }
        private void FillInformation()
        {
            this.txtJobName.Text = jobpreference.Title;
            this.txtJobName.Enabled = false; // Disable text box

            this.txtSalary.Text = jobpreference.Salary.ToString();
            this.txtSalary.Enabled = false; // Disable text box

            this.txtLocation.Text = jobpreference.Location;
            this.txtLocation.Enabled = false; // Disable text box

            this.cbbCompanySize.Text = jobpreference.CompanySize;
            this.cbbCompanySize.Enabled = false; // Disable combo box

            this.cbbCompanyType.Text = jobpreference.CompanyType;
            this.cbbCompanyType.Enabled = false; // Disable combo box

            this.cbbExperience.Text = jobpreference.Position;
            this.cbbExperience.Enabled = false; // Disable combo box

            this.cbbWorkingForm.Text = jobpreference.WorkingForm;
            this.cbbWorkingForm.Enabled = false; // Disable combo box
            FillSkill();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Enable or disable text boxes
            this.txtJobName.Enabled = true;
            this.txtSalary.Enabled = true;
            this.txtLocation.Enabled = true;

            // Enable or disable combo boxes
            this.cbbCompanySize.Enabled = true;
            this.cbbCompanyType.Enabled = true;
            this.cbbExperience.Enabled = true;
            this.cbbWorkingForm.Enabled = true;

            // Enable or disable skill buttons
            foreach (Control control in flpSkills.Controls)
            {
                if (control is BtnSkillShow btnSkillShow)
                {
                    btnSkillShow.Enabled = true;
                }
            }
        }

        private void btnAddSkills_Click(object sender, EventArgs e)
        {
            fJobSKills.Show();
        }
        private void FJobSkills_ListReady(object sender, List<string> e)
        {
            jobpreference.SkillList = e;
            FillSkill();
        }
        private void FillSkill()
        {
            foreach (string s in jobpreference.SkillList)
            {
                if (s != "NULL")
                {
                    BtnSkillShow btnSkillShow = new BtnSkillShow();
                    btnSkillShow.Text = s;
                    btnSkillShow.Enabled = false; // Disable button
                    flpSkills.Controls.Add(btnSkillShow);
                    flpSkills.Width += btnSkillShow.Width + 20;
                }
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            
            jobpreference.Title = txtJobName.Text;
            jobpreference.Salary = int.Parse(txtSalary.Text); // Assuming salary is entered as an integer
            jobpreference.Location = txtLocation.Text;
            jobpreference.CompanySize = cbbCompanySize.Text;
            jobpreference.CompanyType = cbbCompanyType.Text;
            jobpreference.Position = cbbExperience.Text;
            jobpreference.WorkingForm = cbbWorkingForm.Text;
            // Update the deadline property (assuming the deadline is entered through a DateTimePicker)
            jobpreference.Deadline = dtpDateEnd.Value;
            if(jobpreference.JobSeekerId == "")
            {
                jobpreference.JobSeekerId = jobseekerid;
                JobPreferenceDAO.InsertJobPreference(jobpreference);
            } else
            {
                JobPreferenceDAO.UpdateJobPreference(jobpreference);
            }
            
        }
    }
}
