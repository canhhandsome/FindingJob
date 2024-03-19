using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class JobSeekerDAO
    {
        DBConnection conn = new DBConnection();

        public string FetchName(string id)
        {
            string strScalar = string.Format("SELECT name FROM jobseeker WHERE id = '{0}'", id);
            return conn.FetchScalar(strScalar);
        }
        public List<string> FetchInformation(JobSeeker jobseeker)
        {
            string strFetch = string.Format("SELECT dateofbirth,nationalid,gender FROM {0} where id = '{1}'", "jobseeker", jobseeker.INFO.ID);
            return conn.FetchSeperatedData(strFetch);
        }
        public byte[] FetchImg(string jobseekerid)
        {
            string strFetch = string.Format("SELECT Avatar FROM JobSeeker WHERE id = '{0}'", jobseekerid);
            string imageDataAsString = conn.FetchScalar(strFetch) as string;
            byte[] imageData = Convert.FromBase64String(imageDataAsString);
            return imageData;
        }
        public byte[] FetchCV(string jobseekerid)
        {
            string strFetch = string.Format("SELECT CV FROM Jobseeker WHERE id = '{0}'", jobseekerid);
            string cvDataAsString = conn.FetchScalar(strFetch) as string;
            byte[] cvData = Convert.FromBase64String(cvDataAsString);
            return cvData;
        }
    }
}
