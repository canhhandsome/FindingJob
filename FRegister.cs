using ReaLTaiizor.Extension;
using ReaLTaiizor.Helper;
using System.Data.SqlClient;

namespace WinFormProject
{
    public partial class FRegister : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FRegister()
        {
            InitializeComponent();
        }

        private void FRegister_Load(object sender, EventArgs e)
        {


        }

        private void hopeSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
        }

        private void labelEdit1_Click(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                materialCheckBox1.Checked = false;
            }
            else
                materialCheckBox1.Checked = true;

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!materialCheckBox1.Checked)
            {
                btnSignup.Enabled = false;
                btnSignup.BackColor = Color.White;
            }
            else
            {
                btnSignup.Enabled = true;
                btnSignup.BackColor = Color.Transparent;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Closed += (s, args) => this.Close();
            fLogin.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string type = (rdoCompany.Checked) ? "company" : "jobseeker";
            Form form = (rdoCompany.Checked) ? new FCompany() : new FJobSeeker();

            try
            {
                conn.Open();
                string sqlStr1 = string.Format("INSERT INTO Account(email, password, type) VALUES ('{0}', '{1}', '{2}')", txtEmail.Text, txtPassword.Text, type);

                string sqlStr3 = string.Format("select count(*) as C from {0}", type);
                SqlCommand cmd = new SqlCommand(sqlStr3, conn);
                int rowCount = (int)cmd.ExecuteScalar() + 1;
                string id = (type == "company") ? "C" + rowCount : "JS" + rowCount;
                string sqlStr2 = string.Format("INSERT INTO {0}(ID, email, name) VALUES ('{1}', '{2}', '{3}')", type, id, txtEmail.Text, txtPassword.Text);
                cmd = new SqlCommand(sqlStr1, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Sign Up success!!");
                cmd = new SqlCommand(sqlStr2, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to Sign Up" + ex);
            }
            finally
            {
                conn.Close();
            }
            conn.Close();
        }
    }
}