using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class SkillList
    {
        string jobid = string.Empty;
        List<string> skilllist = new List<string>();
        public SkillList(string jobid,List<string> skillList)
        {
            this.jobid = jobid;
            this.skilllist = skillList;
        }
        public List<string> skillList 
        {
            get { return skilllist; }
        }
        public string JobID
        {
            get { return jobid; }
        }
    }
}
