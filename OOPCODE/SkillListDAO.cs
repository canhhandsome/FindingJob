using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class SkillListDAO
    {
        DBConnection conn = new DBConnection();
        public SkillListDAO()
        {

        }
        public void AddSkillList(SkillList skilllist)
        {
           
            while(skilllist.skillList.Count < 3 )
            {
                skilllist.skillList.Add("NULL");
            }
            string SQL = string.Format("INSERT INTO JobSkill (jobid,Skill1,Skill2,Skill3)  " + "VALUES ('{0}', '{1}', '{2}','{3}')", skilllist.JobID,skilllist.skillList[0], skilllist.skillList[1], skilllist.skillList[2]);
            conn.CRUD(SQL);
        }
        public void UpdateSkillList(SkillList skilllist)
        {
            while (skilllist.skillList.Count < 3)
            {
                skilllist.skillList.Add("NULL");
            }
            string SQL = string.Format("UPDATE JobSkill SET skill1 = '{0}', skill2 = '{1}', skill3 = '{2}' WHERE jobid = '{3}'", skilllist.skillList[0], skilllist.skillList[1], skilllist.skillList[2], skilllist.JobID);
            conn.CRUD(SQL);
        }
        public List<string> GetSkills(string  jobID)
        {
            string SQL = string.Format("SELECT * from jobskill where jobid = '{0}'", jobID);
            return conn.FetchAllJobSkill(SQL);
        }
    }
}
