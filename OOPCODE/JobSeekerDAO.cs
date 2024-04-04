using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string strFetch = string.Format("SELECT nationalid,gender FROM {0} where id = '{1}'", "jobseeker", jobseeker.INFO.ID);
            return conn.FetchSeperatedData(strFetch);
        }
        public string FetchBdate(JobSeeker jobseeker)
        {
            string strFetch = string.Format("SELECT DateOfBirth FROM {0} where id = '{1}'", "jobseeker", jobseeker.INFO.ID);
            return conn.FetchScalar(strFetch);
        }
        public Image FetchImg(string jobseekerid)
        {
            string strFetch = string.Format("SELECT Avatar FROM JobSeeker WHERE id = '{0}'", jobseekerid);
            return conn.FetchInfoImages(strFetch);
        }

        public byte[] FetchCV(string jobseekerid)
        {
            string strFetch = string.Format("SELECT CV FROM Jobseeker WHERE id = '{0}'", jobseekerid);
            return conn.FetchBinaryData(strFetch);
        }
        public void UpdateJobSeeker(JobSeeker jobseeker)
        {
            string sqlUpdate = string.Format("UPDATE JobSeeker SET name = '{1}', email = '{2}', address = '{3}', phonenumber = '{4}', dateofbirth = @BDate, nationalid = '{5}', avatar = @Avatar, cv = @CV, gender = '{6}' WHERE id = '{0}'",
            jobseeker.INFO.ID, jobseeker.INFO.Name, jobseeker.INFO.Email, jobseeker.INFO.Address, jobseeker.INFO.Phone, jobseeker.NationalID, jobseeker.Gender);
            conn.CRUD(sqlUpdate, jobseeker);
        }
    }
}
