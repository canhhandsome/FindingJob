using System.Data.SqlClient;

namespace WinFormProject
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            txtemail.KeyDown += new KeyEventHandler(YourForm_KeyDown);
            txtpassword.KeyDown += new KeyEventHandler(YourForm_KeyDown);
        }
        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRegister fRegister = new FRegister();
            fRegister.Closed += (s, args) => this.Close();
            fRegister.Show();
        }
        private void btnforgotpw_Click(object sender, EventArgs e)
        {
            this.Hide();
            FFPassword fFPassword = new FFPassword();
            fFPassword.Closed += (s, args) => this.Close();
            fFPassword.Show();
        }
        private void btnsignin_Click(object sender, EventArgs e)
        {
            string type = (rdocompany.Checked) ? "company" : "jobseeker";
            Account account = new Account(txtemail.Text, txtpassword.Text, type);
            Form form = (rdocompany.Checked) ? new FCompany(account) : new FJobSeeker(account);

            if (account.CheckAccount())
            {
                MessageBox.Show("Sign in Success!!!");
                this.Hide();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Fail To Sign In!!!");
            }
        }
        private void YourForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsignin_Click(sender, e);
            }
        }
    }
}