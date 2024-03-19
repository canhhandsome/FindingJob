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
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {
            txtboxFullName.Focus();
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            txtboxAddress.Focus();
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {
            txtboxPhoneNumber.Focus();
        }

        private void lblCitizenId_Click(object sender, EventArgs e)
        {
            txtboxCitizenId.Focus();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            txtboxEmail.Focus();
        }

        private void lblPersonalLink_Click(object sender, EventArgs e)
        {
            txtboxPersonalLink.Focus();
        }

        private void lblDoB_Click(object sender, EventArgs e)
        {
            dtpkBirthDate.Focus();
        }

        private void FillInfor()
        {
            txtboxFullName.Text = seeker.INFO.Name;
            txtboxCitizenId.Text = seeker.INFO.ID;
            txtboxEmail.Text = seeker.INFO.Email;
            txtboxPhoneNumber.Text = seeker.INFO.Phone;
            txtboxAddress.Text = seeker.INFO.Address;
        }

        private void FProfile_Load(object sender, EventArgs e)
        {
            FillInfor();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.btnChoosePicture.Visible = true;
            this.btnEdit.Text = "Save";
        }
    }
}
