using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class ApplyDAO
    {
        DBConnection conn = new DBConnection();

        public void InsertApply(string jsID, string jID)
        {
            string strApply = string.Format("INSERT INTO Apply(jobseekerID, jobID, timeApply) Values('{0}', '{1}', '{2}')", jsID, jID, DateTime.Now);
            conn.CRUD(strApply);
        }

        public List<Apply> AllApplies(string jobID)
        {
            List<Apply> list = new List<Apply>();
            string strFetch = string.Format("SELECT * FROM apply WHERE jobID = '{0}'", jobID);
            conn.FetchAllApplies(strFetch, list);
            return list;
        }
    }
}
