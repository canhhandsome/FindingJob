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
        CVDao cvdao = new CVDao();
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
            if (jobseeker.Avatar != null) ptbAvatar.Image = jobseeker.Avatar;
            if (jobseeker.CVData.CVPictureProperty != null) ptbCV.Image = jobseeker.CVData.CVPictureProperty;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Enable_Edit_Click();
        }
        private void Enable_Save_Click()
        {
            this.btnEdit.Visible = true;
            this.btnChoosePicture.Visible = false;
            this.btnSave.Visible = false;
            this.btnChooseNewCV.Visible = false;
            this.btnCancel.Visible = false;
            this.ptbCV.Visible = true;
            this.btnCV.Visible = true;
            txtFullName.Enabled = false;
            txtAddress.Enabled = false;
            txtCitizenID.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            dtpkBirthDate.Enabled = false;
            rdoFemale.Enabled = false;
            rdoMale.Enabled = false;
            btnEditJobPreferences.Visible = false;
            btnJobPreference.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Enable_Save_Click();
            JobSeeker newjseeker = CreateJobSeeker();
            jsDAO.UpdateJobSeeker(newjseeker);
            cvdao.UpdateCV(newjseeker.CVData);
            jobseeker = newjseeker;
        }
        private void Enable_Edit_Click()
        {
            this.btnChoosePicture.Visible = true;
            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;
            this.btnCancel.Visible = true;
            this.btnChooseNewCV.Visible = true;
            this.ptbCV.Visible = true;
            this.btnCV.Visible = false;
            txtFullName.Enabled = true;
            txtAddress.Enabled = true;
            txtCitizenID.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNumber.Enabled = true;
            dtpkBirthDate.Enabled = true;
            rdoMale.Enabled = true;
            rdoFemale.Enabled = true;
            btnEditJobPreferences.Visible = true;
            btnJobPreference.Visible = false;
        }
        private void btnChooseNewCV_Click(object sender, EventArgs e)
        {
            Cv = PDFHandler.OpenFileDialog();
            if (Cv != null) ImageHandler.DisplayPdfPreview(Cv, ptbCV);

        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            ImageHandler.ChoosePicture(ref ptbAvatar);

        }
        private JobSeeker CreateJobSeeker()
        {
            string gender;
            Image AvatarData = null;
            Image CVImage = null;
            if (ptbAvatar.Image != null)
            {
                AvatarData = ptbAvatar.Image;
            }
            byte[] CvData;
            if (ptbCV.Image != null && Cv.Length > 0)
            {
                CvData = Cv;
                CVImage = ptbCV.Image;
            }
            else
            {
                CvData = this.jobseeker.CVData.CVDataProperty;
                CVImage = this.jobseeker.CVData.CVPictureProperty;
            }

            Information information = new Information(jobseeker.INFO.ID, txtFullName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
            if (rdoFemale.Checked) gender = "female"; else gender = "male";
            jobseeker.CVData.CVDataProperty = CvData;
            jobseeker.CVData.CVPictureProperty = CVImage;
            jobseeker.CVData.JobSeekerID = information.ID;
            return new JobSeeker(information, dtpkBirthDate.Value, txtCitizenID.Text, gender, AvatarData, jobseeker.CVData);
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

        private void FProfile_Load(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
