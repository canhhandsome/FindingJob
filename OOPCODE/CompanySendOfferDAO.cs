using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormProject.WinFormCode;

namespace WinFormProject.OOPCODE
{
    public class CompanySendOfferDAO
    {
        DBConnection conn = new DBConnection();
        public void Insert(CompanySendOffer companySendOffer)
        {
            string sqlUpdate = string.Format("INSERT INTO CompanySendOffer (companyid,jobseekerid,status) " +
                                         "VALUES ('{0}', '{1}','{2}')",
                                         companySendOffer.companyid,companySendOffer.jobseekerid, "Offering");
            conn.CRUD(sqlUpdate);
        }
        public bool AlreadySent(string jobseekerid,string companyid)
        {
            string status;
            string strFetch = string.Format("SELECT status from CompanySendOffer WHERE JobSeekerID= '{0}' and CompanyID = '{1}'", jobseekerid,companyid);
            status = conn.FetchScalar(strFetch);
            if (status == "Rejected" || status == "")
            {
                return false;
            }
            return true;
        }
        public void OfferAccepted(string companyid, string jobseekerid)
        {
            string str = string.Format("UPDATE CompanySendOffer SET Status = 'Accepted' WHERE CompanyID = '{0}' AND JobSeekerID = '{1}'", companyid, jobseekerid);
            conn.CRUD(str);
        }
        public void OfferRejected(string companyid, string jobseekerid)
        {
            string str = string.Format("DELETE FROM CompanySendOffer WHERE CompanyID = '{0}' AND JobSeekerID = '{1}'", companyid, jobseekerid);
            conn.CRUD(str);
        }
    }
}
