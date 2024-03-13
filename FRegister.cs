using ReaLTaiizor.Extension;
using ReaLTaiizor.Helper;

namespace WinFormProject
{
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        private void FRegister_Load(object sender, EventArgs e)
        {


        }

        private void btnagree_CheckedChanged(object sender, EventArgs e)
        {
            if (!btnagree.Checked)
            {
                btnsignup.Enabled = false;
                btnsignup.BackColor = Color.White;
            }
            else
            {
                btnsignup.Enabled = true;
                btnsignup.BackColor = Color.Transparent;
            }
        }
        private void lblagree_Click(object sender, EventArgs e)
        {
            if (btnagree.Checked)
            {
                btnagree.Checked = false;
            }
            else
                btnagree.Checked = true;
        }
        private void btnsignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Closed += (s, args) => this.Close();
            fLogin.Show();
        }
    }
}