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
        public List<string> FetchInformation(Company company)
        {
            string strFetch = string.Format("SELECT companytype,companysize FROM {0} where id = '{1}'","company" ,company.INFO.ID);
            return conn.FetchSeperatedData(strFetch);
        }
    }
    
}
