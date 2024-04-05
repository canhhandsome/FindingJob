using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class AlertDAO
    {
        DBConnection conn = new DBConnection();

        public void InsertAlert(Alert alert)
        {
            string sqlUpdate = string.Format("INSERT INTO JobAlert (senderID, recipientID, subject, content, dateReply, jobID) " +
                                     "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                     alert.SenderID, alert.RecipientID, alert.Subject, alert.Content, alert.DateReply, alert.JobID);
            conn.CRUD(sqlUpdate);
        }

        public List<Alert> FetchAlert(string recipientID)
        {
            List<Alert> alerts = new List<Alert>();
            string sqlFetch = string.Format("SELECT * FROM JobAlert WHERE recipientID = '{0}'", recipientID);
            conn.FetchAllAlert(sqlFetch, alerts);
            return alerts;
        }

    }
}
