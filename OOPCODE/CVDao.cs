using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class CVDao
    {
        DBConnection conn = new DBConnection();
        public CVDao() { }
        public void FetchAllInformationOfCV(string jobseekerid, CV cv)
        {
            string SQL = string.Format("Select * From CV where jobseekerid = '{0}'", jobseekerid);
            conn.FetchCV(SQL, cv);
        }
        public void UpdateCV(CV cv)
        {
            string SQL = string.Format("UPDATE CV SET CV = @CV, CVPicture = @CVPicture, LikeCount = @LikeCount, JobSeekerID = @JobSeekerID WHERE JobSeekerID = @JobSeekerID");
            conn.UpdateCV(SQL,cv);
        }
    }
}
