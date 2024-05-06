using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class CompanyLikeCVDao
    {
        DBConnection conn = new DBConnection();
        public void FetchCompayLikeCV(string companyid,CompanyLikeCV companylikecv)
        {
            string SQL = string.Format("Select * from CompanyLikeJobSeekerCV where Companyid = '{0}'",companyid);
            conn.FetchCompanyLikeCV(SQL,companylikecv); 
        }
        public void InserCompanyLikeCV(CompanyLikeCV companylikecv)
        {
            string SQL = string.Format("INSERT INTO CompanyLikeJobSeekerCV (CompanyID, JobSeekerID) VALUES ('{0}', '{1}')",companylikecv.CompanyId,companylikecv.JobseekerId);
            conn.CRUD(SQL);
        }
        public void RemoveCompanyLikeCV(CompanyLikeCV companylikecv)
        {
            string SQL = string.Format("Delete From CompanyLikeJobSeekerCV Where CompanyID = '{0}'", companylikecv.CompanyId);
            conn.CRUD(SQL);
        }
    }
}
