using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class Ratings
    {
        private string jsID;
        private string companyID;
        private int rates;
        private DateTime timerates;
        private string contents;

        public Ratings() 
        {

        }

        public Ratings(string jsID, string companyID, int rates, DateTime timerates, string contents)
        {
            this.jsID = jsID;
            this.companyID = companyID;
            this.rates = rates;
            this.timerates = timerates;
            this.contents = contents;
        }
        public Ratings(string jsID, string companyID, int rates, string contents)
        {
            this.jsID = jsID;
            this.companyID = companyID;
            this.rates = rates;
            this.contents = contents;
        }

        public string JsID
        { get { return jsID; } }
        public string CompanyID
        { get { return companyID; } }
        public int Rate
        { get { return rates; } }
        public DateTime Timerates
        { get { return timerates; } }
        public string Contents
        { get { return contents; } }

    }
}
