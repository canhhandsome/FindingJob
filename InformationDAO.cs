using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class InformationDAO
    {
        DBConnection conn = new DBConnection();
        public InformationDAO()
        {

        }
        public Information FetchCommon(Account account)
        {
            string strFetch = string.Format("SELECT id, name, email, address, phonenumber FROM {0} where email = '{1}'", account.Type, account.Email);
            return conn.FetchData(strFetch);
        }
        public Information GetCommonByID(string id, string type) 
        {
            string strFetch = string.Format("Select id, name, email, address, phonenumber FROM {0} where id = '{1}'", type, id);
            return conn.FetchData(strFetch);
        }
    }
}
