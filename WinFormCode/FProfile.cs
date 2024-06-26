﻿using Guna.UI2.WinForms;
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
using WinFormProject.WinFormCode;

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

        private void btnSave_Click_Error(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Guna2TextBox txt)
                {
                    SetError(txt);
                }
                if (control is Guna2ComboBox cbb)
                {
                    SetError(cbb);
                }
            }
            SetError();
            SetError(dtpkBirthDate);
            foreach (Control control in this.Controls)
            {
                if (AnyErrors(control))
                {
                    return;
                }
            }
            btnSave_Click(sender, e);
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
        private void btnJobPreference_Click(object sender, EventArgs e)
        {
            FJobPreference fJobPreference = new FJobPreference(jobseeker.INFO.ID);
            fJobPreference.Show();
        }

        private void ptbCV_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCV_Click(object sender, EventArgs e)
        {
            FCVCreation fCV = new FCVCreation(jobseeker);
            fCV.Show();
        }


        public bool AnyErrors(Control control)
        {
            // Check if the control has an ErrorProvider and if it has any errors
            if (control is Guna.UI2.WinForms.Guna2TextBox txt)
            {
                if (!string.IsNullOrEmpty(epTxt.GetError(txt)))
                {
                    return true;
                }
            }

            if (control is Guna.UI2.WinForms.Guna2ComboBox cbb)
            {
                if (!string.IsNullOrEmpty(epCbb.GetError(cbb)))
                {
                    return true;
                }
            }


            foreach (Control childControl in control.Controls)
            {
                if (AnyErrors(childControl))
                {
                    return true;
                }
            }

            return false;
        }

        private void SetError(Guna2TextBox txt)
        {
            if (txt.Text.Length < 1)
            {
                epTxt.SetError(txt, "Textbox cannot be empty");
            }
            else
            {
                epTxt.SetError(txt, "");
            }
        }

        private void SetError(Guna2ComboBox cbb)
        {
            if (cbb.SelectedIndex < 0)
            {
                epTxt.SetError(cbb, "Must choose something!!!");
            }
            else
            {
                epTxt.SetError(cbb, "");
            }
        }
        private void SetError()
        {
            if(!rdoFemale.Checked && !rdoMale.Checked)
            {
                epRbtn.SetError(rdoFemale, "Can't empty here!");
            }
            else
            {
                epRbtn.SetError(rdoFemale, "");
            }
        }

        private void SetError(Guna2DateTimePicker dtp)
        {
            if (jobseeker.CheckAge(dtp.Value))
            {
                epDtp.SetError(dtp, "You are too young, pls return when you 16!");
            }
            else
            {
                epDtp.SetError(dtp, "");
            }
        }
    }
}
