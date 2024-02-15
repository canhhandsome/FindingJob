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
    }
}