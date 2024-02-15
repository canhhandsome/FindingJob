using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!\nGoodbye and See you again");
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Closed += (s, args) => this.Close();
            fLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Width == 42)
            {
                flowLayoutPanel1.Width = 186;
            }
            else flowLayoutPanel1.Width = 42;
        }
    }
}
