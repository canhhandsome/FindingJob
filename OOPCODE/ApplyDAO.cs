using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string strFetch = string.Format("SELECT * FROM apply WHERE jobID = '{0}' AND status = 'waiting'", jobID);
            conn.FetchAllApplies(strFetch, list);
            return list;
        }

        public void UpdateStatus(string status, Apply apply)
        {
            string strCRUD = string.Format("UPDATE Apply SET status = '{0}' WHERE JobSeekerID = '{1}' AND JobID = '{2}'", status, apply.JSeekerID, apply.JobID);
            conn.CRUD(strCRUD);
        }


        public string FetchStatusApply(string jobID, string jsID)
        {
            string strFetch = string.Format($"SELECT status FROM Apply WHERE jobID = '{jobID}' and jobseekerID = '{jsID}'");
            return conn.FetchScalar(jobID);
        }
        

        public bool CheckApply(string jobID,string jsid) 
        {
            string SQL = string.Format("Select * From apply where jobID = '{0}' and jobseekerID = '{1}'", jobID,jsid);
            return conn.CheckApplyData(SQL,jobID,jsid);
        }
        public List<string> FetchStatusApply(string jobID)
        {
            string strStatus= string.Format($"SELECT status FROM Apply WHERE jobID = '{jobID}'");
            return conn.FetchSeperatedData(strStatus);
        }
    }
}
