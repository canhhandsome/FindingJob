﻿using System.Data;
using System.Data.SqlClient;
using WinFormProject.OOPCODE;

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
            SkillListDAO sldao = new SkillListDAO();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string jobId = reader["jobid"].ToString().Trim();
                    string companyId = reader["CompanyId"].ToString().Trim();
                    string jobName = reader["JobName"].ToString().Trim();
                    string position = reader["position"].ToString().Trim();
                    string salary = reader["salary"].ToString().Trim();
                    string requirement = reader["requirement"].ToString().Trim();
                    string description = reader["description"].ToString().Trim();
                    string benefit = reader["benefit"].ToString().Trim();
                    DateTime dataPublish = Convert.ToDateTime(reader["datepublish"].ToString());
                    DateTime dateEnd = Convert.ToDateTime(reader["DateEnd"].ToString());
                    string status = reader["status"].ToString().Trim();
                    string workingForm = reader["workingform"].ToString().Trim();
                    List<string> skillList = sldao.GetSkills(jobId);
                    jobs.Add(new Job(jobId, companyId, jobName, position, salary, requirement, description, benefit, dataPublish, dateEnd, status, workingForm, skillList));
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
        public List<string> FetchAllJobSkill(string SQL)
        {
            List<string> SkillList = new List<string>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("Skill1")) && reader["Skill1"].ToString().Trim() != "NULL")
                        SkillList.Add(reader["Skill1"].ToString().Trim());

                    if (!reader.IsDBNull(reader.GetOrdinal("Skill2")) && reader["Skill2"].ToString().Trim() != "NULL")
                        SkillList.Add(reader["Skill2"].ToString().Trim());

                    if (!reader.IsDBNull(reader.GetOrdinal("Skill3")) && reader["Skill3"].ToString().Trim() != "NULL")
                        SkillList.Add(reader["Skill3"].ToString().Trim());
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
            return SkillList;
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
                    alerts.Add(new Alert(reader["id"].ToString(), reader["senderID"].ToString(), reader["recipientID"].ToString(), reader["subject"].ToString(), reader["content"].ToString(), reader["jobID"].ToString()));
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
                cmd.Parameters.AddWithValue("@Avatar", (object)ImageHandler.ImageToByteArray(jobseeker.Avatar) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CV", (object)jobseeker.CV ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CVPicture", (object)ImageHandler.ImageToByteArray(jobseeker.CVPicture) ?? DBNull.Value);
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
        public void CRUD(string SQL, Company company)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@Avatar", (object)ImageHandler.ImageToByteArray(company.Avatar) ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@BusinessLicense", (object)ImageHandler.ImageToByteArray(company.BusinessLicense) ?? DBNull.Value);
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
        public Image FetchInfoImages(string strFetch)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                byte[] result = null;

                while (reader.Read())
                {
                    if (!reader.IsDBNull(0)) // Check if the value is not null
                    {
                        result = (byte[])reader[0];
                        break; // Exit the loop after the first non-null value is found
                    }
                }

                if (result != null)
                {
                    return ImageHandler.ByteArrayToImage(result);
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

        public bool CheckApplyData(string SQL, string jobid, string jsid)
        {
            int rowsCount = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> list = new List<string>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        list.Add(reader["jobseekerID"].ToString());
                        list.Add(reader["JobID"].ToString());
                    }
                    if (list[0] == jsid && list[1] == jobid) rowsCount = 1;
                    else rowsCount = 0;
                }
                else rowsCount = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Operation failed. Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return rowsCount > 0;
        }
        public Company FetchCompanyById(string strFetch, string id)
        {
            Company company = new Company();
            List<string> seperatedinfo = new List<string>(2);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(strFetch, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Information information = new Information(reader["ID"].ToString(), reader["Name"].ToString(),
                        reader["Email"].ToString(), reader["Address"].ToString(), reader["Phonenumber"].ToString());
                    company = new Company(information);
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
            return company;
        }
        public List<Image> FetchAllImg(string strFetch)
        {
            List<Image> Images = new List<Image>();
            try
            {
               
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(strFetch, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Check if the value retrieved from the database is DBNull.Value
                            object img1 = reader["imgid1"];
                            object img2 = reader["imgid2"];
                            object img3 = reader["imgid3"];
                            object img4 = reader["imgid4"];
                            object img5 = reader["imgid5"];

                            if (img1 != DBNull.Value && img1!=null)
                                Images.Add(ImageHandler.ByteArrayToImage((byte[])img1));

                            if (img2 != DBNull.Value && img2 != null)
                                Images.Add(ImageHandler.ByteArrayToImage((byte[])img2));

                            if (img3 != DBNull.Value && img3 != null)
                                Images.Add(ImageHandler.ByteArrayToImage((byte[])img3));

                            if (img4 != DBNull.Value && img4 != null)
                                Images.Add(ImageHandler.ByteArrayToImage((byte[])img4));

                            if (img5 != DBNull.Value && img5 != null)
                                Images.Add(ImageHandler.ByteArrayToImage((byte[])img5));
                        }
                    }
                
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                Console.WriteLine("Operation failed. Error: " + ex.Message);
            }
            return Images;
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
        public string GetTheJobID(Job job)
        {
            string jobId = string.Empty;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertJobAndGetID", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Input parameters
                cmd.Parameters.AddWithValue("@CompanyID", job.CompanyID);
                cmd.Parameters.AddWithValue("@JobName", job.Name);
                cmd.Parameters.AddWithValue("@Position", job.Position);
                cmd.Parameters.AddWithValue("@Salary", job.Salary);
                cmd.Parameters.AddWithValue("@Requirement", job.Requirement);
                cmd.Parameters.AddWithValue("@Description", job.Description);
                cmd.Parameters.AddWithValue("@Benefit", job.Benefit);
                cmd.Parameters.AddWithValue("@WorkingForm", job.WorkingForm);
                cmd.Parameters.AddWithValue("@DateEnd", job.DateEnd);

                // Output parameter
                SqlParameter jobIdParam = new SqlParameter("@JobID", SqlDbType.VarChar, 4);
                jobIdParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(jobIdParam);

                // Execute the stored procedure
                cmd.ExecuteNonQuery();

                // Retrieve the output parameter value
                jobId = Convert.ToString(jobIdParam.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed, check again: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return jobId;
        }
        public void InsertImageIntoImgCompany(string SQL, string companyid, List<byte[]> imageBytes)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@companyId", companyid);
                cmd.Parameters.AddWithValue("@img1", (imageBytes[0] != null) ? (object)imageBytes[0] : DBNull.Value);
                cmd.Parameters.AddWithValue("@img2", (imageBytes[1] != null) ? (object)imageBytes[1] : DBNull.Value);
                cmd.Parameters.AddWithValue("@img3", (imageBytes[2] != null) ? (object)imageBytes[2] : DBNull.Value);
                cmd.Parameters.AddWithValue("@img4", (imageBytes[3] != null) ? (object)imageBytes[3] : DBNull.Value);
                cmd.Parameters.AddWithValue("@img5", (imageBytes[4] != null) ? (object)imageBytes[4] : DBNull.Value);


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

