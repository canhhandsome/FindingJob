using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormProject
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DBConnection()
        {

        }

        public bool AccountReader(string sqlReader, string email, string pass)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlReader, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (email == reader["Email"].ToString().Trim() && pass == reader["Password"].ToString().Trim())
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally { conn.Close(); }
            return false;
        }

    }
}
