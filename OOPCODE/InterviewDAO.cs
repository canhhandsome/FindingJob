using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class InterviewDAO
    {
        DBConnection conn;
        public InterviewDAO()
        {
            this.conn = new DBConnection();
        }

        public void InsertInterview(Interview interview)
        {
            string strCRUD = string.Format(@$"Insert into Interview (IdJSeeker, IdJob, TimeInterview, DateInterview) Values('{interview.IdJSeeker}', '{interview.IdJob}', '{interview.TimeInterview}', '{interview.DateInterview.ToString("yyyy-MM-dd")}')");
            conn.CRUD(strCRUD);
        }

        public List<Interview> FetchInterviewByID(string jobID)
        {
            string strFetch = string.Format(@$"Select * FROM Interview WHERE idJob = '{jobID}'");
            return conn.FetchAllInterviews(strFetch);
        }
        public List<Interview> FetchInterviewByID(string jsID, string jobID)
        {
            string strFetch = string.Format(@$"Select * FROM Interview WHERE idJob = '{jobID}' and idJSeeker = '{jsID}'");
            return conn.FetchAllInterviews(strFetch);
        }

        public List<Interview> AllInterview()
        {
            string strFetch = string.Format(@$"Select * FROM Interview");
            return conn.FetchAllInterviews(strFetch);
        }

        public Interview FetchInterview(string jsID, string jobID)
        {
            string strFetch = string.Format(@$"Select * FROM Interview WHERE idJob = '{jobID}' and idJSeeker = '{jsID}'");
            return conn.FetchInterview(strFetch);
        }

    }
}
