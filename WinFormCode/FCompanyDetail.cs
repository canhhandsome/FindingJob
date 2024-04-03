using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject.WinFormCode
{
    public partial class FCompanyDetail : Form
    {
        public FCompanyDetail()
        {
            InitializeComponent();
            Turnoff();
        }
        private void Turnoff()
        {
            txtCompanyName.Enabled = false;
            txtAddress.Enabled = false;
            cbbCompanyType.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtDetail.Enabled = false;
            txtWebsiteLink.Enabled = false;
            cbbWTB.Enabled = false;
            cbbWTEnd.Enabled = false;
            cbbCompanySize.Enabled = false;
        }
    }
}
