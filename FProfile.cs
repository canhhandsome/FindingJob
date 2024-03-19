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
        JobSeeker jobseeker;
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        public FProfile(ref JobSeeker jobSeeker)
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
            else rdofemale.Checked = true;
            DisplayAvatar();
            DisplayCV();

        }
        private void DisplayAvatar()
        {
            byte[] imageData = jobseeker.Avatar;
            // Check if byte array is not null and has data
            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    // Create MemoryStream from byte array
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // Create Image from MemoryStream
                        Image img = Image.FromStream(ms);

                        // Set the Image to the PictureBox
                        ptbAvatar.Image = img;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                // Clear the PictureBox if byte array is null or empty
                ptbAvatar.Image = null;
            }
        }
        private void DisplayCV()
        {
            byte[] imageData = jobseeker.CV;
            // Check if byte array is not null and has data
            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    // Create MemoryStream from byte array
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // Create Image from MemoryStream
                        Image img = Image.FromStream(ms);

                        // Set the Image to the PictureBox
                        ptbCV.Image = img;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                // Clear the PictureBox if byte array is null or empty
                ptbCV.Image = null;
            }
        }
        private void FProfile_Load(object sender, EventArgs e)
        {


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
        public byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the image to the MemoryStream
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Saving as PNG for lossless compression

                // Return the byte array
                return ms.ToArray();
            }
        }

        private void btnChooseNewCV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();
            if (openFileDiaglog.ShowDialog() == DialogResult.OK)
            {
                ptbCV.Image = new Bitmap(openFileDiaglog.FileName);
            }
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();
            if (openFileDiaglog.ShowDialog() == DialogResult.OK)
            {
                ptbAvatar.Image = new Bitmap(openFileDiaglog.FileName);
            }
        }
        private JobSeeker CreateJobSeeker()
        {
            string gender = String.Empty;
            byte[] AvatarData = ImageToByteArray(ptbAvatar.Image);
            byte[] CvData = ImageToByteArray(ptbCV.Image);
            Information information = new Information(jobseeker.INFO.ID, txtFullName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
            if (rdofemale.Checked) gender = "female"; else gender = "male";
            return new JobSeeker(information, dtpkBirthDate.Value, txtCitizenID.Text, gender, AvatarData, CvData);
        }

    }
}
