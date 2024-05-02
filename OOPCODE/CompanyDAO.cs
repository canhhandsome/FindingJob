using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class CompanyDAO 
    {
        private DBConnection conn = new DBConnection();
        public CompanyDAO() { }
        public List<string> FetchInformation(string companyID)
        {
            string strFetch = string.Format("SELECT companytype,companysize,detail,taxidentification,websitelink,workingtimebegin,workingtimeend FROM {0} where id = '{1}'","company" ,companyID);
            return conn.FetchSeperatedData(strFetch);
        }

        public string FetchName(string companyid) 
        {
            string strFetch = string.Format("Select Name from company where id = '{0}'", companyid);
            return conn.FetchScalar(strFetch);
        }
        public Image FetchImg(string companyid, string whattotake)
        {
            string strFetch = string.Format("SELECT {0}  FROM Company WHERE id = '{1}'", whattotake,companyid);
            return conn.FetchInfoImages(strFetch);
        }
        
        public void UpdateCompany(Company company)
        {
            string sqlUpdate = string.Format("UPDATE Company SET Name = '{1}', Address = '{2}', Phonenumber = '{3}', CompanyType = '{4}', Email = '{5}', WebsiteLink = '{6}', TaxIdentification = '{7}', CompanySize = '{8}', WorkingTimeBegin = '{9}', WorkingTimeEnd = '{10}', Detail = '{11}', Avatar = @Avatar, BusinessLicense = @BusinessLicense WHERE ID = '{0}' ",
                    company.INFO.ID, company.INFO.Name, company.INFO.Address, company.INFO.Phone, company.CompanyType, company.INFO.Email, company.Websitelink,
                    company.Taxidentification, company.CompanySize, company.WorkingTimeBegin, company.WorkingTimeEnd, company.Description);
            conn.CRUD(sqlUpdate, company);
        }
        public Company FetchCompanyInformationBasedOnID(string id)
        {
            string strFetch = string.Format("Select * from Company where id = '{0}'", id);
            return conn.FetchCompanyById(strFetch, id);
        }

        public string GetCompanyWithMostRecruitedCandidates()
        {
            string strFetch = string.Format($"Select IDcompany From GetCompanyWithMostRecruitedCandidates();");
            return conn.FetchScalar(strFetch);
        }
    }
    
}
