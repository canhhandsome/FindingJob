using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class CV
    {
        private byte[] CVData = new byte[0];
        private Image CVPicture;
        private int likes = 0 ;
        private string jobseekerID = string.Empty;
        // Constructor
        public CV(byte[] cvData, Image cvPicture, int likes, string jobseekerID)
        {
            CVData = cvData;
            CVPicture = cvPicture;
            this.likes = likes;
            this.jobseekerID = jobseekerID;
        }
        public CV()
        {

        }
        public byte[] CVDataProperty
        {
            get { return CVData; }
            set { CVData = value; }
        }

        public Image CVPictureProperty
        {
            get { return CVPicture; }
            set { CVPicture = value; }
        }

        public int Likes
        {
            get { return likes; }
            set { likes = value; }
        }

        public string JobSeekerID
        {
            get { return jobseekerID; }
            set { jobseekerID = value; }
        }


    }
}
