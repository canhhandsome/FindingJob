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
    public partial class FProfile : Form
    {
        public FProfile()
        {
            InitializeComponent();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {
            txtboxFullName.Focus();
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            txtboxAddress.Focus();
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {
            txtboxPhoneNumber.Focus();
        }

        private void lblCitizenId_Click(object sender, EventArgs e)
        {
            txtboxCitizenId.Focus();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            txtboxEmail.Focus();
        }

        private void lblPersonalLink_Click(object sender, EventArgs e)
        {
            txtboxPersonalLink.Focus();
        }

        private void lblDoB_Click(object sender, EventArgs e)
        {
            dtpkBirthDate.Focus();
        }
    }
}
