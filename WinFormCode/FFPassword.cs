namespace WinFormProject
{
    public partial class FFPassword : Form
    {
        public FFPassword()
        {
            InitializeComponent();
        }

        private void FFPassword_Load(object sender, EventArgs e)
        {


        }

        private void btnrspassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Closed += (s, args) => this.Close();
            fLogin.Show();
        }

        private void btnResetP_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOTP fLogin = new FOTP(txtemail.Text);
            fLogin.Closed += (s, args) => this.Close();
            fLogin.Show();
        }

    }
}