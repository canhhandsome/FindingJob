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
    public partial class UCAlert : UserControl
    {
        Alert alert = new Alert();
        Image companyAvatar;
        JobDAO jobDAO = new JobDAO();
        public UCAlert(Alert alert)
        {
            InitializeComponent();
            this.alert = alert;
            this.MaximumSize = new System.Drawing.Size(531, 206);
            lblDateT.Text = alert.DateReply.ToString("dd/MM/yyyy");
            CompanyDAO companyDAO = new CompanyDAO();
            companyAvatar = companyDAO.FetchImg(alert.SenderID, "Avarta");
            if (companyAvatar != null)  ptbCompanyPicture.Image = companyAvatar;
            lblJobNameT.Text = jobDAO.FetchName(alert.JobID);
            lblFromT.Text = companyDAO.FetchName(alert.SenderID);
            lblSubjectT.Text = alert.Subject;
            PanelUtils.MakeRounded(this.panel1, 20);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FAlertView fAlertView = new FAlertView(alert);
            fAlertView.Show();
        }
    }
}
