using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject
{
    public class JobSeekerDAO
    {
        DBConnection conn = new DBConnection();

        public string FetchName(string id)
        {
            string strScalar = string.Format("SELECT name FROM jobseeker WHERE id = '{0}'", id);
            return conn.FetchScalar(strScalar);
        }
    }
}
