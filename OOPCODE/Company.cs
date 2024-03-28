using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Company
    {
        string companytype, companysize,taxidentification,description,websitelink;
        CompanyDAO companyDAO = new CompanyDAO();
        JobDAO jobDao = new JobDAO();
        ApplyDAO applyDAO = new ApplyDAO();
        Information information = new Information();
        List<Job> jobs = new List<Job>();
        byte[] AvatarData = new byte[0];
        byte[] BusinessLicense = new byte[0];
        public Company()
        {

        }
        public Company(Information information)
        {
            this.information  = information;
            List<string> otherinfo = companyDAO.FetchInformation(this);
            FillOtherInfor(otherinfo);
            jobs = jobDao.FetchCompanyJob(this.INFO.ID);
            AvatarData = companyDAO.FetchImg(this.INFO.ID,"Avatar");
            BusinessLicense = companyDAO.FetchImg(this.INFO.ID, "BusinessLicense");
            
        }
        private void FillOtherInfor(List<String> otherinfo)
        {
            companysize = otherinfo[1];
            companytype = otherinfo[0];
            description = otherinfo[2];
            taxidentification = otherinfo[3];
            websitelink = otherinfo[4];
        }
        public List<Job> Jobs
        {
            get { return jobs; }
        }
        public Information INFO
        {
            get { return information; }
        }

    }
}
