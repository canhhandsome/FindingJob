using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.OOPCODE;
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class FProfileCompany : Form
    {
        Company company = new Company();
        CompanyDAO companyDao = new CompanyDAO();
        List<Image> imageList;
        CompanyAddtionalImageDAO addtional = new CompanyAddtionalImageDAO();
        UCCarousel uCCarousel;
        public FProfileCompany(Company company)
        {
            InitializeComponent();
            Enable_Save_Click();

            this.company = company;
            imageList = addtional.FetchAllPictures(company.INFO.ID);
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
            if (company.Avatar != null) ptbAvatar.Image = company.Avatar;
            if (company.BusinessLicense != null) ptbLicense.Image = company.BusinessLicense;


            // Position and size of the UCCarousel control
            uCCarousel = new UCCarousel(imageList);
            this.Controls.Add(uCCarousel);
            uCCarousel.Location = new Point(43, 868);
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
            btnAdd.Visible = false;
            btnRemove.Visible = false;
        }
        private void Enable_Edit_Click()
        {
            this.btnChoosePicture.Location = new Point(975, 269);
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
            btnAdd.Visible = true;
            btnRemove.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable_Edit_Click();
        }
        private Company CompanyCreation()
        {
            Image AvatarData = null;
            Image BusinessData = null;
            List<Image> Images = new List<Image>();
            if (ptbAvatar.Image != null)
            {
                AvatarData = ptbAvatar.Image;
            }
            if (ptbLicense.Image != null)
            {
                BusinessData = ptbLicense.Image;
            }
            Information information = new Information(company.INFO.ID, txtCompanyName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
            return new Company(information, cbbCompanyType.Text, cbbCompanySize.Text, txtTaxIdentification.Text,
                txtDetail.Text, txtWebsiteLink.Text, cbbWTB.Text, cbbWTEnd.Text, AvatarData, BusinessData, Images); ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Enable_Save_Click();
            Company newcompany = CompanyCreation();
            companyDao.UpdateCompany(newcompany);
            addtional.InsertImage(company.INFO.ID, uCCarousel.images);
            imageList = uCCarousel.images;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uCCarousel.Add();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uCCarousel.Delete();
        }

        private void FProfileCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
