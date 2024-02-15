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
                button1.Enabled = false;
                button1.BackColor = Color.White;
            }
            else
            {
                button1.Enabled = true;
                button1.BackColor= Color.Transparent;
            }
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