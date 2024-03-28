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
using WinFormProject.OOPCODE;

namespace WinFormProject
{
    public partial class FProfile : Form
    {
        JobSeeker jobseeker;
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        byte[] Cv = new byte[0];
        public FProfile(JobSeeker jobSeeker)
        {
            InitializeComponent();
            this.jobseeker = jobSeeker; // Assign the reference to the member variable
            Enable_Save_Click();
            FillInfor();
        }


        private void FillInfor()
        {
            txtFullName.Text = jobseeker.INFO.Name;
            txtCitizenID.Text = jobseeker.INFO.ID;
            txtEmail.Text = jobseeker.INFO.Email;
            txtPhoneNumber.Text = jobseeker.INFO.Phone;
            txtAddress.Text = jobseeker.INFO.Address;
            dtpkBirthDate.Value = jobseeker.BDate;
            if (jobseeker.Gender == "male")
            {
                rdoMale.Checked = true;
            }
            else rdoFemale.Checked = true;
            if(jobseeker.Avatar!=null) ImageHandler.DisplayImage(jobseeker.Avatar, ref ptbAvatar);
            if(jobseeker.CV!=null) ImageHandler.DisplayPdfPreview(jobseeker.CV, ptbCV);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable_Edit_Click();
        }
        private void Enable_Edit_Click()
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
            Enable_Save_Click();
            JobSeeker newjseeker = CreateJobSeeker();
            jsDAO.UpdateJobSeeker(newjseeker);
            jobseeker = newjseeker;
        }
        private void Enable_Save_Click()
        {
            this.btnEdit.Visible = true;
            this.btnChoosePicture.Visible = false;
            this.btnSave.Visible = false;
            this.btnChooseNewCV.Visible = false;
            this.ptbCV.Visible = true;
            this.btnCV.Visible = true;
            this.btnCancel.Visible = false;
            txtFullName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCitizenID.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            dtpkBirthDate.Enabled = false;
        }
        private void btnChooseNewCV_Click(object sender, EventArgs e)
        {
            Cv = PDFHandler.OpenFileDialog();
            if(Cv!=null) ImageHandler.DisplayPdfPreview(Cv, ptbCV);

        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            ImageHandler.ChoosePicture(ref ptbAvatar);

        }
        private JobSeeker CreateJobSeeker()
        {
            string gender = String.Empty;
            byte[] AvatarData = new byte[1];
            if (ptbAvatar.Image != null)
            {
                AvatarData = ImageHandler.ImageToByteArray(ptbAvatar.Image);
            }
            byte[] CvData = new byte[1];
            if (ptbCV.Image != null)
            {
                CvData = Cv;
            }
            Information information = new Information(jobseeker.INFO.ID, txtFullName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
            if (rdoFemale.Checked) gender = "female"; else gender = "male";
            return new JobSeeker(information, dtpkBirthDate.Value, txtCitizenID.Text, gender, AvatarData, CvData);
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            FCV fcv = new FCV(jobseeker);
            fcv.Show();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FillInfor(); // Reload the form with the original data
            Enable_Save_Click(); // Re-enable the form for editing
        }
    }
}
