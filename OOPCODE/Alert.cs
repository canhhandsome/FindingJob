using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Alert
    {
        string senderID, recipientID, subject, content, jobID;
        string id = string.Empty;
        DateTime dateReply = new DateTime();
        public Alert() {  }

        public Alert(string senderID, string recipientID, string subject, string content, string jobID)
        {
            this.senderID = senderID;
            this.recipientID = recipientID;
            this.subject = subject;
            this.content = content;
            this.dateReply = DateTime.Now;
            this.jobID = jobID;
        }

        public Alert(string id, string senderID, string recipientID, string subject, string content, string jobID)
        {
            this.id = id;
            this.senderID = senderID;
            this.recipientID = recipientID;
            this.subject = subject;
            this.content = content;
            this.dateReply = DateTime.Now;
            this.jobID = jobID;
        }
        public string ID
        { get { return id; } }
        public string Subject
        { get { return subject; } }
        public string Content
        { get { return content; } }
        public DateTime DateReply
        { get { return dateReply; } }
        public string SenderID
        { get { return senderID; } }
        public string RecipientID
        { get { return recipientID; } }
        public string JobID 
        { get { return jobID; } }
    }
}
