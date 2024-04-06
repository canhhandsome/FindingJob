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
    public partial class FApplicant : Form
    {
        Company company;
        ApplyDAO applyDAO = new ApplyDAO();
        List<Apply> applies = new List<Apply> { };
        public FApplicant(Job job) 
        {
            InitializeComponent();
            applies = applyDAO.AllApplies(job.Jobid);
            foreach (Apply apply in applies)
            {
                UCApplicant uCApplicant = new UCApplicant(apply, job);
                flpApplicant.Controls.Add(uCApplicant);
                flpApplicant.Height += 600;
            }
        }

    }
}
