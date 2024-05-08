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

namespace WinFormProject.WinFormCode
{
    public partial class FFindApplicant : Form
    {
        string companyid;
        List<JobPreference> jobpreference = new List<JobPreference>();
        JobPreferenceDAO jobpreferenceDAO = new JobPreferenceDAO();
        CompanySendOfferDAO companysendOffer = new CompanySendOfferDAO();
        DBConnection conn = new DBConnection();
        public FFindApplicant(string companyid)
        {
            this.companyid = companyid;
            InitializeComponent();
            jobpreferenceDAO.FetchAllJobPreference(jobpreference);
            FillCandicate(jobpreference);
        }
        private void FillCandicate(List<JobPreference> lst)
        {
            pnSubBody.Controls.Clear();
            foreach (JobPreference jp in lst)
            {
                UCCandidate uCCandidate = new UCCandidate(jp, companyid);
                pnSubBody.Controls.Add(uCCandidate);
            }
        }

        private List<JobPreference> SearchNameJS(string search)
        {
            JobSeekerDAO jsDAO = new JobSeekerDAO();
            return jobpreference.Where(jp => jsDAO.FetchName(jp.JobSeekerId).ToLower().Contains(search)).ToList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillCandicate(SearchNameJS(txtSearch.Text.ToLower()));
            }
        }
    }
}
