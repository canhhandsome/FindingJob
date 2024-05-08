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
            FillCandicate();
        }
        private void FillCandicate()
        {
            foreach (JobPreference jp in jobpreference)
            {
                if(!companysendOffer.AlreadySent(jp.JobSeekerId))
                {
                    UCCandidate uCCandidate = new UCCandidate(jp, companyid);
                    pnSubBody.Controls.Add(uCCandidate);
                }
            }
        }
    }
}
