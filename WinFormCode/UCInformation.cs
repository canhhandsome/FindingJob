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
    public partial class UCInformation : UserControl
    {
        private Job job = new Job();
        CompanyDAO companyDAO = new CompanyDAO();
        string jsID = string.Empty;
        byte[] companyAvatar = new byte[100];
        public UCInformation(Job job, string jsID)
        {
            InitializeComponent();
            this.jsID = jsID;
            this.job = job;
            this.MaximumSize = new System.Drawing.Size(950, 234);
            FillInTemplate();
            PanelUtils.MakeRounded(this.panel1, 10);
        }
        public void FillInTemplate()
        {
            lblFromT.Text = companyDAO.FetchName(job.CompanyID);
            lblDateT.Text = job.DatePublish.ToString("dd/MM/yyyy");
            lblNameT.Text = job.Name;
            lblDateEndT.Text = job.DateEnd.ToString("dd/MM/yyyy");
            companyAvatar = companyDAO.FetchImg(job.CompanyID, "Avatar");
            ImageHandler.DisplayImage(companyAvatar, ref ptbCompanyPicture);
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            FJobDetails jobDetails = new FJobDetails(job, jsID);
            jobDetails.Show();
        }
    }
}
