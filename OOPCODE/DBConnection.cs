using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.CodeDom;
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
        //This is used for fetch common data ( the information of company and person)
        public Information FetchData(string strFetch)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                List<string> infor = new List<string>(5);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    infor.Add(reader.GetFieldValue<string>(i));
                }
                return new Information(infor[0], infor[1], infor[2], infor[3], infor[4]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
            return new Information();
        }
        //This is used for fetch uncommon data ( the information of company and person)

        public List<string> FetchSeperatedData(string strFetch)
        {
            List<string> seperatedinfo = new List<string>(2);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    seperatedinfo.Add(reader.IsDBNull(i) ? "" : reader.GetFieldValue<string>(i));
                }
                return seperatedinfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
            return seperatedinfo;

        }
        public string FetchScalar(string strFetch)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

            }
            finally 
            {
                conn.Close(); 
            }
            return "";
        }

        public void FetchHiringJob(string strFetch, List<Job> jobs)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    jobs.Add(new Job(reader["Jobid"].ToString().Trim(), reader["CompanyId"].ToString().Trim(), reader["JobName"].ToString().Trim(), reader["position"].ToString().Trim(), reader["salary"].ToString().Trim(), reader["requirement"].ToString().Trim(), reader["description"].ToString().Trim(), reader["benefit"].ToString().Trim(), Convert.ToDateTime(reader["datepublish"].ToString()), Convert.ToDateTime(reader["DateEnd"].ToString()), reader["status"].ToString().Trim()));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally 
            { 
                conn.Close(); 
            }
        }

        public void FetchAllApplies(string strFetch, List<Apply> applies)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    applies.Add(new Apply(reader["jobseekerID"].ToString(), reader["JobID"].ToString(), Convert.ToDateTime(reader["timeapply"].ToString()), reader["status"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void FetchAllAlert(string strFetch, List<Alert> alerts)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    alerts.Add(new Alert(reader["id"].ToString(), reader["senderID"].ToString(), reader["recipientID"].ToString(), reader["subject"].ToString(), reader["content"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void CRUD(string SQL)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Successfully");
                else MessageBox.Show("Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed, check again" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void CRUD(string SQL, JobSeeker jobseeker)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@BDate", jobseeker.BDate);
                cmd.Parameters.AddWithValue("@Avatar", jobseeker.Avatar);
                cmd.Parameters.AddWithValue("@CV", jobseeker.CV);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Successfully");
                else MessageBox.Show("Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed, check again" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public byte[] FetchBinaryData(string strFetch)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    return (byte[])result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to fetch binary data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}
