using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject.WinFormCode
{
    public partial class FInterview : Form
    {
        InterviewDAO interviewDAO = new InterviewDAO();
        Interview interview = new Interview();
        public FInterview(string jsID, string companyID, string jobID)
        {
            InitializeComponent();
            interview = interviewDAO.FetchInterview(jsID, companyID, jobID);
            FillInfor();
            guna2ShadowForm1.TargetForm = this;
        }

        private void FillInfor()
        {
            lblTimeInterview.Text = interview.TimeInterview;
            lblDateInterview.Text = interview.DateInterview.ToString("dd/MM/yyyy");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
