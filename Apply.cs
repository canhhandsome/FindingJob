using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Apply
    {
        string jsID = string.Empty;
        string jID = string.Empty;
        DateTime dateApply = new DateTime();
        string status = "Waiting";

        public Apply()
        {

        }

        public Apply(string jsID, string jID, DateTime dateApply)
        {
            this.jsID = jsID;
            this.jID = jID;
            this.dateApply = dateApply;
        }
        public Apply(string jsID, string jID, DateTime dateApply, string status)
        {
            this.jsID = jsID;
            this.jID = jID;
            this.dateApply = dateApply;
            this.status = status;
        }

        public string JSeekerID
        {
            get { return jsID; }
        }
        public string JobID
        {
            get { return jID; }
        }

        public DateTime DATE
        {
            get { return dateApply; }
        }
        public string Status
        {
            get { return status; }
        }
    }
}
