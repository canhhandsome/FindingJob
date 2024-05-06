using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class FAlertView : Form
    {
        private Alert alert = new Alert();
        public FAlertView(Alert alert)
        {
            InitializeComponent();
            this.alert = alert;
            CompanyDAO companyDAO = new CompanyDAO();
            JobDAO jobDAO = new JobDAO();
            llFromT.Text = companyDAO.FetchName(alert.SenderID);
            lblContentT.Text = alert.Content;
            lblDateT.Text = alert.DateReply.ToString("dd/MM/yyyy");
            lblSubjectT.Text = alert.Subject;
            lblJobT.Text = jobDAO.FetchName(alert.JobID);
            CheckStatus();
        }

        private void CheckStatus()
        {
            if (lblSubjectT.Text.ToLower() == "approve")
            {
                btnDone.Location = new Point(736, 467);
                this.Height = 558;
                btnInterview.Visible = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInterview_Click(object sender, EventArgs e)
        {
            FInterview fInterview = new FInterview(alert.RecipientID, alert.JobID);   
            fInterview.Show();
        }
    }
}
