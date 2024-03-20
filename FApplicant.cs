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
        public FApplicant(Company company)
        {
            InitializeComponent();
            this.company = company;
            foreach(Apply apply in company.Applies)
            {
                UCApplicant uCApplicant = new UCApplicant(apply, company);
                flpApplicant.Controls.Add(uCApplicant);
            }
        }

        private void FApplicant_Load(object sender, EventArgs e)
        {

        }
    }
}
