using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class JobOffer
    {
        // Private fields should be declared with the access modifier "private"
        private string jobseekerid, status, companyid, subject, content;
        string id = string.Empty;
        
        DateTime dateReply = new DateTime();

        // Constructor to initialize the fields
        public JobOffer()
        {

        }
        public JobOffer(string companyid,string jobseekerid, string subject,string content)
        {
            this.jobseekerid = jobseekerid; 
            this.companyid = companyid;
            this.subject = subject;
            this.content = content;
            this.dateReply = DateTime.Now;

        }
        public JobOffer(string id, string companyid, string jobseekerid, string subject, string content,string status)
        {
            this.id = id;
            this.jobseekerid = jobseekerid;
            this.companyid = companyid;
            this.subject = subject;
            this.content = content;
            this.dateReply = DateTime.Now;
            this.status = status;

        }
        // Properties to provide access to the private fields
        public string ID
        { get { return id; } }
        public string Subject
        { get { return subject; } }
        public string Content
        { get { return content; } }
        public DateTime DateReply
        { get { return dateReply; } }
        public string SenderID
        { get { return companyid; } }
        public string RecipientID
        { get { return jobseekerid; } }
        public string Status
        {
            get { return status; }
        }
    }
}

