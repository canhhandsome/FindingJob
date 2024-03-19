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
        private byte[] AvatarData;
        private byte[] CvData;


        public JobSeeker()
        {

        }
        public JobSeeker(Information information)
        {
            this.information = information;
            List<string> list = new List<string>();
            list = jobseekerdao.FetchInformation(this);
            bdate = DateTime.Parse(list[0]);
            nationalid = list[1];
            gender = list[2];
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

        public byte[] Avatar
        {
            get { return AvatarData; }
        }

        public byte[] CV
        {
            get { return CvData; }
        }
    }
}
