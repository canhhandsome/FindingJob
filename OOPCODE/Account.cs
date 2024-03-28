using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Account
    {
        string email = String.Empty;
        string password = String.Empty;
        string type = String.Empty;
        AccountDAO accountDAO = new AccountDAO();
        public Account()
        {

        }
        public Account(string email, string password,string type)
        {
            this.email = email;
            this.password = password;
            this.type = type;
        }
        public string Email
        {
            get { return email; }
        }
        public string Password
        {
            get { return password; }
        }
        public string Type
        {
            get { return type; }
        }
        public bool CheckAccount()
        {
            return accountDAO.GetAccount(this);
        }
    }
}
