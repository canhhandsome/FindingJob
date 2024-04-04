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
    public partial class FAlertView : Form
    {
        public FAlertView(Alert alert)
        {
            InitializeComponent();
            CompanyDAO companyDAO = new CompanyDAO();
            JobDAO jobDAO = new JobDAO();
            llFromT.Text = companyDAO.FetchName(alert.SenderID);
            lblContentT.Text = alert.Content;
            lblDateT.Text = alert.DateReply.ToString("dd/MM/yyyy");
            lblSubjectT.Text = alert.Subject;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
