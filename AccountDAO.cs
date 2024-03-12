using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class AccountDAO
    {
        DBConnection dBConnection = new DBConnection();
        public AccountDAO() { }

        public bool GetAccount(Account account)
        {
            string strSelect = string.Format("SELECT {0}.Email, Password, type, {0}.Name FROM Account A JOIN {0} ON A.Email = {0}.Email", account.Type);
            return dBConnection.AccountReader(strSelect, account.Email, account.Password);
        }
    }
}
