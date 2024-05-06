using System;
using System.Collections.Generic;
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
        public bool AlreadySent(string jobseekerid,string companyid)
        {
            string id;
            string strFetch = string.Format("SELECT companyid from CompanySendOffer WHERE JobSeekerID= '{0}'", jobseekerid);
            id = conn.FetchScalar(strFetch);
            if (companyid == id)
            {
                return true;
            }
            return false;
        }

    }
}
