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
            string strFetch = string.Format("SELECT companytype,companysize,details,taxindentification,websitelink FROM {0} where id = '{1}'","company" ,companyID);
            return conn.FetchSeperatedData(strFetch);
        }

        public string FetchName(string companyid) 
        {
            string strFetch = string.Format("Select Name from company where id = '{0}'", companyid);
            return conn.FetchScalar(strFetch);
        }
        public byte[] FetchImg(string companyid, string whattotake)
        {
            string strFetch = string.Format("SELECT {0}  FROM Company WHERE id = '{1}'", whattotake,companyid);
            // Assuming FetchScalar method executes the query and returns a single scalar value (in this case, the image data)
            return conn.FetchBinaryData(strFetch);
        }
    }
    
}
