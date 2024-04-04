using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class JobSeeker
    {
        Information information = new Information();
        JobSeekerDAO jobseekerdao = new JobSeekerDAO();
        private DateTime bdate = new DateTime();
        private string nationalid = string.Empty;
        private string gender = string.Empty;
        private Image AvatarData = null;
        private byte[] CvData;


        public JobSeeker()
        {

        }
        public JobSeeker(Information information, DateTime bdate, string nationalid, string gender, Image avatarData, byte[] cvData)
        {
            this.information = information;
            this.bdate = bdate;
            this.nationalid = nationalid;
            this.gender = gender;
            AvatarData = avatarData;
            CvData = cvData;
        }

        public JobSeeker(Information information)
        {
            this.information = information;
            List<string> list = new List<string>();
            list = jobseekerdao.FetchInformation(this);
            nationalid = list[0];
            gender = list[1];
            bdate = DateTime.Parse(jobseekerdao.FetchBdate(this));
            AvatarData = jobseekerdao.FetchImg(this.INFO.ID);
            CvData = jobseekerdao.FetchCV(this.INFO.ID);
        }

        public Information INFO
        {
            get { return information; }
        }

        public DateTime BDate
        {
            get { return bdate; }
        }

        public string NationalID
        {
            get { return nationalid; }
        }

        public string Gender
        {
            get { return gender; }
        }

        public Image Avatar
        {
            get { return AvatarData; }
        }

        public byte[] CV
        {
            get { return CvData; }
        }
    }
}
