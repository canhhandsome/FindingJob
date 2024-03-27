namespace WinFormProject
{
    public partial class FOTP : Form
    {
        public FOTP(string name)
        {
            InitializeComponent();
            lblForget.Text += name;
        }

        private void FOTP_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FFPassword fFPassword = new FFPassword();
            fFPassword.Closed += (s, args) => this.Close();
            fFPassword.Show();
        }

        private void btnResetP_Click(object sender, EventArgs e)
        {

        }
    }
}