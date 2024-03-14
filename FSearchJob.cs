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
    public partial class FSearchJob : Form
    {
        private List<Job> jobs = new List<Job>();
        public FSearchJob()
        {
            InitializeComponent();
            JobDAO jobDAO = new JobDAO();
            jobs = jobDAO.FetchJob();
        }

        private void FSearchJob_Load(object sender, EventArgs e)
        {
            
        }
    }
}
