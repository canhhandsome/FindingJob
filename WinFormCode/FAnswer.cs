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
    public partial class FAnswer : Form
    {
        Apply apply = new Apply();
        Company company = new Company();
        public FAnswer(Apply apply, Company company)
        {
            InitializeComponent();
            this.apply = apply;
            this.company = company;
            JobSeekerDAO jobSeekerDAO = new JobSeekerDAO();
            JobDAO jobDAO = new JobDAO();
            llFromT.Text = company.INFO.Name;
            lblToT.Text = jobSeekerDAO.FetchName(apply.JSeekerID);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            AlertDAO dAO = new AlertDAO();
            Alert alert = new Alert(company.INFO.ID, apply.JSeekerID, txtSubject.Text, txtContent.Text);
            dAO.InsertAlert(alert);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ApplyDAO applyDAO = new ApplyDAO();
            applyDAO.UpdateStatus("Waiting", apply);
            this.Close();
        }
    }
}
