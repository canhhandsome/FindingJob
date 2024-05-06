using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class JobPreferenceDAO
    {
        DBConnection conn = new DBConnection();
        public JobPreference FetchJobPreference(string jobseekerid)
        {
            string SQL = string.Format("SELECT * FROM JobPreference WHERE JobSeekerID = '{0}'", jobseekerid);
            return conn.FetchJobPreference(SQL);
        }
        public void FetchAllJobPreference(List<JobPreference> list)
        {
            string SQL = string.Format("Select *FROM JobPreference");
            conn.FetchAllJobPreference(SQL,list);
        }
        public void InsertJobPreference(JobPreference jobPreference)
        {
            // Ensure SkillList has at least 3 elements
            while (jobPreference.SkillList.Count < 3)
            {
                jobPreference.SkillList.Add("NULL");
            }

            string SQL = string.Format("INSERT INTO JobPreference " +
                "(JobSeekerID, Title, Position, CompanyType, WorkingForm, CompanySize, Location, Salary, Deadline, Skill1, Skill2, Skill3) " +
                "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}', '{9}', '{10}', '{11}')",
                jobPreference.JobSeekerId, jobPreference.Title, jobPreference.Position, jobPreference.CompanyType,
                jobPreference.WorkingForm, jobPreference.CompanySize, jobPreference.Location, jobPreference.Salary,
                jobPreference.Deadline.ToString("yyyy-MM-dd HH:mm:ss"), jobPreference.SkillList[0], jobPreference.SkillList[1],
                jobPreference.SkillList[2]);

            conn.CRUD(SQL);
        }
        public void UpdateJobPreference(JobPreference jobPreference)
        {
            // Ensure SkillList has at least 3 elements
            while (jobPreference.SkillList.Count < 3)
            {
                jobPreference.SkillList.Add("NULL");
            }

            string SQL = string.Format("UPDATE JobPreference " +
                "SET Title = '{0}', Position = '{1}', CompanyType = '{2}', WorkingForm = '{3}', " +
                "CompanySize = '{4}', Location = '{5}', Salary = {6}, Deadline = '{7}', " +
                "Skill1 = '{8}', Skill2 = '{9}', Skill3 = '{10}' " +
                "WHERE JobSeekerID = '{11}'",
                jobPreference.Title, jobPreference.Position, jobPreference.CompanyType,
                jobPreference.WorkingForm, jobPreference.CompanySize, jobPreference.Location,
                jobPreference.Salary, jobPreference.Deadline.ToString("yyyy-MM-dd HH:mm:ss"),
                jobPreference.SkillList[0], jobPreference.SkillList[1], jobPreference.SkillList[2],
                jobPreference.JobSeekerId);

            conn.CRUD(SQL);
        }

    }
}
