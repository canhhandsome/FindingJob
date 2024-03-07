using System.Data.SqlClient;

namespace WinFormProject
{
    public partial class FLogin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void hopeRoundButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FFPassword fFPassword = new FFPassword();
            fFPassword.Closed += (s, args) => this.Close();
            fFPassword.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRegister fRegister = new FRegister();
            fRegister.Closed += (s, args) => this.Close();
            fRegister.Show();
        }

        private void FLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string type = (rdoCompany.Checked) ? "company" : "jobseeker";
            Form form = (rdoCompany.Checked) ? new FCompany() : new FJobSeeker();
            conn.Open();
            string strSelect = string.Format("SELECT {0}.Email, Password, type, {0}.Name FROM Account A JOIN {0} ON A.Email = {0}.Email", type);
            SqlCommand cmdSelect = new SqlCommand(strSelect, conn);
            SqlDataReader reader = cmdSelect.ExecuteReader();
            bool ok = false;
            while (reader.Read())
            {
                if(type == reader["Type"].ToString().Trim())
                {
                    if (txtEmail.Text == reader["Email"].ToString().Trim() && txtPassword.Text == reader["Password"].ToString().Trim())
                    {
                        MessageBox.Show("Sign in Success!!!");
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        ok = true;
                    }
                }
            }
            if(!ok) 
            { 
                MessageBox.Show("Wrong information!!\nPlease enter again!"); 
            }
            conn.Close();
        }
    }
}