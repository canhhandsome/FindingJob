
namespace WinFormProject
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

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

        private void lblremember_Click(object sender, EventArgs e)
        {
            if (!swremember.Checked)
            {
                swremember.Checked = true;
            }
            else swremember.Checked = false;
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            string type = (rdocompany.Checked) ? "company" : "jobseeker";
            Account account = new Account(txtemail.Text, txtpassword.Text, type);
            if (account.CheckAccount())
            {
                if (rdocompany.Checked)
                {
                    Company company = new Company(account);
                }
                else { }
            }

        }
    }
}