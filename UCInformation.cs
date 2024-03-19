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
        string jsID;
        public UCInformation()
        {

        }
        public UCInformation(Job job, string jsID)
        {
            CompanyDAO companyDAO = new CompanyDAO();
            this.jsID = jsID;
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(968, 180);
            this.job = job;
            lblFromT.Text = companyDAO.FetchName(job.CompanyID);
            lblDateT.Text = job.DatePublish.ToString();
            lblNameT.Text = job.Name;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FJobDetails jobDetails = new FJobDetails(job, jsID);
            jobDetails.Show();
        }
    }
}
