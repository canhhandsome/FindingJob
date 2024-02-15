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

        private void hopeSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Closed += (s, args) => this.Close();
            fLogin.Show();
        }
    }
}