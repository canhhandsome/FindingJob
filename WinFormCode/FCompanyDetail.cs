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
        Company company = new Company();
        CompanyDAO companyDAO = new CompanyDAO();
        public FCompanyDetail(string companyid)
        {
            InitializeComponent();
            Turnoff();
            company = companyDAO.FetchCompanyInformationBasedOnID(companyid);
            FillInfor();
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
        private void FillInfor()
        {
            this.txtCompanyName.Text = company.INFO.Name;
            this.txtAddress.Text = company.INFO.Address;
            this.txtPhoneNumber.Text = company.INFO.Phone;
            this.txtEmail.Text = company.INFO.Email;
            this.cbbCompanyType.Text = company.CompanyType;
            this.cbbCompanySize.Text = company.CompanySize;
            this.cbbWTB.Text = company.WorkingTimeBegin;
            this.cbbWTEnd.Text = company.WorkingTimeEnd;
            if (company.Avatar != null) ImageHandler.DisplayImage(company.Avatar, ref ptbAvatar);
        }
    }
}
