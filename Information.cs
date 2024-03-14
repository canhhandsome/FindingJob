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
        }
        
        public Information(string id, string name, string email, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.address = address;
            this.phone = phone;
        }
        public Account Account
        {
            get { return account; }
        }

        public string ID
        { get { return id; } }
        public string Name
        { get { return name; } }
        public string Email
        { get { return email; } }
        public string Address
        { get { return address; } }
        public string Phone
        { get { return phone; } }

    }
}
