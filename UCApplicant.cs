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
    public partial class UCApplicant : UserControl
    {
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        JobDAO jobDAO = new JobDAO();
        public UCApplicant(Apply apply)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(950, 234);
            lblApplicantNameT.Text = jsDAO.FetchName(apply.JSeekerID);
            lblJobT.Text = jobDAO.FetchName(apply.JobID);
            lblDateT.Text = apply.DATE.ToString("dd/MM/yyyy");
        }
    }
}
