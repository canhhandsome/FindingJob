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
    public partial class FProfileCompany : Form
    {
        public FProfileCompany()
        {
            InitializeComponent();
            Enable_Save_Click();
        }
        private void Enable_Save_Click()
        {
            this.btnEdit.Visible = true;
            this.btnChoosePicture.Visible = false;
            this.btnSave.Visible = false;
            this.btnCancel.Visible = false;
            this.btnChooseLicense.Visible = false;
            txtCompanyName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCompanyType.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            txtDetail.Enabled = false;
            txtTaxIdentification.ReadOnly = true;
            txtWebsiteLink.ReadOnly = true;
            cbbWTB.Enabled = false;
            cbbWTEnd.Enabled = false;
            txtCompanySize.Enabled = false;
        }
        private void Enable_Edit_Click()
        {
            this.btnChoosePicture.Visible = true;
            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;
            this.btnCancel.Visible = true;
            this.btnChooseLicense.Visible = true;
            txtCompanyName.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCompanyType.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtCompanySize.Enabled = true;
            txtDetail.Enabled = true;
            txtTaxIdentification.ReadOnly = false;
            txtWebsiteLink.ReadOnly = false;
            cbbWTB.Enabled = true;
            cbbWTEnd.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable_Edit_Click();
        }
    }
}
