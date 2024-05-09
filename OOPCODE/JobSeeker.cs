using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormProject.OOPCODE;

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
        private CV cv = new CV();
   

        public JobSeeker()
        {
            
        }
        public JobSeeker(Information information, DateTime bdate, string nationalid, string gender, Image avatarData,CV cv)
        {
            this.information = information;
            this.bdate = bdate;
            this.nationalid = nationalid;
            this.gender = gender;
            AvatarData = avatarData;
            this.cv = cv;
        }

        public JobSeeker(Information information)
        {
            this.information = information;
            List<string> list = new List<string>();
            list = jobseekerdao.FetchInformation(this);
            nationalid = list[0];
            gender = list[1];
            bdate = DateTime.Parse(jobseekerdao.FetchBdate(this));
            AvatarData = jobseekerdao.FetchImg(this.INFO.ID, "Avatar");
            CVDao cvDao = new CVDao();
            cvDao.FetchAllInformationOfCV(this.INFO.ID,cv);
        }

        public bool CheckAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            // Check if the birthday has occurred this year
            if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                age--;
            }
            return age > 15;
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
        public CV CVData
        {
            get { return cv; }
        }
    }
}
