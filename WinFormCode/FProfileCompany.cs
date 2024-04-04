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
        Company company = new Company();
        CompanyDAO companyDao = new CompanyDAO();
        public FProfileCompany(Company company)
        {
            InitializeComponent();
            Enable_Save_Click();
            this.company = company;
            FillInfor();
        }
        private void FillInfor()
        {
            this.txtCompanyName.Text = company.INFO.Name;
            this.txtAddress.Text = company.INFO.Address;
            this.txtPhoneNumber.Text = company.INFO.Phone;
            this.txtEmail.Text = company.INFO.Email;
            this.cbbCompanyType.Text = company.CompanyType;
            this.cbbCompanySize.Text = company.CompanySize;
            this.txtTaxIdentification.Text = company.Taxidentification;
            this.cbbWTB.Text = company.WorkingTimeBegin;
            this.cbbWTEnd.Text = company.WorkingTimeEnd;
            if (company.Avatar != null) ImageHandler.DisplayImage(company.Avatar, ref ptbAvatar);
            if (company.BusinessLicense != null) ImageHandler.DisplayImage(company.BusinessLicense, ref ptbLicense);
        }
        private void Enable_Save_Click()
        {
            this.btnEdit.Visible = true;
            this.btnChoosePicture.Visible = false;
            this.btnSave.Visible = false;
            this.btnCancel.Visible = false;
            this.btnChooseLicense.Visible = false;
            txtCompanyName.Enabled = false;
            txtAddress.Enabled = false;
            cbbCompanyType.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtDetail.Enabled = false;
            txtTaxIdentification.Enabled = false;
            txtWebsiteLink.Enabled = false;
            cbbWTB.Enabled = false;
            cbbWTEnd.Enabled = false;
            cbbCompanySize.Enabled = false;
        }
        private void Enable_Edit_Click()
        {
            this.btnChoosePicture.Visible = true;
            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;
            this.btnCancel.Visible = true;
            this.btnChooseLicense.Visible = true;
            txtCompanyName.Enabled = true;
            txtAddress.Enabled = true;
            cbbCompanyType.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNumber.Enabled = true;
            cbbCompanySize.Enabled = true;
            txtDetail.Enabled = true;
            txtTaxIdentification.Enabled = true;
            txtWebsiteLink.Enabled = true;
            cbbWTB.Enabled = true;
            cbbWTEnd.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable_Edit_Click();
        }
        private Company CompanyCreation()
        {
            byte[] AvatarData = new byte[0];
            byte[] BusinessData = new byte[0];
            if (ptbAvatar.Image != null)
            {
                AvatarData = ImageHandler.ImageToByteArray(ptbAvatar.Image);
            }
            if (ptbLicense.Image != null)
            {
                BusinessData = ImageHandler.ImageToByteArray(ptbLicense.Image);
            }
            Information information = new Information(company.INFO.ID, txtCompanyName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
            return new Company(information, cbbCompanyType.Text, cbbCompanySize.Text, txtTaxIdentification.Text,
                txtDetail.Text, txtWebsiteLink.Text, cbbWTB.Text, cbbWTEnd.Text, AvatarData, BusinessData); ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Enable_Save_Click();
            Company newcompany = CompanyCreation();
            companyDao.UpdateCompany(newcompany);
            this.company = newcompany;

        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            ImageHandler.ChoosePicture(ref ptbAvatar);
        }

        private void btnChooseLicense_Click(object sender, EventArgs e)
        {
            ImageHandler.ChoosePicture(ref ptbLicense);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FillInfor(); // Reload tshe form with the original data
            Enable_Save_Click(); // Re-enable the form for editing
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptbAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
