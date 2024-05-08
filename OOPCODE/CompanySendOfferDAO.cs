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
            string sqlUpdate = string.Format("INSERT INTO CompanySendOffer (companyid,jobseekerid) " +
                                         "VALUES ('{0}', '{1}')",
                                         companySendOffer.companyid,companySendOffer.jobseekerid
                                         );
            conn.CRUD(sqlUpdate);
        }
        public bool AlreadySent(string jobseekerid)
        {
            string id;
            string strFetch = string.Format("SELECT status from CompanySendOffer WHERE JobSeekerID= '{0}'", jobseekerid);
            id = conn.FetchScalar(strFetch);
            if (id != "Rejected")
            {
                return true;
            }
            return false;
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
