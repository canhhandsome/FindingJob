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

namespace WinFormProject
{
    public partial class UCAlert : UserControl
    {
        Alert alert = new Alert();
        JobOffer jobOffer = new JobOffer();
        Image companyAvatar;
        JobDAO jobDAO = new JobDAO();
        string type = "";
        public UCAlert(Alert alert)
        {
            InitializeComponent();
            this.alert = alert;
            this.MaximumSize = new System.Drawing.Size(531, 206);
            lblDateT.Text = alert.DateReply.ToString("dd/MM/yyyy");
            CompanyDAO companyDAO = new CompanyDAO();
            companyAvatar = companyDAO.FetchImg(alert.SenderID, "Avatar");
            if (companyAvatar != null)  ptbCompanyPicture.Image = companyAvatar;
            lblJobNameT.Text = jobDAO.FetchName(alert.JobID);
            lblFromT.Text = companyDAO.FetchName(alert.SenderID);
            lblSubjectT.Text = alert.Subject;
            PanelUtils.MakeRounded(this.panel1, 20);
            type = "Alert";
        }
        public UCAlert(JobOffer jobOffer)
        {
            InitializeComponent();
            this.jobOffer = jobOffer;
            this.MaximumSize = new System.Drawing.Size(531, 206);
            lblDateT.Text = jobOffer.DateReply.ToString("dd/MM/yyyy");
            CompanyDAO companyDAO = new CompanyDAO();
            companyAvatar = companyDAO.FetchImg(jobOffer.SenderID, "Avatar");
            if (companyAvatar != null) ptbCompanyPicture.Image = companyAvatar;
            lblJobNameT.Text = "JOB OFFER!!!!!";
            lblFromT.Text = companyDAO.FetchName(jobOffer.SenderID);
            lblSubjectT.Text = jobOffer.Subject;
            PanelUtils.MakeRounded(this.panel1, 20);
            type = "Offer";

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            FAlertView fAlertView;
            if (type =="Alert")
            {
                fAlertView = new FAlertView(alert);
            } else fAlertView = new FAlertView(jobOffer);
            fAlertView.Show();
        }
    }
}
