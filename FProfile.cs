using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class FProfile : Form
    {
        JobSeeker seeker = new JobSeeker();
        public FProfile(JobSeeker jobSeeker)
        {
            InitializeComponent();
            seeker = jobSeeker;
            this.btnChoosePicture.Visible = false;
            this.btnSave.Visible = false ;
            this.ptbCV.Visible = false ;
            this.btnChooseNewCV.Visible = false ;
            this.btnCancel.Visible = false ;
            txtFullName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCitizenID.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            dtpkBirthDate.Enabled = false;
        }


        private void FillInfor()
        {
            txtFullName.Text = seeker.INFO.Name;
            txtCitizenID.Text = seeker.INFO.ID;
            txtEmail.Text = seeker.INFO.Email;
            txtPhoneNumber.Text = seeker.INFO.Phone;
            txtAddress.Text = seeker.INFO.Address;
        }

        private void FProfile_Load(object sender, EventArgs e)
        {
            FillInfor();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnChoosePicture.Visible = true;
            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;
            this.btnChooseNewCV.Visible = true;
            this.ptbCV.Visible = true;
            this.btnCV.Visible = false;
            this.btnCancel.Visible = true;
            txtFullName.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCitizenID.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            dtpkBirthDate.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnEdit.Visible = true;
            this.btnChoosePicture.Visible = false;
            this.btnSave.Visible = false;
            this.btnChooseNewCV.Visible = false;
            this.ptbCV.Visible = false;
            this.btnCV.Visible = true;
            this.btnCancel.Visible = false;
            txtFullName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCitizenID.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            dtpkBirthDate.Enabled = false;
        }
    }
}
