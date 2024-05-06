using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormProject.OOPCODE;

namespace WinFormProject
{
    public class Company
    {
        string companytype, companysize,taxidentification,description,websitelink,workingtimebegin,workingtimeend,workingform;
        CompanyDAO companyDAO = new CompanyDAO();
        JobDAO jobDao = new JobDAO();
        Information information = new Information();
        List<Job> jobs = new List<Job>();
        Image AvatarData = null;
        Image BusinessLicenseData = null;
        public Company()
        {
            
        }

        public Company(Information information, string companytype, string companysize, string taxidentification, string description,string websitelink,string workingtimebegin,string workingtimeend, Image AvatarData, Image BusinessLicenseData,List<Image> Images)
        {
            this.information = information;
            this.companytype = companytype;
            this.companysize = companysize;
            this.taxidentification = taxidentification;
            this.description = description;
            this.websitelink = websitelink;
            this.workingtimebegin = workingtimebegin;
            this.workingtimeend = workingtimeend;
            this.AvatarData = AvatarData;
            this.BusinessLicenseData = BusinessLicenseData;
        }
        public Company(Information information)
        {
            this.information  = information;
            List<string> otherinfo = companyDAO.FetchInformation(this.INFO.ID);
            FillOtherInfor(otherinfo);
            jobs = jobDao.FetchCompanyJob(this.INFO.ID);
            AvatarData = companyDAO.FetchImg(this.INFO.ID,"Avatar"); 
            BusinessLicenseData = companyDAO.FetchImg(this.INFO.ID, "BusinessLicense");   
        }
        private void FillOtherInfor(List<String> otherinfo)
        {
            companysize = otherinfo[1];
            companytype = otherinfo[0];
            description = otherinfo[2];
            taxidentification = otherinfo[3];
            websitelink = otherinfo[4];
            workingtimebegin = otherinfo[5];
            workingtimeend = otherinfo[6];
        }

        public List<Job> Jobs
        {
            get { return jobs; }
        }
        public Information INFO
        {
            get { return information; }
        }
        public string CompanyType
        {
            get { return companytype; }
        }
        public string CompanySize
        {
            get { return companysize; }
        }
        public string Description
        {
            get { return description; }
        }
        public string Taxidentification
        {
            get { return taxidentification; }
        }
        public string Websitelink
        {
            get { return websitelink; }
        }
        public string WorkingTimeBegin
        {
            get { return workingtimebegin; }
        }
        public string WorkingTimeEnd
        {
            get { return workingtimeend; }
        }
        public Image BusinessLicense
        {
            get { return BusinessLicenseData; }
        }
        public Image Avatar
        {
            get { return AvatarData;  }
        }

    }
}
