using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class RatingDAO
    {
        DBConnection conn = new DBConnection();

        public List<Ratings> AllRatings(string comID)
        {
            string strFetch = string.Format(@$"SELECT * FROM Rating WHERE companyID = '{comID}'");
            return conn.FetchAllRatings(strFetch);
        }

        public void RateCompany(Ratings rate)
        {
            string insertQuery = string.Format(@$"INSERT INTO [dbo].[Rating] ([JobSeekerID], [CompanyID], [content], [rate]) VALUES ('{rate.JsID}', '{rate.CompanyID}', '{rate.Contents}', '{rate.Rate}')");
            conn.CRUD(insertQuery);
        }
    }
}
