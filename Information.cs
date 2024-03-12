using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Information
    {
        protected string id  = string.Empty;
        protected string name = string.Empty;
        protected string email = string.Empty;
        protected string address = string.Empty;
        protected string phone = string.Empty;
        protected Account account;
        InformationDAO entityDAO = new InformationDAO();
        public Information()
        {
            id = string.Empty;
            name = string.Empty;
            email = string.Empty;
            address = string.Empty;
            phone = string.Empty;
        }
        public Information(Account account)
        {
            this.account = account;
            entityDAO.FetchCommon(this);
        }
    }
}
