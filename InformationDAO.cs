using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
