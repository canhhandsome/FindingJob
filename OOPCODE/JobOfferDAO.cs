using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class JobOfferDAO
    {
        DBConnection conn = new DBConnection();
        public JobOfferDAO() { }
        public void InsertOffer(JobOffer offer)
        {
            string sqlUpdate = string.Format("INSERT INTO JobOffer (senderID, recipientID, subject, content, dateReply,status) " +
                                     "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}')",
                                     offer.SenderID, offer.RecipientID, offer.Subject, offer.Content, offer.DateReply,"Offering");
            conn.CRUD(sqlUpdate);
        }
        public List<JobOffer> FetchOffers(string jobseekerid)
        {
            List<JobOffer> offers = new List<JobOffer>();
            string sqlFetch = string.Format("SELECT * FROM JobOffer WHERE recipientID = '{0}'", jobseekerid);
            conn.FetchAllOffers(sqlFetch, offers);
            return offers;
        }
        public void OfferAccepted(string companyid, string jobseekerid)
        {
            string SQL = string.Format("Update JobOffer Set Status ='Accepted' Where recipientID ='{1}' And SenderID ='{0}'", companyid,jobseekerid);
            conn.CRUD(SQL);
        }
        public void OfferRejected(string companyid, string jobseekerid)
        {
            string SQL = string.Format("Update JobOffer Set Status ='Rejected' Where recipientID ='{1}' And SenderID ='{0}'", companyid, jobseekerid);
            conn.CRUD(SQL);
        }
    }
}
