using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Alert
    {
        string id, senderID, recipientID, subject, content;
        DateTime dateReply = new DateTime();
        public Alert() { }

        public Alert(string senderID, string recipientID, string subject, string content)
        {
            this.senderID = senderID;
            this.recipientID = recipientID;
            this.subject = subject;
            this.content = content;
            this.dateReply = DateTime.Now;
        }

        public Alert(string id, string senderID, string recipientID, string subject, string content)
        {
            this.id = id;
            this.senderID = senderID;
            this.recipientID = recipientID;
            this.subject = subject;
            this.content = content;
            this.dateReply = DateTime.Now;
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
    }
}
